using NUnit.Framework;
using System.IO;

namespace Cake.Kubernetes.Tests.Create
{
    [TestFixture]
    public class Kubernetes
    {
        [Test]
        public void WhenFilenameIsGiven_CommandLineIsCorrect()
        {
            var fixture = new KubernetesCreateFixture
            {
                Settings = new KubernetesCreateSettings { Filename = Path.Combine("C:", "temp", "file.yml") }
            };

            var actual = fixture.Run();

            Assert.That(actual.Args, Is.EqualTo($"create --filename \"{fixture.Settings.Filename}\""));
        }

        [Test]
        public void WhenLongerOptionIsGiven_CommandLineIsCorrect()
        {
            var fixture = new KubernetesCreateFixture
            {
                Settings = new KubernetesCreateSettings { WindowsLineEndings = true }
            };

            var actual = fixture.Run();

            Assert.That(actual.Args, Is.EqualTo($"create --windows-line-endings"));
        }
    }
}
