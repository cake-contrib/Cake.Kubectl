using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Display merged kubeconfig settings or a specified kubeconfig file.
	///
	/// 
	///  You can use --output jsonpath={...} to extract specific values using a jsonpath expression.
	/// </summary>
	/// <example>
	///   # Show merged kubeconfig settings
	///   kubectl config view
	/// 
	///   # Show merged kubeconfig settings and raw certificate data and exposed secrets
	///   kubectl config view --raw
	/// 
	///   # Get the password for the e2e user
	///   kubectl config view -o jsonpath='{.users[?(@.name == "e2e")].user.password}'
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlConfigViewSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --flatten
		///
		/// Flatten the resulting kubeconfig file into self-contained output (useful for creating portable kubeconfig files)
		/// </summary>
		public bool? Flatten { get; set; }
		/// <summary>
		/// --merge
		///
		/// Merge the full hierarchy of kubeconfig files
		/// </summary>
		public bool? Merge { get; set; }
		/// <summary>
		/// --minify
		///
		/// Remove all information not used by current-context from the output
		/// </summary>
		public bool? Minify { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// --raw
		///
		/// Display raw byte data and sensitive data
		/// </summary>
		public bool? Raw { get; set; }
		/// <summary>
		/// --show-managed-fields
		///
		/// If true, keep the managedFields when printing objects in JSON or YAML format.
		/// </summary>
		public bool? ShowManagedFields { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string? Template { get; set; }
	}
}
