using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Renames a context from the kubeconfig file.
	///
	/// 
	///  CONTEXT_NAME is the context name that you want to change.
	/// 
	///  NEW_NAME is the new name you want to set.
	/// 
	///  Note: If the context being renamed is the 'current-context', this field will also be updated.
	/// </summary>
	/// <example>
	///   # Rename the context 'old-name' to 'new-name' in your kubeconfig file
	///   kubectl config rename-context old-name new-name
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlConfigRenameContextSettings : AutoToolSettings
	{
	}
}
