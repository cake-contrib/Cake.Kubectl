using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Print the logs for a container in a pod or specified resource. If the pod has only one container, the container name is optional.
	///
	/// </summary>
	/// <example>
	///   # Return snapshot logs from pod nginx with only one container
	///   kubectl logs nginx
	/// 
	///   # Return snapshot logs from pod nginx with multi containers
	///   kubectl logs nginx --all-containers=true
	/// 
	///   # Return snapshot logs from all containers in pods defined by label app=nginx
	///   kubectl logs -l app=nginx --all-containers=true
	/// 
	///   # Return snapshot of previous terminated ruby container logs from pod web-1
	///   kubectl logs -p -c ruby web-1
	/// 
	///   # Begin streaming the logs of the ruby container in pod web-1
	///   kubectl logs -f -c ruby web-1
	/// 
	///   # Begin streaming the logs from all containers in pods defined by label app=nginx
	///   kubectl logs -f -l app=nginx --all-containers=true
	/// 
	///   # Display only the most recent 20 lines of output in pod nginx
	///   kubectl logs --tail=20 nginx
	/// 
	///   # Show all logs from pod nginx written in the last hour
	///   kubectl logs --since=1h nginx
	/// 
	///   # Show logs from a kubelet with an expired serving certificate
	///   kubectl logs --insecure-skip-tls-verify-backend nginx
	/// 
	///   # Return snapshot logs from first container of a job named hello
	///   kubectl logs job/hello
	/// 
	///   # Return snapshot logs from container nginx-1 of a deployment named nginx
	///   kubectl logs deployment/nginx -c nginx-1
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlLogsSettings : AutoToolSettings
	{
		/// <summary>
		/// --all-containers
		///
		/// Get all containers' logs in the pod(s).
		/// </summary>
		public bool? AllContainers { get; set; }
		/// <summary>
		/// -c, --container
		///
		/// Print the logs of this container
		/// </summary>
		public string? Container { get; set; }
		/// <summary>
		/// -f, --follow
		///
		/// Specify if the logs should be streamed.
		/// </summary>
		public bool? Follow { get; set; }
		/// <summary>
		/// --ignore-errors
		///
		/// If watching / following pod logs, allow for any errors that occur to be non-fatal
		/// </summary>
		public bool? IgnoreErrors { get; set; }
		/// <summary>
		/// --insecure-skip-tls-verify-backend
		///
		/// Skip verifying the identity of the kubelet that logs are requested from.  In theory, an attacker could provide invalid log content back. You might want to use this if your kubelet serving certificates have expired.
		/// </summary>
		public bool? InsecureSkipTlsVerifyBackend { get; set; }
		/// <summary>
		/// --limit-bytes
		///
		/// Maximum bytes of logs to return. Defaults to no limit.
		/// </summary>
		public string? LimitBytes { get; set; }
		/// <summary>
		/// --max-log-requests
		///
		/// Specify maximum number of concurrent logs to follow when using by a selector. Defaults to 5.
		/// </summary>
		public string? MaxLogRequests { get; set; }
		/// <summary>
		/// --pod-running-timeout
		///
		/// The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running
		/// </summary>
		public string? PodRunningTimeout { get; set; }
		/// <summary>
		/// --prefix
		///
		/// Prefix each log line with the log source (pod name and container name)
		/// </summary>
		public bool? Prefix { get; set; }
		/// <summary>
		/// -p, --previous
		///
		/// If true, print the logs for the previous instance of the container in a pod if it exists.
		/// </summary>
		public bool? Previous { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2). Matching objects must satisfy all of the specified label constraints.
		/// </summary>
		public string? Selector { get; set; }
		/// <summary>
		/// --since
		///
		/// Only return logs newer than a relative duration like 5s, 2m, or 3h. Defaults to all logs. Only one of since-time / since may be used.
		/// </summary>
		public string? Since { get; set; }
		/// <summary>
		/// --since-time
		///
		/// Only return logs after a specific date (RFC3339). Defaults to all logs. Only one of since-time / since may be used.
		/// </summary>
		public string? SinceTime { get; set; }
		/// <summary>
		/// --tail
		///
		/// Lines of recent log file to display. Defaults to -1 with no selector, showing all log lines otherwise 10, if a selector is provided.
		/// </summary>
		public int? Tail { get; set; }
		/// <summary>
		/// --timestamps
		///
		/// Include timestamps on each line in the log output
		/// </summary>
		public bool? Timestamps { get; set; }
	}
}
