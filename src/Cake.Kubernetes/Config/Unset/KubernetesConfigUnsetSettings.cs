using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Unsets an individual value in a kubeconfig file
	///
	/// 
	///  PROPERTY_NAME is a dot delimited name where each token represents either an attribute name or a map key.  Map keys may not contain dots.
	/// </summary>
	/// <example>
	///   # Unset the current-context.
	///   kubectl config unset current-context
	/// 
	///   # Unset namespace in foo context.
	///   kubectl config unset contexts.foo.namespace
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesConfigUnsetSettings : AutoToolSettings
	{
	}
}
