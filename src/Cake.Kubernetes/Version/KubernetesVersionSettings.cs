using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Print the client and server version information for the current context
	///
	/// </summary>
	/// <example>
	///   # Print the client and server versions for the current context
	///   kubectl version
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesVersionSettings : AutoToolSettings
	{
		/// <summary>
		/// --client
		///
		/// Client version only (no server required).
		/// </summary>
		public bool? Client { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// One of 'yaml' or 'json'.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --short
		///
		/// Print just the version number.
		/// </summary>
		public bool? Short { get; set; }
	}
}
