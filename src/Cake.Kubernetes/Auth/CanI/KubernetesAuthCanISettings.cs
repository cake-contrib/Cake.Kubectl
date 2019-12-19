using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Check whether an action is allowed.
	///
	/// 
	///  VERB is a logical Kubernetes API verb like 'get', 'list', 'watch', 'delete', etc. TYPE is a Kubernetes resource. Shortcuts and groups will be resolved. NONRESOURCEURL is a partial URL starts with "/". NAME is the name of a particular Kubernetes resource.
	/// </summary>
	/// <example>
	///   # Check to see if I can create pods in any namespace
	///   kubectl auth can-i create pods --all-namespaces
	/// 
	///   # Check to see if I can list deployments in my current namespace
	///   kubectl auth can-i list deployments.extensions
	/// 
	///   # Check to see if I can do everything in my current namespace ("*" means all)
	///   kubectl auth can-i '*' '*'
	/// 
	///   # Check to see if I can get the job named "bar" in namespace "foo"
	///   kubectl auth can-i list jobs.batch/bar -n foo
	/// 
	///   # Check to see if I can read pod logs
	///   kubectl auth can-i get pods --subresource=log
	/// 
	///   # Check to see if I can access the URL /logs/
	///   kubectl auth can-i get /logs/
	/// 
	///   # List all allowed actions in namespace "foo"
	///   kubectl auth can-i --list --namespace=foo
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesAuthCanISettings : AutoToolSettings
	{
		/// <summary>
		/// -A, --all-namespaces
		///
		/// If true, check the specified action in all namespaces.
		/// </summary>
		public bool? AllNamespaces { get; set; }
		/// <summary>
		/// --list
		///
		/// If true, prints all allowed actions.
		/// </summary>
		public bool? List { get; set; }
		/// <summary>
		/// --no-headers
		///
		/// If true, prints allowed actions without headers
		/// </summary>
		public bool? NoHeaders { get; set; }
		/// <summary>
		/// -q, --quiet
		///
		/// If true, suppress output and just return the exit code.
		/// </summary>
		public bool? Quiet { get; set; }
		/// <summary>
		/// --subresource
		///
		/// SubResource such as pod/log or deployment/scale
		/// </summary>
		public string Subresource { get; set; }
	}
}
