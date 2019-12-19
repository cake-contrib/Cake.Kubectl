using Humanizer;
using System;

namespace KubectlParser
{
    public class Option
    {
        public string? Short { get; }
        public string Long { get; }
        public object Default { get; }
        public string Description { get; }
        public Type Type { get; }
        public Option(string? shortName, string longName, object defaultValue, string description, Type type)
        {
            Short = shortName;
            Long = longName;
            Default = defaultValue;
            Description = description;
            Type = type;
        }
        public string PropertyName => Long.Replace('-', ' ').Pascalize();
        public string TypeName
        {
            get 
            {
                if (Type == typeof(bool))
                {
                    return "bool?";
                }
                else if (Type == typeof(string))
                {
                    return "string";
                }
                else if (Type == typeof(int))
                {
                    return "int?";
                }
                else
                {
                    throw new Exception($"Unknown type {Type.Name}");
                }
            }
        }
    }
}
