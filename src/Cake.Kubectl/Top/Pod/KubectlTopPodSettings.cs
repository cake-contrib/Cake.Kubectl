using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Display resource (CPU/memory) usage of pods.
	///
	/// 
	///  The 'top pod' command allows you to see the resource consumption of pods.
	/// 
	///  Due to the metrics pipeline delay, they may be unavailable for a few minutes since pod creation.
	/// </summary>
	/// <example>
	///   # Show metrics for all pods in the default namespace
	///   kubectl top pod
	/// 
	///   # Show metrics for all pods in the given namespace
	///   kubectl top pod --namespace=NAMESPACE
	/// 
	///   # Show metrics for a given pod and its containers
	///   kubectl top pod POD_NAME --containers
	/// 
	///   # Show metrics for the pods defined by label name=myLabel
	///   kubectl top pod -l name=myLabel
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlTopPodSettings : AutoToolSettings
	{
		/// <summary>
		/// -A, --all-namespaces
		///
		/// If present, list the requested object(s) across all namespaces. Namespace in current context is ignored even if specified with --namespace.
		/// </summary>
		public bool? AllNamespaces { get; set; }
		/// <summary>
		/// --containers
		///
		/// If present, print usage of containers within a pod.
		/// </summary>
		public bool? Containers { get; set; }
		/// <summary>
		/// --field-selector
		///
		/// Selector (field query) to filter on, supports '=', '==', and '!='.(e.g. --field-selector key1=value1,key2=value2). The server only supports a limited number of field queries per type.
		/// </summary>
		public string? FieldSelector { get; set; }
		/// <summary>
		/// --no-headers
		///
		/// If present, print output without headers.
		/// </summary>
		public bool? NoHeaders { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2). Matching objects must satisfy all of the specified label constraints.
		/// </summary>
		public string? Selector { get; set; }
		/// <summary>
		/// --sort-by
		///
		/// If non-empty, sort pods list using specified field. The field can be either 'cpu' or 'memory'.
		/// </summary>
		public string? SortBy { get; set; }
		/// <summary>
		/// --sum
		///
		/// Print the sum of the resource usage
		/// </summary>
		public bool? Sum { get; set; }
		/// <summary>
		/// --use-protocol-buffers
		///
		/// Enables using protocol-buffers to access Metrics API.
		/// </summary>
		public bool? UseProtocolBuffers { get; set; }
	}
}
