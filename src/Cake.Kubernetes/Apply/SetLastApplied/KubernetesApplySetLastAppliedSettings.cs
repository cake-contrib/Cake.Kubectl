using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Set the latest last-applied-configuration annotations by setting it to match the contents of a file. This results in the last-applied-configuration being updated as though 'kubectl apply -f<file> ' was run, without updating any other parts of the object.
	///
	/// </summary>
	/// <example>
	///   # Set the last-applied-configuration of a resource to match the contents of a file.
	///   kubectl apply set-last-applied -f deploy.yaml
	/// 
	///   # Execute set-last-applied against each configuration file in a directory.
	///   kubectl apply set-last-applied -f path/
	/// 
	///   # Set the last-applied-configuration of a resource to match the contents of a file, will create the annotation if it does not already exist.
	///   kubectl apply set-last-applied -f deploy.yaml --create-annotation=true
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesApplySetLastAppliedSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --create-annotation
		///
		/// Will create 'last-applied-configuration' annotations if current objects doesn't have one
		/// </summary>
		public bool? CreateAnnotation { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files that contains the last-applied-configuration annotations
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
	}
}
