using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Manage the rollout of one or many resources.
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
	/// 
	///   # Restart a deployment
	///   kubectl rollout restart deployment/abc
	/// 
	///   # Restart deployments with the app=nginx label
	///   kubectl rollout restart deployment --selector=app=nginx
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlRolloutSettings : AutoToolSettings
	{
	}
}
