using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;

namespace KubectlParser
{
    public static class Exporter
    {
        public static void Export(string target, ImmutableArray<Command> commands)
        {
            foreach (var di in Directory.GetDirectories(target))
            {
                Directory.Delete(di, recursive: true);
            }
            foreach (var command in commands)
            {
                ExportCommand(target, ImmutableArray<string>.Empty, command);
            }
        }

        public static void ExportCommand(string target, ImmutableArray<string> previousVerbs, Command command)
        {
            var root = Directory.CreateDirectory(Path.Combine(target, command.PascalCaseVerb));
            CreateSettings(root.FullName, previousVerbs, command);
            CreateAlias(root.FullName, previousVerbs, command);
            foreach (var c in command.Commands)
            {
                ExportCommand(root.FullName, previousVerbs.Add(command.Verb), c);
            }
        }

        public static void CreateSettings(string root, ImmutableArray<string> previousVerbs, Command command)
        {
            string verbs = string.Join("", previousVerbs.Select(v => Command.PascalizeVerb(v)).ToImmutableArray().Add(command.PascalCaseVerb));

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("using System.Runtime.CompilerServices;");
            builder.AppendLine();
            builder.AppendLine("namespace Cake.Kubernetes");
            builder.AppendLine("{");
            builder.AppendLine("\t/// <summary>");
            builder.AppendLine($"\t/// {command.Short}");
            builder.AppendLine("\t///");
            foreach (string l in TrimLines(command.Description))
            {
                builder.AppendLine($"\t/// {l}");
            }
            builder.AppendLine("\t/// </summary>");
            if (command.Examples.Length > 0)
            {
                builder.AppendLine("\t/// <example>");
                foreach (string l in TrimLines(command.Examples))
                {
                    builder.AppendLine($"\t/// {l}");
                }
                builder.AppendLine("\t/// </example>");
            }
            builder.AppendLine("\t[CompilerGenerated]");
            builder.AppendLine($"\tpublic sealed class Kubernetes{verbs}Settings : AutoToolSettings");
            builder.AppendLine("\t{");
            foreach (var option in command.Options)
            {
                string name = $"--{option.Long}";
                if (!string.IsNullOrWhiteSpace(option.Short))
                {
                    name = $"-{option.Short}, {name}";
                }
                builder.AppendLine("\t\t/// <summary>");
                builder.AppendLine($"\t\t/// {name}");
                builder.AppendLine("\t\t///");
                builder.AppendLine($"\t\t/// {option.Description}");
                builder.AppendLine("\t\t/// </summary>");
                builder.AppendLine($"\t\tpublic {option.TypeName} {option.PropertyName} {{ get; set; }}");
            }
            builder.AppendLine("\t}");
            builder.AppendLine("}");
            string filename = Path.Combine(root, $"Kubernetes{verbs}Settings.cs");
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            File.WriteAllText(filename, builder.ToString());
        }

        public static void CreateAlias(string root, ImmutableArray<string> previousVerbs, Command command)
        {
            string verbs = string.Join("", previousVerbs.Select(v => Command.PascalizeVerb(v)).ToImmutableArray().Add(command.PascalCaseVerb));
            string settingsTypeName = $"Kubernetes{verbs}Settings";
            StringBuilder builder = new StringBuilder();
            foreach (var u in new string[] { "Cake.Core", "Cake.Core.Annotations", "System", "System.Collections.Generic", "System.Runtime.CompilerServices" }
            .OrderBy(u => u))
            {
                builder.AppendLine($"using {u};");
            }
            builder.AppendLine();
            builder.AppendLine("namespace Cake.Kubernetes");
            builder.AppendLine("{");
            builder.AppendLine("\tpartial class KubernetesAliases");
            builder.AppendLine("\t{");

            void AppendMethod(string? methodNamePostfix, string returnType, string runCommand, string? resultTypeMeta)
            {
                builder.AppendLine("\t\t/// <summary>");
                builder.AppendLine($"\t\t/// {command.Short}");
                builder.AppendLine("\t\t///");
                foreach (string l in TrimLines(command.Description))
                {
                    builder.AppendLine($"\t\t/// {l}");
                }
                builder.AppendLine("\t\t/// </summary>");
                string cmd = $"{string.Join(" ", previousVerbs)} {command.Verb}".Trim();
                builder.AppendLine("\t\t/// <param name=\"context\">The context.</param>");
                builder.AppendLine("\t\t/// <param name=\"settings\">The settings.</param>");
                if (!string.IsNullOrWhiteSpace(resultTypeMeta))
                {
                    builder.AppendLine($"\t\t/// <returns>{resultTypeMeta}</returns>");
                }
                builder.AppendLine("\t\t[CakeMethodAlias]");
                builder.AppendLine($"\t\tpublic static {returnType} Kubernetes{verbs}{methodNamePostfix}(this ICakeContext context, {settingsTypeName} settings)");
                builder.AppendLine($"\t\t{{");
                builder.AppendLine($"\t\t\tif (context == null)");
                builder.AppendLine($"\t\t\t{{");
                builder.AppendLine($"\t\t\t\tthrow new ArgumentNullException(nameof(context));");
                builder.AppendLine($"\t\t\t}}");
                builder.AppendLine($"\t\t\tvar arguments = new string[0];");
                builder.AppendLine($"\t\t\tvar runner = new GenericRunner<{settingsTypeName}>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);");
                string? returnKeyword = !string.IsNullOrWhiteSpace(methodNamePostfix) ? "return  " : null;
                builder.AppendLine($"\t\t\t{returnKeyword}runner.{runCommand}(\"{cmd}\", settings ?? new {settingsTypeName}(), arguments);");
                builder.AppendLine($"\t\t}}");
            }

            AppendMethod(methodNamePostfix: null, "void", "Run", resultTypeMeta: null);
            AppendMethod(methodNamePostfix: "WithResult", "IEnumerable<string>", "RunWithResult", "Output lines.");

            builder.AppendLine("\t}");
            builder.AppendLine("}");
            string filename = Path.Combine(root, $"Kubernetes.Alias.{verbs}.cs");
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            File.WriteAllText(filename, builder.ToString());
        }

        public static string[] TrimLines(string[] lines)
        {
            int? lastLine = null;
            for (int i = lines.Length-1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    lastLine = i;
                    break;
                }
            }
            if (lastLine.HasValue)
            {
                return lines.Take(lastLine.Value + 1).ToArray();
            }
            return new string[0];
        }
    }
}
