using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Replace a resource by file name or stdin.
	///
	/// 
	///  JSON and YAML formats are accepted. If replacing an existing resource, the complete resource spec must be provided. This can be obtained by
	/// 
	///   $ kubectl get TYPE NAME -o yaml
	/// </summary>
	/// <example>
	///   # Replace a pod using the data in pod.json
	///   kubectl replace -f ./pod.json
	/// 
	///   # Replace a pod based on the JSON passed into stdin
	///   cat pod.json | kubectl replace -f -
	/// 
	///   # Update a single-container pod's image version (tag) to v4
	///   kubectl get pod mypod -o yaml | sed 's/\(image: myimage\):.*$/\1:v4/' | kubectl replace -f -
	/// 
	///   # Force replace, delete and then re-create the resource
	///   kubectl replace --force -f ./pod.json
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlReplaceSettings : AutoToolSettings
	{
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
		/// The files that contain the configurations to replace.
		/// </summary>
		public string? Filename { get; set; }
		/// <summary>
		/// --force
		///
		/// If true, immediately remove resources from API and bypass graceful deletion. Note that immediate deletion of some resources may result in inconsistency or data loss and requires confirmation.
		/// </summary>
		public bool? Force { get; set; }
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
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// --raw
		///
		/// Raw URI to PUT to the server.  Uses the transport specified by the kubeconfig file.
		/// </summary>
		public string? Raw { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
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
		/// --subresource
		///
		/// If specified, replace will operate on the subresource of the requested object. Must be one of [status scale]. This flag is beta and may change in the future.
		/// </summary>
		public string? Subresource { get; set; }
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
