using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Console;

namespace KubectlParser
{
    public class Program
    {
        static void Main(string[] args)
        {
            string target = args[0] ?? throw new ArgumentException("target", "Target directory is required");

            ImmutableArray<Command> commands;
            var cache = Persister.Load();
            if (cache.HasValue)
            {
                WriteLine("Getting commands from cache");
                commands = cache.Value.Commands;
            }
            else
            {
                var version = GetVersion();
                WriteLine($"Actual version is {version.Major}.{version.Minor}");
                WriteLine("Getting commands from kubectl");
                var verbs = GetVerbs();
                int allVerbs = verbs.Values.Sum(v => v.Length);
                WriteLine($"Got {allVerbs} total verbs");
                var commandInfo = ImmutableArray<CommandInfo>.Empty;
                foreach (string group in verbs.Keys)
                {
                    WriteLine(group);
                    foreach (string verb in verbs[group])
                    {
                        commandInfo = commandInfo.Add(GetCommandInfo(ImmutableArray<string>.Empty.Add(verb)));
                    }
                }
                commands = GetCommandsFromInfo(commandInfo);
                Persister.Save(commands, $"{version.Major}.{version.Minor}");
            }
            Exporter.Export(target, commands);
            if (Debugger.IsAttached)
            {
                WriteLine("Done");
                //ReadLine();
            }
        }

        public static ImmutableArray<Command> GetCommandsFromInfo(ImmutableArray<CommandInfo> info)
        {
            return info.Select(i => GetCommandFromInfo(i)).ToImmutableArray();
        }

        public static Command GetCommandFromInfo(CommandInfo info)
        {
            return new Command(
                info.Verb,
                info.Short,
                info.Description,
                info.Examples,
                info.SubCommandInfo.Select(i => GetCommandFromInfo(i)).ToImmutableArray(),
                options: info.Options
                    .Where(l => !string.IsNullOrWhiteSpace(l))
                    .Select(o => GetOptionFromText(o)).ToImmutableArray()
            );
        }

        public static Option GetOptionFromText(string line)
        {
            var trimmed = line.AsSpan().Trim();
            string longName;
            string? shortName;
            if (trimmed[1] == '-')
            {
                shortName = null;
                longName = GetLongName(trimmed);
            }
            else
            {
                shortName = GetShortName(trimmed);
                trimmed = trimmed.Slice(shortName.Length + 2).Trim();
                longName = GetLongName(trimmed);
            }
            trimmed = trimmed.Slice(longName.Length + 3);
            int column = trimmed.IndexOf(':');
            var defaultValueText = trimmed.Slice(0, column);
            object defaultValue = GetDefaultValueFromText(defaultValueText);
            string description = trimmed.Slice(column + 1).Trim().ToString();
            return new Option(shortName, longName, defaultValue, description, defaultValue.GetType());
        }

        public static Regex regex = new Regex("((?<hours>\\d+)h)?((?<minutes>\\d+)m)?((?<seconds>\\d+)s)?",
            RegexOptions.Singleline
            | RegexOptions.CultureInvariant
            | RegexOptions.Compiled
            );
        public static object GetDefaultValueFromText(ReadOnlySpan<char> text) =>
            text.ToString() switch
            {
                "true" => true,
                "false" => false,
                "[]" => string.Empty,
                "''" => string.Empty,
                "'json'" => string.Empty,
                "kubectl" => "kubectl",
                //"20s" => "20s",
                //"0s" => "0s",
                //"1m0s" => "1m0s",
                _ when regex.Matches(text.ToString()).Count == 2 => text.ToString(),
                "'https" => "https",
                _ when text.StartsWith("'") && text.EndsWith("'") => text.ToString(),
                "" => string.Empty,
                "[localhost]" => text.ToString(),
                _ when int.TryParse(text, out int value) => value,
                _ => text.ToString(),
                //_ => throw new ArgumentException(nameof(text), $"{text.ToString()} is unrecognized default value"),
            };

        public static string GetLongName(ReadOnlySpan<char> text)
        {
            int index = text.IndexOf('=');
            return text.Slice(2, index-2).ToString();
        }

        public static string GetShortName(ReadOnlySpan<char> text)
        {
            int index = text.IndexOf(',');
            return text.Slice(1, index-1).ToString();
        }

        public static ImmutableDictionary<string, string[]> GetVerbs()
        {
            var lines = Retriever.GetCommandOutput("--help");

            List<string[]> groups = new List<string[]>();

            List<string> group = new List<string>();
            foreach (var line in lines.Skip(4))
            {
                bool finished = line.StartsWith("Usage:", StringComparison.Ordinal);
                if (finished)
                {
                    break;
                }
                if (string.IsNullOrWhiteSpace(line))
                {
                    groups.Add(group.ToArray());
                    group.Clear();
                }
                else
                {
                    group.Add(line);
                }
            }

            Dictionary<string, string[]> result = new Dictionary<string, string[]>();
            foreach (var g in groups)
            {
                //   api-resources  Print the supported API resources on the server -> api-resources
                result.Add(g[0], g.Skip(1).Select(l => l.TrimStart().Split(' ')[0].Trim()).ToArray());
            }
            return result.ToImmutableDictionary();
        }

        static CommandInfo GetCommandInfo(ImmutableArray<string> verbs)
        {
            WriteLine(string.Join(" ", verbs));

            var lines = Retriever.GetCommandOutput($"{(string.Join(" ", verbs))} --help");

            CommandInfo result = new CommandInfo(verbs.Last());
            int index = 0;
            var description = GetGroup(ref index, lines)!;
            result.Short = description.Value.Caption;
            result.Description = description.Value.Lines;

            (string Caption, string[] Lines)? info;
            while ((info = GetGroup(ref index, lines)) != null)
            {
                switch (info.Value.Caption)
                {
                    case "Examples:":
                        result.Examples = info.Value.Lines;
                        break;
                    case "Available Commands:":
                        result.Commands = info.Value.Lines
                            .Where(l => !string.IsNullOrWhiteSpace(l))
                            .Select(l => ExtractNameFromAvailableCommand(l).ToString()).ToArray();
                        break;
                    case "Options:":
                        result.Options = info.Value.Lines;
                        break;
                    case "Usage:":
                        result.Usage = info.Value.Lines;
                        break;
                }
            }

            var rootVerbs = verbs.ToImmutableArray();
            result.SubCommandInfo = result.Commands.Select(c => GetCommandInfo(rootVerbs.Add(c))).ToImmutableArray();
            return result;
        }

        public static ReadOnlySpan<char> ExtractNameFromAvailableCommand(ReadOnlySpan<char> line)
        {
            var trimmed = line.TrimStart();
            int index = trimmed.IndexOf(' ');
            return trimmed.Slice(0, index);
        }

        public static (string Caption, string[] Lines)? GetGroup(ref int index, string[] lines)
        {
            string caption = lines[index];
            if (caption.StartsWith("Use \"", StringComparison.Ordinal))
            {
                return null;
            }
            index++;
            var group = new List<string>();
            string line;
            while ((line = lines[index]) == string.Empty || line.StartsWith(" ", StringComparison.Ordinal))
            {
                group.Add(line);
                index++;   
            }
            return (caption, group.ToArray());
        }

        static VersionInfo GetVersion()
        {
            var lines = Retriever.GetCommandOutput("version");
            string line = lines[0];
            int start = line.IndexOf('{');
            int end = line.LastIndexOf('}');
            string json = line.Substring(start, end - start + 1);
            var version = JsonConvert.DeserializeObject<VersionInfo>(json);
            return version;
        }
    }
}
