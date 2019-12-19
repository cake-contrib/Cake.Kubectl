using System.Collections.Immutable;

namespace KubectlParser
{
    public class CommandInfo
    {
        public string Verb { get; }
        public string Short { get; set; } = default!;
        public string[] Description { get; set; } = new string[0];
        public string[] Examples { get; set; } = new string[0];
        public string[] Commands { get; set; } = new string[0];
        public string[] Options { get; set; } = new string[0];
        public string[] Usage { get; set; } = new string[0];
        public ImmutableArray<CommandInfo> SubCommandInfo { get; set; }
        public CommandInfo(string verb)
        {
            Verb = verb;
        }
    }
}
