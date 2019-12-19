using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Experimental: Wait for a specific condition on one or many resources.
	///
	/// 
	///  The command takes multiple resources and waits until the specified condition is seen in the Status field of every given resource.
	/// 
	///  Alternatively, the command can wait for the given set of resources to be deleted by providing the "delete" keyword as the value to the --for flag.
	/// 
	///  A successful message will be printed to stdout indicating when the specified condition has been met. One can use -o option to change to output destination.
	/// </summary>
	/// <example>
	///   # Wait for the pod "busybox1" to contain the status condition of type "Ready".
	///   kubectl wait --for=condition=Ready pod/busybox1
	/// 
	///   # Wait for the pod "busybox1" to be deleted, with a timeout of 60s, after having issued the "delete" command.
	///   kubectl delete pod/busybox1
	///   kubectl wait --for=delete pod/busybox1 --timeout=60s
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesWaitSettings : AutoToolSettings
	{
		/// <summary>
		/// --all
		///
		/// Select all resources in the namespace of the specified resource types
		/// </summary>
		public bool? All { get; set; }
		/// <summary>
		/// -A, --all-namespaces
		///
		/// If present, list the requested object(s) across all namespaces. Namespace in current context is ignored even if specified with --namespace.
		/// </summary>
		public bool? AllNamespaces { get; set; }
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --field-selector
		///
		/// Selector (field query) to filter on, supports '=', '==', and '!='.(e.g. --field-selector key1=value1,key2=value2). The server only supports a limited number of field queries per type.
		/// </summary>
		public string FieldSelector { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// identifying the resource.
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// --for
		///
		/// The condition to wait on: [delete|condition=condition-name].
		/// </summary>
		public string For { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2)
		/// </summary>
		public string Selector { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
		/// <summary>
		/// --timeout
		///
		/// The length of time to wait before giving up.  Zero means check once and don't wait, negative means wait for a week.
		/// </summary>
		public string Timeout { get; set; }
	}
}
