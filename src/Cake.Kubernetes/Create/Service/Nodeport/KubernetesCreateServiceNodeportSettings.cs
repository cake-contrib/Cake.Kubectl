using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Create a NodePort service with the specified name.
	///
	/// </summary>
	/// <example>
	///   # Create a new NodePort service named my-ns
	///   kubectl create service nodeport my-ns --tcp=5678:8080
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesCreateServiceNodeportSettings : AutoToolSettings
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
		/// --generator
		///
		/// The name of the API generator to use.
		/// </summary>
		public string Generator { get; set; }
		/// <summary>
		/// --node-port
		///
		/// Port used to expose the service on each node in a cluster.
		/// </summary>
		public string NodePort { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --save-config
		///
		/// If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.
		/// </summary>
		public bool? SaveConfig { get; set; }
		/// <summary>
		/// --tcp
		///
		/// Port pairs can be specified as '<port>:<targetPort>'.
		/// </summary>
		public string Tcp { get; set; }
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
