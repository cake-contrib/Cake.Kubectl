using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Replace a resource by filename or stdin.
	///
	/// 
	///  JSON and YAML formats are accepted. If replacing an existing resource, the complete resource spec must be provided. This can be obtained by
	/// 
	///   $ kubectl get TYPE NAME -o yaml
	/// </summary>
	/// <example>
	///   # Replace a pod using the data in pod.json.
	///   kubectl replace -f ./pod.json
	/// 
	///   # Replace a pod based on the JSON passed into stdin.
	///   cat pod.json | kubectl replace -f -
	/// 
	///   # Update a single-container pod's image version (tag) to v4
	///   kubectl get pod mypod -o yaml | sed 's/\(image: myimage\):.*$/\1:v4/' | kubectl replace -f -
	/// 
	///   # Force replace, delete and then re-create the resource
	///   kubectl replace --force -f ./pod.json
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesReplaceSettings : AutoToolSettings
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
		/// If true, cascade the deletion of the resources managed by this resource (e.g. Pods created by a ReplicationController).  Default true.
		/// </summary>
		public bool? Cascade { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// to use to replace the resource.
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// --force
		///
		/// Only used when grace-period=0. If true, immediately remove resources from API and bypass graceful deletion. Note that immediate deletion of some resources may result in inconsistency or data loss and requires confirmation.
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
		/// --save-config
		///
		/// If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.
		/// </summary>
		public bool? SaveConfig { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
		/// <summary>
		/// --timeout
		///
		/// The length of time to wait before giving up on a delete, zero means determine a timeout from the size of the object
		/// </summary>
		public string Timeout { get; set; }
		/// <summary>
		/// --validate
		///
		/// If true, use a schema to validate the input before sending it
		/// </summary>
		public bool? Validate { get; set; }
		/// <summary>
		/// --wait
		///
		/// If true, wait for resources to be gone before returning. This waits for finalizers.
		/// </summary>
		public bool? Wait { get; set; }
	}
}
