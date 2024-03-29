using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Forward one or more local ports to a pod.
	///
	/// 
	///  Use resource type/name such as deployment/mydeployment to select a pod. Resource type defaults to 'pod' if omitted.
	/// 
	///  If there are multiple pods matching the criteria, a pod will be selected automatically. The forwarding session ends when the selected pod terminates, and a rerun of the command is needed to resume forwarding.
	/// </summary>
	/// <example>
	///   # Listen on ports 5000 and 6000 locally, forwarding data to/from ports 5000 and 6000 in the pod
	///   kubectl port-forward pod/mypod 5000 6000
	/// 
	///   # Listen on ports 5000 and 6000 locally, forwarding data to/from ports 5000 and 6000 in a pod selected by the deployment
	///   kubectl port-forward deployment/mydeployment 5000 6000
	/// 
	///   # Listen on port 8443 locally, forwarding to the targetPort of the service's port named "https" in a pod selected by the service
	///   kubectl port-forward service/myservice 8443:https
	/// 
	///   # Listen on port 8888 locally, forwarding to 5000 in the pod
	///   kubectl port-forward pod/mypod 8888:5000
	/// 
	///   # Listen on port 8888 on all addresses, forwarding to 5000 in the pod
	///   kubectl port-forward --address 0.0.0.0 pod/mypod 8888:5000
	/// 
	///   # Listen on port 8888 on localhost and selected IP, forwarding to 5000 in the pod
	///   kubectl port-forward --address localhost,10.19.21.23 pod/mypod 8888:5000
	/// 
	///   # Listen on a random port locally, forwarding to 5000 in the pod
	///   kubectl port-forward pod/mypod :5000
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlPortForwardSettings : AutoToolSettings
	{
		/// <summary>
		/// --address
		///
		/// Addresses to listen on (comma separated). Only accepts IP addresses or localhost as a value. When localhost is supplied, kubectl will try to bind on both 127.0.0.1 and ::1 and will fail if neither of these addresses are available to bind.
		/// </summary>
		public string? Address { get; set; }
		/// <summary>
		/// --pod-running-timeout
		///
		/// The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running
		/// </summary>
		public string? PodRunningTimeout { get; set; }
	}
}
