using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Display Resource (CPU/Memory/Storage) usage of pods.
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
	public sealed class KubernetesTopPodSettings : AutoToolSettings
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
		/// If present, print output without headers.
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
