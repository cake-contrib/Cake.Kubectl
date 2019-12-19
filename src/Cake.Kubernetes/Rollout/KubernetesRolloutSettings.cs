using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Manage the rollout of a resource.
	///
	/// 
	///  Valid resource types include:
	/// 
	///   *  deployments
	///   *  daemonsets
	///   *  statefulsets
	/// </summary>
	/// <example>
	///   # Rollback to the previous deployment
	///   kubectl rollout undo deployment/abc
	/// 
	///   # Check the rollout status of a daemonset
	///   kubectl rollout status daemonset/foo
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesRolloutSettings : AutoToolSettings
	{
	}
}
