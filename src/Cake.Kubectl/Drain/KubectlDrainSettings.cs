using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Drain node in preparation for maintenance.
	///
	/// 
	///  The given node will be marked unschedulable to prevent new pods from arriving. 'drain' evicts the pods if the APIServer supportshttp://kubernetes.io/docs/admin/disruptions/ . Otherwise, it will use normal DELETE to delete the pods. The 'drain' evicts or deletes all pods except mirror pods (which cannot be deleted through the API server).  If there are DaemonSet-managed pods, drain will not proceed without --ignore-daemonsets, and regardless it will not delete any DaemonSet-managed pods, because those pods would be immediately replaced by the DaemonSet controller, which ignores unschedulable markings.  If there are any pods that are neither mirror pods nor managed by ReplicationController, ReplicaSet, DaemonSet, StatefulSet or Job, then drain will not delete any pods unless you use --force.  --force will also allow deletion to proceed if the managing resource of one or more pods is missing.
	/// 
	///  'drain' waits for graceful termination. You should not operate on the machine until the command completes.
	/// 
	///  When you are ready to put the node back into service, use kubectl uncordon, which will make the node schedulable again.
	/// 
	///  http://kubernetes.io/images/docs/kubectl_drain.svg
	/// </summary>
	/// <example>
	///   # Drain node "foo", even if there are pods not managed by a ReplicationController, ReplicaSet, Job, DaemonSet or StatefulSet on it.
	///   $ kubectl drain foo --force
	/// 
	///   # As above, but abort if there are pods not managed by a ReplicationController, ReplicaSet, Job, DaemonSet or StatefulSet, and use a grace period of 15 minutes.
	///   $ kubectl drain foo --grace-period=900
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlDrainSettings : AutoToolSettings
	{
		/// <summary>
		/// --delete-local-data
		///
		/// Continue even if there are pods using emptyDir (local data that will be deleted when the node is drained).
		/// </summary>
		public bool? DeleteLocalData { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// --force
		///
		/// Continue even if there are pods not managed by a ReplicationController, ReplicaSet, Job, DaemonSet or StatefulSet.
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
		public string PodSelector { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on
		/// </summary>
		public string Selector { get; set; }
		/// <summary>
		/// --timeout
		///
		/// The length of time to wait before giving up, zero means infinite
		/// </summary>
		public string Timeout { get; set; }
	}
}
