using System;

namespace KubectlParser
{
    public struct VersionInfo
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public string GitVersion { get; set; }
        public string GitCommit { get; set; }
        public DateTimeOffset BuildDate { get; set; }
    }
}
