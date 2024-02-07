using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Set a new size for a deployment, replica set, replication controller, or stateful set.
	///
	/// 
	///  Scale also allows users to specify one or more preconditions for the scale action.
	/// 
	///  If --current-replicas or --resource-version is specified, it is validated before the scale is attempted, and it is guaranteed that the precondition holds true when the scale is sent to the server.
	/// </summary>
	/// <example>
	///   # Scale a replica set named 'foo' to 3
	///   kubectl scale --replicas=3 rs/foo
	/// 
	///   # Scale a resource identified by type and name specified in "foo.yaml" to 3
	///   kubectl scale --replicas=3 -f foo.yaml
	/// 
	///   # If the deployment named mysql's current size is 2, scale mysql to 3
	///   kubectl scale --current-replicas=2 --replicas=3 deployment/mysql
	/// 
	///   # Scale multiple replication controllers
	///   kubectl scale --replicas=5 rc/foo rc/bar rc/baz
	/// 
	///   # Scale stateful set named 'web' to 3
	///   kubectl scale --replicas=3 statefulset/web
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlScaleSettings : AutoToolSettings
	{
		/// <summary>
		/// --all
		///
		/// Select all resources in the namespace of the specified resource types
		/// </summary>
		public bool? All { get; set; }
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --current-replicas
		///
		/// Precondition for current size. Requires that the current size of the resource match this value in order to scale. -1 (default) for no condition.
		/// </summary>
		public int? CurrentReplicas { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// Must be "none", "server", or "client". If client strategy, only print the object that would be sent, without sending it. If server strategy, submit server-side request without persisting the resource.
		/// </summary>
		public string? DryRun { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files identifying the resource to set a new size
		/// </summary>
		public string? Filename { get; set; }
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
		/// --replicas
		///
		/// The new desired number of replicas. Required.
		/// </summary>
		public string? Replicas { get; set; }
		/// <summary>
		/// --resource-version
		///
		/// Precondition for resource version. Requires that the current resource version match this value in order to scale.
		/// </summary>
		public string? ResourceVersion { get; set; }
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
		/// --timeout
		///
		/// The length of time to wait before giving up on a scale operation, zero means don't wait. Any other values should contain a corresponding time unit (e.g. 1s, 2m, 3h).
		/// </summary>
		public string? Timeout { get; set; }
	}
}
