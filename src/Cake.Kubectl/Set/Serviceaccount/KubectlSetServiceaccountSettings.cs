using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Update the service account of pod template resources.
	///
	/// 
	///  Possible resources (case insensitive) can be:
	/// 
	///  replicationcontroller (rc), deployment (deploy), daemonset (ds), job, replicaset (rs), statefulset
	/// </summary>
	/// <example>
	///   # Set deployment nginx-deployment's service account to serviceaccount1
	///   kubectl set serviceaccount deployment nginx-deployment serviceaccount1
	/// 
	///   # Print the result (in YAML format) of updated nginx deployment with the service account from local file, without hitting the API server
	///   kubectl set sa -f nginx-deployment.yaml serviceaccount1 --local --dry-run=client -o yaml
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlSetServiceaccountSettings : AutoToolSettings
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
		/// If true, set serviceaccount will NOT contact api-server but run locally.
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
