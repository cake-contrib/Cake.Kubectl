using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Execute a command in a container.
	///
	/// </summary>
	/// <example>
	///   # Get output from running 'date' from pod 123456-7890, using the first container by default
	///   kubectl exec 123456-7890 date
	/// 
	///   # Get output from running 'date' in ruby-container from pod 123456-7890
	///   kubectl exec 123456-7890 -c ruby-container date
	/// 
	///   # Switch to raw terminal mode, sends stdin to 'bash' in ruby-container from pod 123456-7890
	///   # and sends stdout/stderr from 'bash' back to the client
	///   kubectl exec 123456-7890 -c ruby-container -i -t -- bash -il
	/// 
	///   # List contents of /usr from the first container of pod 123456-7890 and sort by modification time.
	///   # If the command you want to execute in the pod has any flags in common (e.g. -i),
	///   # you must use two dashes (--) to separate your command's flags/arguments.
	///   # Also note, do not surround your command and its flags/arguments with quotes
	///   # unless that is how you would execute it normally (i.e., do ls -t /usr, not "ls -t /usr").
	///   kubectl exec 123456-7890 -i -t -- ls -t /usr
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesExecSettings : AutoToolSettings
	{
		/// <summary>
		/// -c, --container
		///
		/// Container name. If omitted, the first container in the pod will be chosen
		/// </summary>
		public string Container { get; set; }
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
