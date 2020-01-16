using NUnit.Framework;
using System.IO;

namespace Cake.Kubectl.Tests.Create
{
    [TestFixture]
    public class Kubectl
    {
        [Test]
        public void WhenFilenameIsGiven_CommandLineIsCorrect()
        {
            var fixture = new KubectlCreateFixture
            {
                Settings = new KubectlCreateSettings { Filename = Path.Combine("C:", "temp", "file.yml") }
            };

            var actual = fixture.Run();

            Assert.That(actual.Args, Is.EqualTo($"create --filename \"{fixture.Settings.Filename}\""));
        }

        [Test]
        public void WhenLongerOptionIsGiven_CommandLineIsCorrect()
        {
            var fixture = new KubectlCreateFixture
            {
                Settings = new KubectlCreateSettings { WindowsLineEndings = true }
            };

            var actual = fixture.Run();

            Assert.That(actual.Args, Is.EqualTo($"create --windows-line-endings"));
        }
    }
}
