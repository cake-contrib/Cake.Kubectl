using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Deny a certificate signing request.
	///
	/// 
	///  kubectl certificate deny allows a cluster admin to deny a certificate signing request (CSR). This action tells a certificate signing controller to not to issue a certificate to the requestor.
	/// </summary>
	/// <example>
	///   # Deny CSR 'csr-sqgzp'
	///   kubectl certificate deny csr-sqgzp
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCertificateDenySettings : AutoToolSettings
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
		/// Filename, directory, or URL to files identifying the resource to update
		/// </summary>
		public string? Filename { get; set; }
		/// <summary>
		/// --force
		///
		/// Update the CSR even if it is already denied.
		/// </summary>
		public bool? Force { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string? Kustomize { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
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
