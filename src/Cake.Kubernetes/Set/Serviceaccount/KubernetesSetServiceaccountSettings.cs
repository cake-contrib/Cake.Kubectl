using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Update ServiceAccount of pod template resources.
	///
	/// 
	///  Possible resources (case insensitive) can be:
	/// 
	///  replicationcontroller (rc), deployment (deploy), daemonset (ds), job, replicaset (rs), statefulset
	/// </summary>
	/// <example>
	///   # Set Deployment nginx-deployment's ServiceAccount to serviceaccount1
	///   kubectl set serviceaccount deployment nginx-deployment serviceaccount1
	/// 
	///   # Print the result (in yaml format) of updated nginx deployment with serviceaccount from local file, without hitting apiserver
	///   kubectl set sa -f nginx-deployment.yaml serviceaccount1 --local --dry-run -o yaml
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesSetServiceaccountSettings : AutoToolSettings
	{
		/// <summary>
		/// --all
		///
		/// Select all resources, including uninitialized ones, in the namespace of the specified resource types
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
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files identifying the resource to get from a server.
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// --local
		///
		/// If true, set serviceaccount will NOT contact api-server but run locally.
		/// </summary>
		public bool? Local { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --record
		///
		/// Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.
		/// </summary>
		public bool? Record { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
	}
}
