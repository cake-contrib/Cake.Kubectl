using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Display addresses of the master and services with label kubernetes.io/cluster-service=true To further debug and diagnose cluster problems, use 'kubectl cluster-info dump'.
	///
	/// </summary>
	/// <example>
	///   # Print the address of the master and cluster services
	///   kubectl cluster-info
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesClusterInfoSettings : AutoToolSettings
	{
	}
}
