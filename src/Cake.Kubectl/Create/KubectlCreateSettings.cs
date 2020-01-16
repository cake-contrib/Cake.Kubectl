using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Create a resource from a file or from stdin.
	///
	/// 
	///  JSON and YAML formats are accepted.
	/// </summary>
	/// <example>
	///   # Create a pod using the data in pod.json.
	///   kubectl create -f ./pod.json
	/// 
	///   # Create a pod based on the JSON passed into stdin.
	///   cat pod.json | kubectl create -f -
	/// 
	///   # Edit the data in docker-registry.yaml in JSON then create the resource using the edited data.
	///   kubectl create -f docker-registry.yaml --edit -o json
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCreateSettings : AutoToolSettings
	{
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
		/// --edit
		///
		/// Edit the API resource before creating
		/// </summary>
		public bool? Edit { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files to use to create the resource
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --raw
		///
		/// Raw URI to POST to the server.  Uses the transport specified by the kubeconfig file.
		/// </summary>
		public string Raw { get; set; }
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
		/// --save-config
		///
		/// If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.
		/// </summary>
		public bool? SaveConfig { get; set; }
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
		/// --validate
		///
		/// If true, use a schema to validate the input before sending it
		/// </summary>
		public bool? Validate { get; set; }
		/// <summary>
		/// --windows-line-endings
		///
		/// Only relevant if --edit=true. Defaults to the line ending native to your platform.
		/// </summary>
		public bool? WindowsLineEndings { get; set; }
	}
}
