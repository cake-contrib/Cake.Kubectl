using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Reconciles rules for RBAC Role, RoleBinding, ClusterRole, and ClusterRole binding objects.
	///
	/// 
	///  Missing objects are created, and the containing namespace is created for namespaced objects, if required.
	/// 
	///  Existing roles are updated to include the permissions in the input objects, and remove extra permissions if --remove-extra-permissions is specified.
	/// 
	///  Existing bindings are updated to include the subjects in the input objects, and remove extra subjects if --remove-extra-subjects is specified.
	/// 
	///  This is preferred to 'apply' for RBAC resources so that semantically-aware merging of rules and subjects is done.
	/// </summary>
	/// <example>
	///   # Reconcile rbac resources from a file
	///   kubectl auth reconcile -f my-rbac-rules.yaml
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesAuthReconcileSettings : AutoToolSettings
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
		/// If true, display results but do not submit changes
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files identifying the resource to reconcile.
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
		/// <summary>
		/// --remove-extra-permissions
		///
		/// If true, removes extra permissions added to roles
		/// </summary>
		public bool? RemoveExtraPermissions { get; set; }
		/// <summary>
		/// --remove-extra-subjects
		///
		/// If true, removes extra subjects added to rolebindings
		/// </summary>
		public bool? RemoveExtraSubjects { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
	}
}
