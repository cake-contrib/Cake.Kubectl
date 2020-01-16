using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Create a TLS secret from the given public/private key pair.
	///
	/// 
	///  The public/private key pair must exist before hand. The public key certificate must be .PEM encoded and match the given private key.
	/// </summary>
	/// <example>
	///   # Create a new TLS secret named tls-secret with the given key pair:
	///   kubectl create secret tls tls-secret --cert=path/to/tls.cert --key=path/to/tls.key
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCreateSecretTlsSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --append-hash
		///
		/// Append a hash of the secret to its name.
		/// </summary>
		public bool? AppendHash { get; set; }
		/// <summary>
		/// --cert
		///
		/// Path to PEM encoded public key certificate.
		/// </summary>
		public string Cert { get; set; }
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
		/// --key
		///
		/// Path to private key associated with given certificate.
		/// </summary>
		public string Key { get; set; }
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
	}
}
