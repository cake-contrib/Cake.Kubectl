namespace Cake.Kubernetes
{
    using System;
    using System.Collections.Generic;
    using Cake.Core;
    using Cake.Core.IO;
    using Cake.Core.Tooling;

    public sealed class KubernetesRunner : Tool<KubernetesSettings>
    {
        public KubernetesRunner(
            IFileSystem fileSystem,
            ICakeEnvironment environment,
            IProcessRunner processRunner,
            IToolLocator tools)
            : base(fileSystem, environment, processRunner, tools)
        {
        }

        public void Run(KubernetesSettings settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            this.Run(settings, GetArguments(settings));
        }

        protected override IEnumerable<string> GetToolExecutableNames()
        {
            yield return "Kubernetes.exe";
            yield return "Kubernetes";
        }

        protected override string GetToolName()
        {
            return "Kubernetes";
        }

        private static ProcessArgumentBuilder GetArguments(KubernetesSettings settings)
        {
            var builder = new ProcessArgumentBuilder();

            // TODO: Add the necessary arguments based on the settings class

            return builder;
        }
    }
}
