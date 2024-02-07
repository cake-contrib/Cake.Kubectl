using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Mark node as unschedulable.
	///
	/// </summary>
	/// <example>
	///   # Mark node "foo" as unschedulable
	///   kubectl cordon foo
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCordonSettings : AutoToolSettings
	{
		/// <summary>
		/// --dry-run
		///
		/// Must be "none", "server", or "client". If client strategy, only print the object that would be sent, without sending it. If server strategy, submit server-side request without persisting the resource.
		/// </summary>
		public string? DryRun { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2). Matching objects must satisfy all of the specified label constraints.
		/// </summary>
		public string? Selector { get; set; }
	}
}
