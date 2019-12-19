using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Convert config files between different API versions. Both YAML and JSON formats are accepted.
	///
	/// 
	///  The command takes filename, directory, or URL as input, and convert it into format of version specified by --output-version flag. If target version is not specified or not supported, convert to latest version.
	/// 
	///  The default output will be printed to stdout in YAML format. One can use -o option to change to output destination.
	/// </summary>
	/// <example>
	///   # Convert 'pod.yaml' to latest version and print to stdout.
	///   kubectl convert -f pod.yaml
	/// 
	///   # Convert the live state of the resource specified by 'pod.yaml' to the latest version
	///   # and print to stdout in JSON format.
	///   kubectl convert -f pod.yaml --local -o json
	/// 
	///   # Convert all files under current directory to latest version and create them all.
	///   kubectl convert -f . | kubectl create -f -
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesConvertSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files to need to get converted.
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// --local
		///
		/// If true, convert will NOT try to contact api-server but run locally.
		/// </summary>
		public bool? Local { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --output-version
		///
		/// Output the formatted object with the given group version (for ex: 'extensions/v1beta1').
		/// </summary>
		public string OutputVersion { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
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
	}
}
