using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Displays one or many contexts from the kubeconfig file.
	///
	/// </summary>
	/// <example>
	///   # List all the contexts in your kubeconfig file
	///   kubectl config get-contexts
	/// 
	///   # Describe one context in your kubeconfig file.
	///   kubectl config get-contexts my-context
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesConfigGetContextsSettings : AutoToolSettings
	{
		/// <summary>
		/// --no-headers
		///
		/// When using the default or custom-column output format, don't print headers (default print headers).
		/// </summary>
		public bool? NoHeaders { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: name
		/// </summary>
		public string Output { get; set; }
	}
}
