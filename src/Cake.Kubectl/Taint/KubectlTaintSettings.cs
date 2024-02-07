using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Update the taints on one or more nodes.
	///
	/// 
	///   *  A taint consists of a key, value, and effect. As an argument here, it is expressed as key=value:effect.
	///   *  The key must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to 253 characters.
	///   *  Optionally, the key can begin with a DNS subdomain prefix and a single '/', like example.com/my-app.
	///   *  The value is optional. If given, it must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to 63 characters.
	///   *  The effect must be NoSchedule, PreferNoSchedule or NoExecute.
	///   *  Currently taint can only apply to node.
	/// </summary>
	/// <example>
	///   # Update node 'foo' with a taint with key 'dedicated' and value 'special-user' and effect 'NoSchedule'
	///   # If a taint with that key and effect already exists, its value is replaced as specified
	///   kubectl taint nodes foo dedicated=special-user:NoSchedule
	/// 
	///   # Remove from node 'foo' the taint with key 'dedicated' and effect 'NoSchedule' if one exists
	///   kubectl taint nodes foo dedicated:NoSchedule-
	/// 
	///   # Remove from node 'foo' all the taints with key 'dedicated'
	///   kubectl taint nodes foo dedicated-
	/// 
	///   # Add a taint with key 'dedicated' on nodes having label mylabel=X
	///   kubectl taint node -l myLabel=X  dedicated=foo:PreferNoSchedule
	/// 
	///   # Add to node 'foo' a taint with key 'bar' and no value
	///   kubectl taint nodes foo bar:NoSchedule
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlTaintSettings : AutoToolSettings
	{
		/// <summary>
		/// --all
		///
		/// Select all nodes in the cluster
		/// </summary>
		public bool? All { get; set; }
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// Must be "none", "server", or "client". If client strategy, only print the object that would be sent, without sending it. If server strategy, submit server-side request without persisting the resource.
		/// </summary>
		public string? DryRun { get; set; }
		/// <summary>
		/// --field-manager
		///
		/// Name of the manager used to track field ownership.
		/// </summary>
		public string? FieldManager { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// --overwrite
		///
		/// If true, allow taints to be overwritten, otherwise reject taint updates that overwrite existing taints.
		/// </summary>
		public bool? Overwrite { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2). Matching objects must satisfy all of the specified label constraints.
		/// </summary>
		public string? Selector { get; set; }
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
		/// <summary>
		/// --validate
		///
		/// Must be one of: strict (or true), warn, ignore (or false). 		"true" or "strict" will use a schema to validate the input and fail the request if invalid. It will perform server side validation if ServerSideFieldValidation is enabled on the api-server, but will fall back to less reliable client-side validation if not. 		"warn" will warn about unknown or duplicate fields without blocking the request if server-side field validation is enabled on the API server, and behave as "ignore" otherwise. 		"false" or "ignore" will not perform any schema validation, silently dropping any unknown or duplicate fields.
		/// </summary>
		public string? Validate { get; set; }
	}
}
