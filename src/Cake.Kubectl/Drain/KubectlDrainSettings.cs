using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Drain node in preparation for maintenance.
	///
	/// 
	///  The given node will be marked unschedulable to prevent new pods from arriving. 'drain' evicts the pods if the API server supports https://kubernetes.io/docs/concepts/workloads/pods/disruptions/ eviction https://kubernetes.io/docs/concepts/workloads/pods/disruptions/ . Otherwise, it will use normal DELETE to delete the pods. The 'drain' evicts or deletes all pods except mirror pods (which cannot be deleted through the API server).  If there are daemon set-managed pods, drain will not proceed without --ignore-daemonsets, and regardless it will not delete any daemon set-managed pods, because those pods would be immediately replaced by the daemon set controller, which ignores unschedulable markings.  If there are any pods that are neither mirror pods nor managed by a replication controller, replica set, daemon set, stateful set, or job, then drain will not delete any pods unless you use --force.  --force will also allow deletion to proceed if the managing resource of one or more pods is missing.
	/// 
	///  'drain' waits for graceful termination. You should not operate on the machine until the command completes.
	/// 
	///  When you are ready to put the node back into service, use kubectl uncordon, which will make the node schedulable again.
	/// </summary>
	/// <example>
	///   # Drain node "foo", even if there are pods not managed by a replication controller, replica set, job, daemon set or stateful set on it
	///   kubectl drain foo --force
	/// 
	///   # As above, but abort if there are pods not managed by a replication controller, replica set, job, daemon set or stateful set, and use a grace period of 15 minutes
	///   kubectl drain foo --grace-period=900
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlDrainSettings : AutoToolSettings
	{
		/// <summary>
		/// --chunk-size
		///
		/// Return large lists in chunks rather than all at once. Pass 0 to disable. This flag is beta and may change in the future.
		/// </summary>
		public int? ChunkSize { get; set; }
		/// <summary>
		/// --delete-emptydir-data
		///
		/// Continue even if there are pods using emptyDir (local data that will be deleted when the node is drained).
		/// </summary>
		public bool? DeleteEmptydirData { get; set; }
		/// <summary>
		/// --disable-eviction
		///
		/// Force drain to use delete, even if eviction is supported. This will bypass checking PodDisruptionBudgets, use with caution.
		/// </summary>
		public bool? DisableEviction { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// Must be "none", "server", or "client". If client strategy, only print the object that would be sent, without sending it. If server strategy, submit server-side request without persisting the resource.
		/// </summary>
		public string? DryRun { get; set; }
		/// <summary>
		/// --force
		///
		/// Continue even if there are pods that do not declare a controller.
		/// </summary>
		public bool? Force { get; set; }
		/// <summary>
		/// --grace-period
		///
		/// Period of time in seconds given to each pod to terminate gracefully. If negative, the default value specified in the pod will be used.
		/// </summary>
		public int? GracePeriod { get; set; }
		/// <summary>
		/// --ignore-daemonsets
		///
		/// Ignore DaemonSet-managed pods.
		/// </summary>
		public bool? IgnoreDaemonsets { get; set; }
		/// <summary>
		/// --pod-selector
		///
		/// Label selector to filter pods on the node
		/// </summary>
		public string? PodSelector { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2). Matching objects must satisfy all of the specified label constraints.
		/// </summary>
		public string? Selector { get; set; }
		/// <summary>
		/// --skip-wait-for-delete-timeout
		///
		/// If pod DeletionTimestamp older than N seconds, skip waiting for the pod.  Seconds must be greater than 0 to skip.
		/// </summary>
		public string? SkipWaitForDeleteTimeout { get; set; }
		/// <summary>
		/// --timeout
		///
		/// The length of time to wait before giving up, zero means infinite
		/// </summary>
		public string? Timeout { get; set; }
	}
}
