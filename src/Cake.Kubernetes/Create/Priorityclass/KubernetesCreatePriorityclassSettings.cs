using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Create a priorityclass with the specified name, value, globalDefault and description
	///
	/// </summary>
	/// <example>
	///   # Create a priorityclass named high-priority
	///   kubectl create priorityclass high-priority --value=1000 --description="high priority"
	/// 
	///   # Create a priorityclass named default-priority that considered as the global default priority
	///   kubectl create priorityclass default-priority --value=1000 --global-default=true --description="default priority"
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesCreatePriorityclassSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --description
		///
		/// description is an arbitrary string that usually provides guidelines on when this priority class should be used.
		/// </summary>
		public string Description { get; set; }
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
		/// --global-default
		///
		/// global-default specifies whether this PriorityClass should be considered as the default priority.
		/// </summary>
		public bool? GlobalDefault { get; set; }
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
		/// --value
		///
		/// the value of this priority class.
		/// </summary>
		public string Value { get; set; }
	}
}
