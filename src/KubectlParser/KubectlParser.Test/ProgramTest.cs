using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace KubectlParser.Test
{
    public class ProgramTest
    {
        [TestFixture]
        public class GetGroup
        {
            public string[] GetSampleContent()
            {
                return File.ReadAllLines("sample.txt");
            }
            [Test]
            public void GivenSample_ParsesDescription()
            {
                var sourceLines = GetSampleContent();
                int index = 0;

                var actual = Program.GetGroup(ref index, sourceLines);

                Assert.That(actual.Value.Caption, Is.EqualTo("Create a resource from a file or from stdin."));
                string[] lines = actual.Value.Lines;
                Assert.That(lines.Length, Is.EqualTo(3));
                Assert.That(lines[0], Is.Empty);
                Assert.That(lines[1], Is.EqualTo(" JSON and YAML formats are accepted."));
                Assert.That(lines[2], Is.Empty);
            }
            [Test]
            public void GivenSample_ParsesUsageCorrectly()
            {
                var sourceLines = GetSampleContent();
                int index = 0;

                (string Caption, string[] Lines)? group;
                (string Caption, string[] Lines)? lastGroup = null;
                while ((group = Program.GetGroup(ref index, sourceLines)).HasValue)
                {
                    lastGroup = group;
                }

                Assert.That(lastGroup.Value.Caption, Is.EqualTo("Usage:"));
                string[] lines = lastGroup.Value.Lines;
                Assert.That(lines.Length, Is.EqualTo(2));
                Assert.That(lines[0], Is.EqualTo("  kubectl create -f FILENAME [options]"));
                Assert.That(lines[1], Is.Empty);
            }
        }
        [TestFixture]
        public class GetOptionFromText
        {
            [Test]
            public void WhenOptionHasOnlyLongName_ParsesIt()
            {
                const string text = "      --allow-missing-template-keys=true:";
                var description = new List<string> { "If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats." };

                var option = Program.GetOptionFromText(text, description);

                Assert.That(option.Short, Is.Null);
                Assert.That(option.Long, Is.EqualTo("allow-missing-template-keys"));
            }
            [Test]
            public void WhenOptionHasOnlyLongNameAndDefaultIsTrue_ParsesDefault()
            {
                const string text = "      --allow-missing-template-keys=true:";
                var description = new List<string> { "If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats." };

                var option = Program.GetOptionFromText(text, description);

                Assert.That(option.Default, Is.True);
            }
            [Test]
            public void WhenOptionHasOnlyLongName_ParsesDescription()
            {
                const string text = "      --allow-missing-template-keys=true:";
                var description = new List<string> { "If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats." };

                var option = Program.GetOptionFromText(text, description);

                Assert.That(option.Description, Is.EqualTo("If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats."));
            }
            [Test]
            public void WhenOptionHasShortAndLongName_ParsesBoth()
            {
                const string text = "  -f, --filename=[]:";
                var description = new List<string> { "Filename, directory, or URL to files to use to create the resource" };

                var option = Program.GetOptionFromText(text, description);

                Assert.That(option.Short, Is.EqualTo("f"));
                Assert.That(option.Long, Is.EqualTo("filename"));
            }
        }

        [TestFixture]
        public class ExtractNameFromAvailableCommand
        {
            [Test]
            public void GivenAvailableCommand_ExtractsName()
            {
                const string text = "  clusterrole         Create a ClusterRole.";

                var actual = Program.ExtractNameFromAvailableCommand(text);

                Assert.That(actual.ToString(), Is.EqualTo("clusterrole"));
            }
        }
    }
}
