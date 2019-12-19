using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Specify compute resource requirements (cpu, memory) for any resource that defines a pod template.  If a pod is successfully scheduled, it is guaranteed the amount of resource requested, but may burst up to its specified limits.
	///
	/// 
	///  for each compute resource, if a limit is specified and a request is omitted, the request will default to the limit.
	/// 
	///  Possible resources include (case insensitive): Use "kubectl api-resources" for a complete list of supported resources..
	/// </summary>
	/// <example>
	///   # Set a deployments nginx container cpu limits to "200m" and memory to "512Mi"
	///   kubectl set resources deployment nginx -c=nginx --limits=cpu=200m,memory=512Mi
	/// 
	///   # Set the resource request and limits for all containers in nginx
	///   kubectl set resources deployment nginx --limits=cpu=200m,memory=512Mi --requests=cpu=100m,memory=256Mi
	/// 
	///   # Remove the resource requests for resources on containers in nginx
	///   kubectl set resources deployment nginx --limits=cpu=0,memory=0 --requests=cpu=0,memory=0
	/// 
	///   # Print the result (in yaml format) of updating nginx container limits from a local, without hitting the server
	///   kubectl set resources -f path/to/file.yaml --limits=cpu=200m,memory=512Mi --local -o yaml
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesSetResourcesSettings : AutoToolSettings
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
		/// -c, --containers
		///
		/// The names of containers in the selected pod templates to change, all containers are selected by default - may use wildcards
		/// </summary>
		public string Containers { get; set; }
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
		/// --limits
		///
		/// The resource requirement requests for this container.  For example, 'cpu=100m,memory=256Mi'.  Note that server side components may assign requests depending on the server configuration, such as limit ranges.
		/// </summary>
		public string Limits { get; set; }
		/// <summary>
		/// --local
		///
		/// If true, set resources will NOT contact api-server but run locally.
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
		/// --requests
		///
		/// The resource requirement requests for this container.  For example, 'cpu=100m,memory=256Mi'.  Note that server side components may assign requests depending on the server configuration, such as limit ranges.
		/// </summary>
		public string Requests { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, not including uninitialized ones,supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2)
		/// </summary>
		public string Selector { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
	}
}
