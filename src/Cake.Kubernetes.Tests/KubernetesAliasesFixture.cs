namespace Cake.Kubernetes.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Cake.Core;
    using Cake.Core.IO;
    using Cake.Testing;
    using Cake.Testing.Fixtures;
    using Moq;

    public class KubernetesAliasesFixture : KubernetesRunnerFixture
    {
        internal ICakeContext _context;

        public KubernetesAliasesFixture()
        {
            var argumentsMoq = new Mock<ICakeArguments>();
            var registryMoq = new Mock<IRegistry>();
            var dataService = new Mock<ICakeDataService>();
            _context = new CakeContext(
                FileSystem,
                Environment,
                Globber,
                new FakeLog(),
                argumentsMoq.Object,
                ProcessRunner,
                registryMoq.Object,
                Tools,dataService.Object,
                Configuration);
        }

        protected override void RunTool()
        {
            if (Settings == null)
            {
                KubernetesAliases.Kubernetes(_context);
            }
            else
            {
                KubernetesAliases.Kubernetes(_context, Settings);
            }
        }
    }
}
