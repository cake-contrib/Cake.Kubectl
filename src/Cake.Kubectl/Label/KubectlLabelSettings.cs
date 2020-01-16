using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Update the labels on a resource.
	///
	/// 
	///   *  A label key and value must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  63 characters each.
	///   *  Optionally, the key can begin with a DNS subdomain prefix and a single '/', like example.com/my-app
	///   *  If --overwrite is true, then existing labels can be overwritten, otherwise attempting to overwrite a label will result in an error.
	///   *  If --resource-version is specified, then updates will use this resource version, otherwise the existing resource-version will be used.
	/// </summary>
	/// <example>
	///   # Update pod 'foo' with the label 'unhealthy' and the value 'true'.
	///   kubectl label pods foo unhealthy=true
	/// 
	///   # Update pod 'foo' with the label 'status' and the value 'unhealthy', overwriting any existing value.
	///   kubectl label --overwrite pods foo status=unhealthy
	/// 
	///   # Update all pods in the namespace
	///   kubectl label pods --all status=unhealthy
	/// 
	///   # Update a pod identified by the type and name in "pod.json"
	///   kubectl label -f pod.json status=unhealthy
	/// 
	///   # Update pod 'foo' only if the resource is unchanged from version 1.
	///   kubectl label pods foo status=unhealthy --resource-version=1
	/// 
	///   # Update pod 'foo' by removing a label named 'bar' if it exists.
	///   # Does not require the --overwrite flag.
	///   kubectl label pods foo bar-
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlLabelSettings : AutoToolSettings
	{
		/// <summary>
		/// --all
		///
		/// Select all resources, including uninitialized ones, in the namespace of the specified resource types
		/// </summary>
		public bool? All { get; set; }
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// --field-selector
		///
		/// Selector (field query) to filter on, supports '=', '==', and '!='.(e.g. --field-selector key1=value1,key2=value2). The server only supports a limited number of field queries per type.
		/// </summary>
		public string FieldSelector { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files identifying the resource to update the labels
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// --list
		///
		/// If true, display the labels for a given resource.
		/// </summary>
		public bool? List { get; set; }
		/// <summary>
		/// --local
		///
		/// If true, label will NOT contact api-server but run locally.
		/// </summary>
		public bool? Local { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --overwrite
		///
		/// If true, allow labels to be overwritten, otherwise reject label updates that overwrite existing labels.
		/// </summary>
		public bool? Overwrite { get; set; }
		/// <summary>
		/// --record
		///
		/// Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.
		/// </summary>
		public bool? Record { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
		/// <summary>
		/// --resource-version
		///
		/// If non-empty, the labels update will only succeed if this is the current resource-version for the object. Only valid when specifying a single resource.
		/// </summary>
		public string ResourceVersion { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, not including uninitialized ones, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2).
		/// </summary>
		public string Selector { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
	}
}
