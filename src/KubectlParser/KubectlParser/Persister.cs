using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace KubectlParser
{
    public static class Persister
    {
        const string name = "cache.xml";
        static readonly string root = Path.GetDirectoryName(typeof(Persister).Assembly.Location)!;
        static string FilePath => Path.Combine(root, name);
        public static void Save(ImmutableArray<Command> commands, string version)
        {
            string filePath = FilePath;
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            var doc = new XDocument();
            var node = new XElement("Root", new XAttribute("Version", version),
                new XElement("Commands", Add(commands))
            );
            doc.Add(node);
            doc.Save(filePath);
        }

        public static (string Version, ImmutableArray<Command> Commands)? Load()
        {
            string filePath = FilePath;
            if (!File.Exists(filePath))
            {
                return null;
            }
            XDocument doc = XDocument.Load(filePath);
            var root = doc.Root;
            var commands = LoadCommands(root.Element("Commands"));
            var version = (string)root.Attribute("Version");
            return (version, commands);
        }

        public static ImmutableArray<Command> LoadCommands(XElement element)
        {
            var query = from e in element.Elements("Command")
                        select new Command(
                            (string)e.Attribute(nameof(Command.Verb)),
                            (string)e.Attribute(nameof(Command.Short)),
                            GetMultiline(e.Element(nameof(Command.Description))),
                            GetMultiline(e.Element(nameof(Command.Examples))),
                            LoadCommands(e.Element("Commands")),
                            LoadOptions(e.Element("Options"))
                        );
            return query.ToImmutableArray();
        }

        public static string[] GetMultiline(XElement element)
        {
            return element.Elements("Line").Select(e => e.Value).ToArray();
        }

        public static ImmutableArray<Option> LoadOptions(XElement element)
        {
            var query = from e in element.Elements("Option")
                        let type = (string)e.Attribute(nameof(Option.Type))
                        let longName = (string)e.Attribute(nameof(Option.Long))
                        select new Option(
                            (string)e.Attribute(nameof(Option.Short)),
                            longName,
                            // don't persist default for now
                            new object(),
                            (string)e.Attribute(nameof(Option.Description)),
                            Type.GetType(type) ?? throw new Exception($"Type {type} not known for option {longName}")
                        );
            return query.ToImmutableArray();
        }

        public static XElement[] Add(ImmutableArray<Command> commands)
        {
            var elements = new List<XElement>(commands.Length);
            foreach (var command in commands)
            {
                var childElement = new XElement("Command",
                    new XAttribute(nameof(command.Verb), command.Verb),
                    new XAttribute(nameof(command.Short), command.Short),
                    new XElement(nameof(command.Description), SaveMultiline(command.Description)),
                    new XElement(nameof(command.Examples), SaveMultiline(command.Examples)),
                    new XElement(nameof(command.Options), AddOptions(command.Options)),
                    new XElement(nameof(command.Commands), Add(command.Commands)));
                elements.Add(childElement);
            }
            return elements.ToArray();
        }

        public static XElement[] SaveMultiline(string[] lines)
        {
            return lines.Select(l => new XElement("Line", l ?? "")).ToArray();
        }

        public static XElement[] AddOptions(ImmutableArray<Option> options)
        {
            var elements = new List<XElement>(options.Length);
            foreach (var option in options)
            {
                var childElement = new XElement("Option",
                    option.Short != null ? new XAttribute(nameof(option.Short), option.Short): null,
                    new XAttribute(nameof(option.Long), option.Long),
                    new XAttribute(nameof(option.Description), option.Description),
                    new XAttribute(nameof(option.Type), option.Type.ToString())
                    );
                elements.Add(childElement);
            }
            return elements.ToArray();
        }

        public static string? GetCacheVersion()
        {
            string filePath = FilePath;
            if (File.Exists(filePath))
            {
                var doc = XDocument.Load(filePath);
                var root = doc.Root;
                return (string)root.Attribute("Version");
            }
            return null;
        }
    }
}
