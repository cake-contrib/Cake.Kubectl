using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Update the annotations on one or more resources
	///
	/// 
	///  All Kubernetes objects support the ability to store additional data with the object as annotations. Annotations are key/value pairs that can be larger than labels and include arbitrary string values such as structured JSON. Tools and system extensions may use annotations to store their own data.
	/// 
	///  Attempting to set an annotation that already exists will fail unless --overwrite is set. If --resource-version is specified and does not match the current resource version on the server the command will fail.
	/// </summary>
	[CompilerGenerated]
	public sealed class KubernetesAnnotateSettings : AutoToolSettings
	{
	}
}
