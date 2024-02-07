using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Execute a command in a container.
	///
	/// </summary>
	/// <example>
	///   # Get output from running the 'date' command from pod mypod, using the first container by default
	///   kubectl exec mypod -- date
	/// 
	///   # Get output from running the 'date' command in ruby-container from pod mypod
	///   kubectl exec mypod -c ruby-container -- date
	/// 
	///   # Switch to raw terminal mode; sends stdin to 'bash' in ruby-container from pod mypod
	///   # and sends stdout/stderr from 'bash' back to the client
	///   kubectl exec mypod -c ruby-container -i -t -- bash -il
	/// 
	///   # List contents of /usr from the first container of pod mypod and sort by modification time
	///   # If the command you want to execute in the pod has any flags in common (e.g. -i),
	///   # you must use two dashes (--) to separate your command's flags/arguments
	///   # Also note, do not surround your command and its flags/arguments with quotes
	///   # unless that is how you would execute it normally (i.e., do ls -t /usr, not "ls -t /usr")
	///   kubectl exec mypod -i -t -- ls -t /usr
	/// 
	///   # Get output from running 'date' command from the first pod of the deployment mydeployment, using the first container by default
	///   kubectl exec deploy/mydeployment -- date
	/// 
	///   # Get output from running 'date' command from the first pod of the service myservice, using the first container by default
	///   kubectl exec svc/myservice -- date
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlExecSettings : AutoToolSettings
	{
		/// <summary>
		/// -c, --container
		///
		/// Container name. If omitted, use the kubectl.kubernetes.io/default-container annotation for selecting the container to be attached or the first container in the pod will be chosen
		/// </summary>
		public string? Container { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// to use to exec into the resource
		/// </summary>
		public string? Filename { get; set; }
		/// <summary>
		/// --pod-running-timeout
		///
		/// The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running
		/// </summary>
		public string? PodRunningTimeout { get; set; }
		/// <summary>
		/// -q, --quiet
		///
		/// Only print output from the remote session
		/// </summary>
		public bool? Quiet { get; set; }
		/// <summary>
		/// -i, --stdin
		///
		/// Pass stdin to the container
		/// </summary>
		public bool? Stdin { get; set; }
		/// <summary>
		/// -t, --tty
		///
		/// Stdin is a TTY
		/// </summary>
		public bool? Tty { get; set; }
	}
}
