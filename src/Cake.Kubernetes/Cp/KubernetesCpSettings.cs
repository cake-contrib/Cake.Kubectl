using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Copy files and directories to and from containers.
	///
	/// </summary>
	/// <example>
	///   # !!!Important Note!!!
	///   # Requires that the 'tar' binary is present in your container
	///   # image.  If 'tar' is not present, 'kubectl cp' will fail.
	/// 
	///   # Copy /tmp/foo_dir local directory to /tmp/bar_dir in a remote pod in the default namespace
	///   kubectl cp /tmp/foo_dir <some-pod>:/tmp/bar_dir
	/// 
	///   # Copy /tmp/foo local file to /tmp/bar in a remote pod in a specific container
	///   kubectl cp /tmp/foo <some-pod>:/tmp/bar -c <specific-container>
	/// 
	///   # Copy /tmp/foo local file to /tmp/bar in a remote pod in namespace <some-namespace>
	///   kubectl cp /tmp/foo <some-namespace>/<some-pod>:/tmp/bar
	/// 
	///   # Copy /tmp/foo from a remote pod to /tmp/bar locally
	///   kubectl cp <some-namespace>/<some-pod>:/tmp/foo /tmp/bar
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesCpSettings : AutoToolSettings
	{
		/// <summary>
		/// -c, --container
		///
		/// Container name. If omitted, the first container in the pod will be chosen
		/// </summary>
		public string Container { get; set; }
		/// <summary>
		/// --no-preserve
		///
		/// The copied file/directory's ownership and permissions will not be preserved in the container
		/// </summary>
		public bool? NoPreserve { get; set; }
	}
}
