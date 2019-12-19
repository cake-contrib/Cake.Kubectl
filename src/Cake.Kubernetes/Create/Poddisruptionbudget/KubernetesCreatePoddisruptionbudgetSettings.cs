using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Create a pod disruption budget with the specified name, selector, and desired minimum available pods
	///
	/// </summary>
	/// <example>
	///   # Create a pod disruption budget named my-pdb that will select all pods with the app=rails label
	///   # and require at least one of them being available at any point in time.
	///   kubectl create poddisruptionbudget my-pdb --selector=app=rails --min-available=1
	/// 
	///   # Create a pod disruption budget named my-pdb that will select all pods with the app=nginx label
	///   # and require at least half of the pods selected to be available at any point in time.
	///   kubectl create pdb my-pdb --selector=app=nginx --min-available=50%
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesCreatePoddisruptionbudgetSettings : AutoToolSettings
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
		/// --max-unavailable
		///
		/// The maximum number or percentage of unavailable pods this budget requires.
		/// </summary>
		public string MaxUnavailable { get; set; }
		/// <summary>
		/// --min-available
		///
		/// The minimum number or percentage of available pods this budget requires.
		/// </summary>
		public string MinAvailable { get; set; }
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
		/// --selector
		///
		/// A label selector to use for this budget. Only equality-based selector requirements are supported.
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
	}
}
