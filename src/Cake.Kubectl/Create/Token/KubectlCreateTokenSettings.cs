using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Request a service account token.
	///
	/// </summary>
	/// <example>
	///   # Request a token to authenticate to the kube-apiserver as the service account "myapp" in the current namespace
	///   kubectl create token myapp
	/// 
	///   # Request a token for a service account in a custom namespace
	///   kubectl create token myapp --namespace myns
	/// 
	///   # Request a token with a custom expiration
	///   kubectl create token myapp --duration 10m
	/// 
	///   # Request a token with a custom audience
	///   kubectl create token myapp --audience https://example.com
	/// 
	///   # Request a token bound to an instance of a Secret object
	///   kubectl create token myapp --bound-object-kind Secret --bound-object-name mysecret
	/// 
	///   # Request a token bound to an instance of a Secret object with a specific uid
	///   kubectl create token myapp --bound-object-kind Secret --bound-object-name mysecret --bound-object-uid 0d4691ed-659b-4935-a832-355f77ee47cc
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCreateTokenSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --audience
		///
		/// Audience of the requested token. If unset, defaults to requesting a token for use with the Kubernetes API server. May be repeated to request a token valid for multiple audiences.
		/// </summary>
		public string? Audience { get; set; }
		/// <summary>
		/// --bound-object-kind
		///
		/// Kind of an object to bind the token to. Supported kinds are Pod, Secret. If set, --bound-object-name must be provided.
		/// </summary>
		public string? BoundObjectKind { get; set; }
		/// <summary>
		/// --bound-object-name
		///
		/// Name of an object to bind the token to. The token will expire when the object is deleted. Requires --bound-object-kind.
		/// </summary>
		public string? BoundObjectName { get; set; }
		/// <summary>
		/// --bound-object-uid
		///
		/// UID of an object to bind the token to. Requires --bound-object-kind and --bound-object-name. If unset, the UID of the existing object is used.
		/// </summary>
		public string? BoundObjectUid { get; set; }
		/// <summary>
		/// --duration
		///
		/// Requested lifetime of the issued token. The server may return a token with a longer or shorter lifetime.
		/// </summary>
		public string? Duration { get; set; }
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
