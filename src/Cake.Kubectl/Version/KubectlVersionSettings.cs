using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Print the client and server version information for the current context.
	///
	/// </summary>
	/// <example>
	///   # Print the client and server versions for the current context
	///   kubectl version
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlVersionSettings : AutoToolSettings
	{
		/// <summary>
		/// --client
		///
		/// If true, shows client version only (no server required).
		/// </summary>
		public bool? Client { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// One of 'yaml' or 'json'.
		/// </summary>
		public string? Output { get; set; }
	}
}
