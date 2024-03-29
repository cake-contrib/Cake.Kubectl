using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Copy files and directories to and from containers.
	///
	/// </summary>
	/// <example>
	///   # !!!Important Note!!!
	///   # Requires that the 'tar' binary is present in your container
	///   # image.  If 'tar' is not present, 'kubectl cp' will fail.
	///   #
	///   # For advanced use cases, such as symlinks, wildcard expansion or
	///   # file mode preservation, consider using 'kubectl exec'.
	/// 
	///   # Copy /tmp/foo local file to /tmp/bar in a remote pod in namespace &lt;some-namespace&gt;
	///   tar cf - /tmp/foo | kubectl exec -i -n &lt;some-namespace&gt; &lt;some-pod&gt; -- tar xf - -C /tmp/bar
	/// 
	///   # Copy /tmp/foo from a remote pod to /tmp/bar locally
	///   kubectl exec -n &lt;some-namespace&gt; &lt;some-pod&gt; -- tar cf - /tmp/foo | tar xf - -C /tmp/bar
	/// 
	///   # Copy /tmp/foo_dir local directory to /tmp/bar_dir in a remote pod in the default namespace
	///   kubectl cp /tmp/foo_dir &lt;some-pod&gt;:/tmp/bar_dir
	/// 
	///   # Copy /tmp/foo local file to /tmp/bar in a remote pod in a specific container
	///   kubectl cp /tmp/foo &lt;some-pod&gt;:/tmp/bar -c &lt;specific-container&gt;
	/// 
	///   # Copy /tmp/foo local file to /tmp/bar in a remote pod in namespace &lt;some-namespace&gt;
	///   kubectl cp /tmp/foo &lt;some-namespace&gt;/&lt;some-pod&gt;:/tmp/bar
	/// 
	///   # Copy /tmp/foo from a remote pod to /tmp/bar locally
	///   kubectl cp &lt;some-namespace&gt;/&lt;some-pod&gt;:/tmp/foo /tmp/bar
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCpSettings : AutoToolSettings
	{
		/// <summary>
		/// -c, --container
		///
		/// Container name. If omitted, use the kubectl.kubernetes.io/default-container annotation for selecting the container to be attached or the first container in the pod will be chosen
		/// </summary>
		public string? Container { get; set; }
		/// <summary>
		/// --no-preserve
		///
		/// The copied file/directory's ownership and permissions will not be preserved in the container
		/// </summary>
		public bool? NoPreserve { get; set; }
		/// <summary>
		/// --retries
		///
		/// Set number of retries to complete a copy operation from a container. Specify 0 to disable or any negative value for infinite retrying. The default is 0 (no retry).
		/// </summary>
		public string? Retries { get; set; }
	}
}
