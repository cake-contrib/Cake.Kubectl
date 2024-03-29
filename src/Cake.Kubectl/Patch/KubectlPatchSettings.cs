using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Update fields of a resource using strategic merge patch, a JSON merge patch, or a JSON patch.
	///
	/// 
	///  JSON and YAML formats are accepted.
	/// 
	///  Note: Strategic merge patch is not supported for custom resources.
	/// </summary>
	/// <example>
	///   # Partially update a node using a strategic merge patch, specifying the patch as JSON
	///   kubectl patch node k8s-node-1 -p '{"spec":{"unschedulable":true}}'
	/// 
	///   # Partially update a node using a strategic merge patch, specifying the patch as YAML
	///   kubectl patch node k8s-node-1 -p $'spec:\n unschedulable: true'
	/// 
	///   # Partially update a node identified by the type and name specified in "node.json" using strategic merge patch
	///   kubectl patch -f node.json -p '{"spec":{"unschedulable":true}}'
	/// 
	///   # Update a container's image; spec.containers[*].name is required because it's a merge key
	///   kubectl patch pod valid-pod -p '{"spec":{"containers":[{"name":"kubernetes-serve-hostname","image":"new image"}]}}'
	/// 
	///   # Update a container's image using a JSON patch with positional arrays
	///   kubectl patch pod valid-pod --type='json' -p='[{"op": "replace", "path": "/spec/containers/0/image", "value":"new image"}]'
	/// 
	///   # Update a deployment's replicas through the scale subresource using a merge patch.
	///   kubectl patch deployment nginx-deployment --subresource='scale' --type='merge' -p '{"spec":{"replicas":2}}'
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlPatchSettings : AutoToolSettings
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
		/// -f, --filename
		///
		/// Filename, directory, or URL to files identifying the resource to update
		/// </summary>
		public string? Filename { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string? Kustomize { get; set; }
		/// <summary>
		/// --local
		///
		/// If true, patch will operate on the content of the file, not the server-side resource.
		/// </summary>
		public bool? Local { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// -p, --patch
		///
		/// The patch to be applied to the resource JSON file.
		/// </summary>
		public string? Patch { get; set; }
		/// <summary>
		/// --patch-file
		///
		/// A file containing a patch to be applied to the resource.
		/// </summary>
		public string? PatchFile { get; set; }
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
		/// --subresource
		///
		/// If specified, patch will operate on the subresource of the requested object. Must be one of [status scale]. This flag is beta and may change in the future.
		/// </summary>
		public string? Subresource { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string? Template { get; set; }
		/// <summary>
		/// --type
		///
		/// The type of patch being provided; one of [json merge strategic]
		/// </summary>
		public string? Type { get; set; }
	}
}
