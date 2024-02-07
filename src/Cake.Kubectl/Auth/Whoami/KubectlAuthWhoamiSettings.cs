using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Experimental: Check who you are and your attributes (groups, extra).
	///
	/// 
	///   This command is helpful to get yourself aware of the current user attributes,
	///   especially when dynamic authentication, e.g., token webhook, auth proxy, or OIDC provider,
	///   is enabled in the Kubernetes cluster.
	/// </summary>
	/// <example>
	///   # Get your subject attributes.
	///   kubectl auth whoami
	/// 
	///   # Get your subject attributes in JSON format.
	///   kubectl auth whoami -o json
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlAuthWhoamiSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
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
