using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Roll back to a previous rollout.
	///
	/// </summary>
	/// <example>
	///   # Roll back to the previous deployment
	///   kubectl rollout undo deployment/abc
	/// 
	///   # Roll back to daemonset revision 3
	///   kubectl rollout undo daemonset/abc --to-revision=3
	/// 
	///   # Roll back to the previous deployment with dry-run
	///   kubectl rollout undo --dry-run=server deployment/abc
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlRolloutUndoSettings : AutoToolSettings
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
		/// <summary>
		/// --to-revision
		///
		/// The revision to rollback to. Default to 0 (last revision).
		/// </summary>
		public string? ToRevision { get; set; }
	}
}
