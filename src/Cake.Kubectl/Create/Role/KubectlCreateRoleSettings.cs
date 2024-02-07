using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Create a role with single rule.
	///
	/// </summary>
	/// <example>
	///   # Create a role named "pod-reader" that allows user to perform "get", "watch" and "list" on pods
	///   kubectl create role pod-reader --verb=get --verb=list --verb=watch --resource=pods
	/// 
	///   # Create a role named "pod-reader" with ResourceName specified
	///   kubectl create role pod-reader --verb=get --resource=pods --resource-name=readablepod --resource-name=anotherpod
	/// 
	///   # Create a role named "foo" with API Group specified
	///   kubectl create role foo --verb=get,list,watch --resource=rs.apps
	/// 
	///   # Create a role named "foo" with SubResource specified
	///   kubectl create role foo --verb=get,list,watch --resource=pods,pods/status
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCreateRoleSettings : AutoToolSettings
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
		/// --resource
		///
		/// Resource that the rule applies to
		/// </summary>
		public string? Resource { get; set; }
		/// <summary>
		/// --resource-name
		///
		/// Resource in the white list that the rule applies to, repeat this flag for multiple items
		/// </summary>
		public string? ResourceName { get; set; }
		/// <summary>
		/// --save-config
		///
		/// If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.
		/// </summary>
		public bool? SaveConfig { get; set; }
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
		/// <summary>
		/// --verb
		///
		/// Verb that applies to the resources contained in the rule
		/// </summary>
		public string? Verb { get; set; }
	}
}
