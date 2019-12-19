using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Display one or many resources
	///
	/// 
	///  Prints a table of the most important information about the specified resources. You can filter the list using a label selector and the --selector flag. If the desired resource type is namespaced you will only see results in your current namespace unless you pass --all-namespaces.
	/// 
	///  Uninitialized objects are not shown unless --include-uninitialized is passed.
	/// 
	///  By specifying the output as 'template' and providing a Go template as the value of the --template flag, you can filter the attributes of the fetched resources.
	/// </summary>
	[CompilerGenerated]
	public sealed class KubernetesGetSettings : AutoToolSettings
	{
	}
}
