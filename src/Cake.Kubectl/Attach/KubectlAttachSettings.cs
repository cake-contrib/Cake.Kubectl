using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Attach to a process that is already running inside an existing container.
	///
	/// </summary>
	/// <example>
	///   # Get output from running pod 123456-7890, using the first container by default
	///   kubectl attach 123456-7890
	/// 
	///   # Get output from ruby-container from pod 123456-7890
	///   kubectl attach 123456-7890 -c ruby-container
	/// 
	///   # Switch to raw terminal mode, sends stdin to 'bash' in ruby-container from pod 123456-7890
	///   # and sends stdout/stderr from 'bash' back to the client
	///   kubectl attach 123456-7890 -c ruby-container -i -t
	/// 
	///   # Get output from the first pod of a ReplicaSet named nginx
	///   kubectl attach rs/nginx
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlAttachSettings : AutoToolSettings
	{
		/// <summary>
		/// -c, --container
		///
		/// Container name. If omitted, the first container in the pod will be chosen
		/// </summary>
		public string Container { get; set; }
		/// <summary>
		/// --pod-running-timeout
		///
		/// The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running
		/// </summary>
		public string PodRunningTimeout { get; set; }
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
