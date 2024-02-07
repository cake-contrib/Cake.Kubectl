using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Display resource (CPU/memory) usage of nodes.
	///
	/// 
	///  The top-node command allows you to see the resource consumption of nodes.
	/// </summary>
	/// <example>
	///   # Show metrics for all nodes
	///   kubectl top node
	/// 
	///   # Show metrics for a given node
	///   kubectl top node NODE_NAME
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlTopNodeSettings : AutoToolSettings
	{
		/// <summary>
		/// --no-headers
		///
		/// If present, print output without headers
		/// </summary>
		public bool? NoHeaders { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2). Matching objects must satisfy all of the specified label constraints.
		/// </summary>
		public string? Selector { get; set; }
		/// <summary>
		/// --show-capacity
		///
		/// Print node resources based on Capacity instead of Allocatable(default) of the nodes.
		/// </summary>
		public bool? ShowCapacity { get; set; }
		/// <summary>
		/// --sort-by
		///
		/// If non-empty, sort nodes list using specified field. The field can be either 'cpu' or 'memory'.
		/// </summary>
		public string? SortBy { get; set; }
		/// <summary>
		/// --use-protocol-buffers
		///
		/// Enables using protocol-buffers to access Metrics API.
		/// </summary>
		public bool? UseProtocolBuffers { get; set; }
	}
}
