using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// List all available plugin files on a user's PATH.
	///
	/// 
	///  Available plugin files are those that are: - executable - anywhere on the user's PATH - begin with "kubectl-"
	/// </summary>
	/// <example>
	///   # List all available plugins
	///   kubectl plugin list
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlPluginListSettings : AutoToolSettings
	{
		/// <summary>
		/// --name-only
		///
		/// If true, display only the binary name of each plugin, rather than its full path
		/// </summary>
		public bool? NameOnly { get; set; }
	}
}
