using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Print a set of API resources generated from instructions in a kustomization.yaml file.
	///
	/// 
	///  The argument must be the path to the directory containing the file, or a git repository URL with a path suffix specifying same with respect to the repository root.
	/// 
	///  kubectl kustomize somedir
	/// </summary>
	/// <example>
	///   # Use the current working directory
	///   kubectl kustomize .
	/// 
	///   # Use some shared configuration directory
	///   kubectl kustomize /home/configuration/production
	/// 
	///   # Use a URL
	///   kubectl kustomize github.com/kubernetes-sigs/kustomize.git/examples/helloWorld?ref=v1.0.6
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlKustomizeSettings : AutoToolSettings
	{
	}
}
