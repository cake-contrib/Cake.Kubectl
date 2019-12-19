using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Dumps cluster info out suitable for debugging and diagnosing cluster problems.  By default, dumps everything to stdout. You can optionally specify a directory with --output-directory.  If you specify a directory, kubernetes will build a set of files in that directory.  By default only dumps things in the 'kube-system' namespace, but you can switch to a different namespace with the --namespaces flag, or specify --all-namespaces to dump all namespaces.
	///
	/// 
	///  The command also dumps the logs of all of the pods in the cluster, these logs are dumped into different directories based on namespace and pod name.
	/// </summary>
	/// <example>
	///   # Dump current cluster state to stdout
	///   kubectl cluster-info dump
	/// 
	///   # Dump current cluster state to /path/to/cluster-state
	///   kubectl cluster-info dump --output-directory=/path/to/cluster-state
	/// 
	///   # Dump all namespaces to stdout
	///   kubectl cluster-info dump --all-namespaces
	/// 
	///   # Dump a set of namespaces to /path/to/cluster-state
	///   kubectl cluster-info dump --namespaces default,kube-system --output-directory=/path/to/cluster-state
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesClusterInfoDumpSettings : AutoToolSettings
	{
		/// <summary>
		/// -A, --all-namespaces
		///
		/// If true, dump all namespaces.  If true, --namespaces is ignored.
		/// </summary>
		public bool? AllNamespaces { get; set; }
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --namespaces
		///
		/// A comma separated list of namespaces to dump.
		/// </summary>
		public string Namespaces { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --output-directory
		///
		/// Where to output the files.  If empty or '-' uses stdout, otherwise creates a directory hierarchy in that directory
		/// </summary>
		public string OutputDirectory { get; set; }
		/// <summary>
		/// --pod-running-timeout
		///
		/// The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running
		/// </summary>
		public string PodRunningTimeout { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
	}
}
