namespace Cake.Kubernetes
{
    using Cake.Core;
    using Cake.Core.Annotations;
    using Cake.Core.IO;

    [CakeAliasCategory("Kubernetes")]
    public static class KubernetesAliases
    {
        [CakeMethodAlias]
        public static void Kubernetes(this ICakeContext context)
        {
            Kubernetes(context, new KubernetesSettings());
        }

        [CakeMethodAlias]
        public static void Kubernetes(this ICakeContext context, KubernetesSettings settings)
        {
            var runner = new KubernetesRunner(
                context.FileSystem,
                context.Environment,
                context.ProcessRunner,
                context.Tools);
            runner.Run(settings);
        }
    }
}
