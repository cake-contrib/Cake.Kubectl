using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Modify kubeconfig files using subcommands like "kubectl config set current-context my-context"
	///
	/// 
	///  The loading order follows these rules:
	/// 
	///   1.  If the --kubeconfig flag is set, then only that file is loaded. The flag may only be set once and no merging takes place.
	///   2.  If $KUBECONFIG environment variable is set, then it is used as a list of paths (normal path delimiting rules for your system). These paths are merged. When a value is modified, it is modified in the file that defines the stanza. When a value is created, it is created in the first file that exists. If no files in the chain exist, then it creates the last file in the list.
	///   3.  Otherwise, ${HOME}/.kube/config is used and no merging takes place.
	/// </summary>
	[CompilerGenerated]
	public sealed class KubectlConfigSettings : AutoToolSettings
	{
	}
}
