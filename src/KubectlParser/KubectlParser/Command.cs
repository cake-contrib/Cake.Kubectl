using Humanizer;
using System;
using System.Collections.Immutable;

namespace KubectlParser
{
    public class Command
    {
        public string Verb { get; }
        public string Short { get; }
        public string[] Description { get; }
        public string[] Examples { get; }
        public ImmutableArray<Command> Commands { get; }
        public ImmutableArray<Option> Options { get; }
        public Command(string verb, string shortDescription, string[] description, string[] examples, ImmutableArray<Command> commands, ImmutableArray<Option> options)
        {
            Verb = verb;
            Short = shortDescription;
            Description = description;
            Examples = examples;
            Commands = commands;
            Options = options;
        }
        public string PascalCaseVerb => PascalizeVerb(Verb);
        public static string PascalizeVerb(string verb) => verb.Replace('-', ' ').Pascalize();
    }
}
