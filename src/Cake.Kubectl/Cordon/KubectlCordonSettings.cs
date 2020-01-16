using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Mark node as unschedulable.
	///
	/// </summary>
	/// <example>
	///   # Mark node "foo" as unschedulable.
	///   kubectl cordon foo
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCordonSettings : AutoToolSettings
	{
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on
		/// </summary>
		public string Selector { get; set; }
	}
}
