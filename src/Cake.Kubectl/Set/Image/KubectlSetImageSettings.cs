using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Update existing container image(s) of resources.
	///
	/// 
	///  Possible resources include (case insensitive):
	/// 
	///   pod (po), replicationcontroller (rc), deployment (deploy), daemonset (ds), statefulset (sts), cronjob (cj), replicaset (rs)
	/// </summary>
	/// <example>
	///   # Set a deployment's nginx container image to 'nginx:1.9.1', and its busybox container image to 'busybox'
	///   kubectl set image deployment/nginx busybox=busybox nginx=nginx:1.9.1
	/// 
	///   # Update all deployments' and rc's nginx container's image to 'nginx:1.9.1'
	///   kubectl set image deployments,rc nginx=nginx:1.9.1 --all
	/// 
	///   # Update image of all containers of daemonset abc to 'nginx:1.9.1'
	///   kubectl set image daemonset abc *=nginx:1.9.1
	/// 
	///   # Print result (in yaml format) of updating nginx container image from local file, without hitting the server
	///   kubectl set image -f path/to/file.yaml nginx=nginx:1.9.1 --local -o yaml
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlSetImageSettings : AutoToolSettings
	{
		/// <summary>
		/// --all
		///
		/// Select all resources, in the namespace of the specified resource types
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
		/// -f, --filename
		///
		/// Filename, directory, or URL to files identifying the resource to get from a server.
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
		/// If true, set image will NOT contact api-server but run locally.
		/// </summary>
		public bool? Local { get; set; }
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
	}
}
