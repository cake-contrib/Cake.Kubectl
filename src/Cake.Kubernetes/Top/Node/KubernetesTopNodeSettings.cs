using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Display Resource (CPU/Memory/Storage) usage of nodes.
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
	public sealed class KubernetesTopNodeSettings : AutoToolSettings
	{
		/// <summary>
		/// --heapster-namespace
		///
		/// Namespace Heapster service is located in
		/// </summary>
		public string HeapsterNamespace { get; set; }
		/// <summary>
		/// --heapster-port
		///
		/// Port name in service to use
		/// </summary>
		public string HeapsterPort { get; set; }
		/// <summary>
		/// --heapster-scheme
		///
		/// Scheme (http or https) to connect to Heapster as
		/// </summary>
		public string HeapsterScheme { get; set; }
		/// <summary>
		/// --heapster-service
		///
		/// Name of Heapster service
		/// </summary>
		public string HeapsterService { get; set; }
		/// <summary>
		/// --no-headers
		///
		/// If present, print output without headers
		/// </summary>
		public bool? NoHeaders { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2)
		/// </summary>
		public string Selector { get; set; }
	}
}
