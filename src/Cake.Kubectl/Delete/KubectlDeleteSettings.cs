using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Delete resources by filenames, stdin, resources and names, or by resources and label selector.
	///
	/// 
	///  JSON and YAML formats are accepted. Only one type of the arguments may be specified: filenames, resources and names, or resources and label selector.
	/// 
	///  Some resources, such as pods, support graceful deletion. These resources define a default period before they are forcibly terminated (the grace period) but you may override that value with the --grace-period flag, or pass --now to set a grace-period of 1. Because these resources often represent entities in the cluster, deletion may not be acknowledged immediately. If the node hosting a pod is down or cannot reach the API server, termination may take significantly longer than the grace period. To force delete a resource, you must pass a grace period of 0 and specify the --force flag.
	/// 
	///  IMPORTANT: Force deleting pods does not wait for confirmation that the pod's processes have been terminated, which can leave those processes running until the node detects the deletion and completes graceful deletion. If your processes use shared storage or talk to a remote API and depend on the name of the pod to identify themselves, force deleting those pods may result in multiple processes running on different machines using the same identification which may lead to data corruption or inconsistency. Only force delete pods when you are sure the pod is terminated, or if your application can tolerate multiple copies of the same pod running at once. Also, if you force delete pods the scheduler may place new pods on those nodes before the node has released those resources and causing those pods to be evicted immediately.
	/// 
	///  Note that the delete command does NOT do resource version checks, so if someone submits an update to a resource right when you submit a delete, their update will be lost along with the rest of the resource.
	/// </summary>
	/// <example>
	///   # Delete a pod using the type and name specified in pod.json.
	///   kubectl delete -f ./pod.json
	/// 
	///   # Delete resources from a directory containing kustomization.yaml - e.g. dir/kustomization.yaml.
	///   kubectl delete -k dir
	/// 
	///   # Delete a pod based on the type and name in the JSON passed into stdin.
	///   cat pod.json | kubectl delete -f -
	/// 
	///   # Delete pods and services with same names "baz" and "foo"
	///   kubectl delete pod,service baz foo
	/// 
	///   # Delete pods and services with label name=myLabel.
	///   kubectl delete pods,services -l name=myLabel
	/// 
	///   # Delete a pod with minimal delay
	///   kubectl delete pod foo --now
	/// 
	///   # Force delete a pod on a dead node
	///   kubectl delete pod foo --grace-period=0 --force
	/// 
	///   # Delete all pods
	///   kubectl delete pods --all
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlDeleteSettings : AutoToolSettings
	{
		/// <summary>
		/// --all
		///
		/// Delete all resources, including uninitialized ones, in the namespace of the specified resource types.
		/// </summary>
		public bool? All { get; set; }
		/// <summary>
		/// -A, --all-namespaces
		///
		/// If present, list the requested object(s) across all namespaces. Namespace in current context is ignored even if specified with --namespace.
		/// </summary>
		public bool? AllNamespaces { get; set; }
		/// <summary>
		/// --cascade
		///
		/// If true, cascade the deletion of the resources managed by this resource (e.g. Pods created by a ReplicationController).  Default true.
		/// </summary>
		public bool? Cascade { get; set; }
		/// <summary>
		/// --field-selector
		///
		/// Selector (field query) to filter on, supports '=', '==', and '!='.(e.g. --field-selector key1=value1,key2=value2). The server only supports a limited number of field queries per type.
		/// </summary>
		public string FieldSelector { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// containing the resource to delete.
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// --force
		///
		/// Only used when grace-period=0. If true, immediately remove resources from API and bypass graceful deletion. Note that immediate deletion of some resources may result in inconsistency or data loss and requires confirmation.
		/// </summary>
		public bool? Force { get; set; }
		/// <summary>
		/// --grace-period
		///
		/// Period of time in seconds given to the resource to terminate gracefully. Ignored if negative. Set to 1 for immediate shutdown. Can only be set to 0 when --force is true (force deletion).
		/// </summary>
		public int? GracePeriod { get; set; }
		/// <summary>
		/// --ignore-not-found
		///
		/// Treat "resource not found" as a successful delete. Defaults to "true" when --all is specified.
		/// </summary>
		public bool? IgnoreNotFound { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process a kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// --now
		///
		/// If true, resources are signaled for immediate shutdown (same as --grace-period=1).
		/// </summary>
		public bool? Now { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output mode. Use "-o name" for shorter output (resource/name).
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, not including uninitialized ones.
		/// </summary>
		public string Selector { get; set; }
		/// <summary>
		/// --timeout
		///
		/// The length of time to wait before giving up on a delete, zero means determine a timeout from the size of the object
		/// </summary>
		public string Timeout { get; set; }
		/// <summary>
		/// --wait
		///
		/// If true, wait for resources to be gone before returning. This waits for finalizers.
		/// </summary>
		public bool? Wait { get; set; }
	}
}
