using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace KubectlParser
{
    public static class Retriever
    {
        public static string[] GetCommandOutput(string args)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C kubectl {args}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            //Console.WriteLine($"Processing {args}");
            proc.Start();
            var result = new List<string>();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine()!.TrimEnd();
                result.Add(line);
            }
            return result.ToArray();
        }
    }
}
