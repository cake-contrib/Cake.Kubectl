using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Show details of a specific resource or group of resources
	///
	/// 
	///  Print a detailed description of the selected resources, including related resources such as events or controllers. You may select a single object by name, all objects of that type, provide a name prefix, or label selector. For example:
	/// 
	///   $ kubectl describe TYPE NAME_PREFIX
	/// 
	///  will first check for an exact match on TYPE and NAME_PREFIX. If no such resource exists, it will output details for every resource that has a name prefixed with NAME_PREFIX.
	/// </summary>
	[CompilerGenerated]
	public sealed class KubernetesDescribeSettings : AutoToolSettings
	{
	}
}
