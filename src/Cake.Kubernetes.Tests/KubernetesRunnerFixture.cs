namespace Cake.Kubernetes.Tests
{
    using Cake.Testing.Fixtures;

    public class KubernetesRunnerFixture : ToolFixture<KubernetesSettings>
    {
        public KubernetesRunnerFixture()
            : base("Kubernetes.exe")
        {
        }

        protected override void RunTool()
        {
            var tool = new KubernetesRunner(FileSystem, Environment, ProcessRunner, Tools);
            tool.Run(Settings);
        }
    }
}
