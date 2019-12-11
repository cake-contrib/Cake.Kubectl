namespace Cake.Kubernetes.Tests
{
    using System;
    using Cake.Core;
    using Cake.Testing;
    using Xunit;

    public class KubernetesRunnerTests
    {
        [Fact]
        public void Should_Throw_If_Settings_Are_Null()
        {
            var fixture = new KubernetesRunnerFixture { Settings = null };

            Action result = () => fixture.Run();

            Assert.Throws<ArgumentNullException>(result);
        }

        [Fact]
        public void Should_Throw_If_Kubernetes_Executable_Was_Not_Found()
        {
            var fixture = new KubernetesRunnerFixture();
            fixture.GivenDefaultToolDoNotExist();
            const string expectedMessage = "Kubernetes: Could not locate executable.";

            Action result = () => fixture.Run();

            var ex = Assert.Throws<CakeException>(result);
            Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void Need_More_Unit_Test_Implementations()
        {
            Assert.True(true, "More unit tests need to be implemented for the runner class");
        }
    }
}
