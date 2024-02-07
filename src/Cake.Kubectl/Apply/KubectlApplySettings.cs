using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Apply a configuration to a resource by file name or stdin. The resource name must be specified. This resource will be created if it doesn't exist yet. To use 'apply', always create the resource initially with either 'apply' or 'create --save-config'.
	///
	/// 
	///  JSON and YAML formats are accepted.
	/// 
	///  Alpha Disclaimer: the --prune functionality is not yet complete. Do not use unless you are aware of what the current state is. See https://issues.k8s.io/34274.
	/// </summary>
	/// <example>
	///   # Apply the configuration in pod.json to a pod
	///   kubectl apply -f ./pod.json
	/// 
	///   # Apply resources from a directory containing kustomization.yaml - e.g. dir/kustomization.yaml
	///   kubectl apply -k dir/
	/// 
	///   # Apply the JSON passed into stdin to a pod
	///   cat pod.json | kubectl apply -f -
	/// 
	///   # Apply the configuration from all files that end with '.json' - i.e. expand wildcard characters in file names
	///   kubectl apply -f '*.json'
	/// 
	///   # Note: --prune is still in Alpha
	///   # Apply the configuration in manifest.yaml that matches label app=nginx and delete all other resources that are not in the file and match label app=nginx
	///   kubectl apply --prune -f manifest.yaml -l app=nginx
	/// 
	///   # Apply the configuration in manifest.yaml and delete all the other config maps that are not in the file
	///   kubectl apply --prune -f manifest.yaml --all --prune-allowlist=core/v1/ConfigMap
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlApplySettings : AutoToolSettings
	{
		/// <summary>
		/// --all
		///
		/// Select all resources in the namespace of the specified resource types.
		/// </summary>
		public bool? All { get; set; }
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --cascade
		///
		/// Must be "background", "orphan", or "foreground". Selects the deletion cascading strategy for the dependents (e.g. Pods created by a ReplicationController). Defaults to background.
		/// </summary>
		public string? Cascade { get; set; }
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
		/// -f, --filename
		///
		/// The files that contain the configurations to apply.
		/// </summary>
		public string? Filename { get; set; }
		/// <summary>
		/// --force
		///
		/// If true, immediately remove resources from API and bypass graceful deletion. Note that immediate deletion of some resources may result in inconsistency or data loss and requires confirmation.
		/// </summary>
		public bool? Force { get; set; }
		/// <summary>
		/// --force-conflicts
		///
		/// If true, server-side apply will force the changes against conflicts.
		/// </summary>
		public bool? ForceConflicts { get; set; }
		/// <summary>
		/// --grace-period
		///
		/// Period of time in seconds given to the resource to terminate gracefully. Ignored if negative. Set to 1 for immediate shutdown. Can only be set to 0 when --force is true (force deletion).
		/// </summary>
		public int? GracePeriod { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process a kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string? Kustomize { get; set; }
		/// <summary>
		/// --openapi-patch
		///
		/// If true, use openapi to calculate diff when the openapi presents and the resource can be found in the openapi spec. Otherwise, fall back to use baked-in types.
		/// </summary>
		public bool? OpenapiPatch { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// --overwrite
		///
		/// Automatically resolve conflicts between the modified and live configuration by using values from the modified configuration
		/// </summary>
		public bool? Overwrite { get; set; }
		/// <summary>
		/// --prune
		///
		/// Automatically delete resource objects, that do not appear in the configs and are created by either apply or create --save-config. Should be used with either -l or --all.
		/// </summary>
		public bool? Prune { get; set; }
		/// <summary>
		/// --prune-allowlist
		///
		/// Overwrite the default allowlist with &lt;group/version/kind&gt; for --prune
		/// </summary>
		public string? PruneAllowlist { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2). Matching objects must satisfy all of the specified label constraints.
		/// </summary>
		public string? Selector { get; set; }
		/// <summary>
		/// --server-side
		///
		/// If true, apply runs in the server instead of the client.
		/// </summary>
		public bool? ServerSide { get; set; }
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
		/// --timeout
		///
		/// The length of time to wait before giving up on a delete, zero means determine a timeout from the size of the object
		/// </summary>
		public string? Timeout { get; set; }
		/// <summary>
		/// --validate
		///
		/// Must be one of: strict (or true), warn, ignore (or false). 		"true" or "strict" will use a schema to validate the input and fail the request if invalid. It will perform server side validation if ServerSideFieldValidation is enabled on the api-server, but will fall back to less reliable client-side validation if not. 		"warn" will warn about unknown or duplicate fields without blocking the request if server-side field validation is enabled on the API server, and behave as "ignore" otherwise. 		"false" or "ignore" will not perform any schema validation, silently dropping any unknown or duplicate fields.
		/// </summary>
		public string? Validate { get; set; }
		/// <summary>
		/// --wait
		///
		/// If true, wait for resources to be gone before returning. This waits for finalizers.
		/// </summary>
		public bool? Wait { get; set; }
	}
}
