using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Expose a resource as a new Kubernetes service.
	///
	/// 
	///  Looks up a deployment, service, replica set, replication controller or pod by name and uses the selector for that resource as the selector for a new service on the specified port. A deployment or replica set will be exposed as a service only if its selector is convertible to a selector that service supports, i.e. when the selector contains only the matchLabels component. Note that if no port is specified via --port and the exposed resource has multiple ports, all will be re-used by the new service. Also if no labels are specified, the new service will re-use the labels from the resource it exposes.
	/// 
	///  Possible resources include (case insensitive):
	/// 
	///  pod (po), service (svc), replicationcontroller (rc), deployment (deploy), replicaset (rs)
	/// </summary>
	/// <example>
	///   # Create a service for a replicated nginx, which serves on port 80 and connects to the containers on port 8000.
	///   kubectl expose rc nginx --port=80 --target-port=8000
	/// 
	///   # Create a service for a replication controller identified by type and name specified in "nginx-controller.yaml", which serves on port 80 and connects to the containers on port 8000.
	///   kubectl expose -f nginx-controller.yaml --port=80 --target-port=8000
	/// 
	///   # Create a service for a pod valid-pod, which serves on port 444 with the name "frontend"
	///   kubectl expose pod valid-pod --port=444 --name=frontend
	/// 
	///   # Create a second service based on the above service, exposing the container port 8443 as port 443 with the name "nginx-https"
	///   kubectl expose service nginx --port=443 --target-port=8443 --name=nginx-https
	/// 
	///   # Create a service for a replicated streaming application on port 4100 balancing UDP traffic and named 'video-stream'.
	///   kubectl expose rc streamer --port=4100 --protocol=UDP --name=video-stream
	/// 
	///   # Create a service for a replicated nginx using replica set, which serves on port 80 and connects to the containers on port 8000.
	///   kubectl expose rs nginx --port=80 --target-port=8000
	/// 
	///   # Create a service for an nginx deployment, which serves on port 80 and connects to the containers on port 8000.
	///   kubectl expose deployment nginx --port=80 --target-port=8000
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesExposeSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --cluster-ip
		///
		/// ClusterIP to be assigned to the service. Leave empty to auto-allocate, or set to 'None' to create a headless service.
		/// </summary>
		public string ClusterIp { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// --external-ip
		///
		/// Additional external IP address (not managed by Kubernetes) to accept for the service. If this IP is routed to a node, the service can be accessed by this IP in addition to its generated service IP.
		/// </summary>
		public string ExternalIp { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files identifying the resource to expose a service
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// --generator
		///
		/// The name of the API generator to use. There are 2 generators: 'service/v1' and 'service/v2'. The only difference between them is that service port in v1 is named 'default', while it is left unnamed in v2. Default is 'service/v2'.
		/// </summary>
		public string Generator { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// -l, --labels
		///
		/// Labels to apply to the service created by this call.
		/// </summary>
		public string Labels { get; set; }
		/// <summary>
		/// --load-balancer-ip
		///
		/// IP to assign to the LoadBalancer. If empty, an ephemeral IP will be created and used (cloud-provider specific).
		/// </summary>
		public string LoadBalancerIp { get; set; }
		/// <summary>
		/// --name
		///
		/// The name for the newly created object.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --overrides
		///
		/// An inline JSON override for the generated object. If this is non-empty, it is used to override the generated object. Requires that the object supply a valid apiVersion field.
		/// </summary>
		public string Overrides { get; set; }
		/// <summary>
		/// --port
		///
		/// The port that the service should serve on. Copied from the resource being exposed, if unspecified
		/// </summary>
		public string Port { get; set; }
		/// <summary>
		/// --protocol
		///
		/// The network protocol for the service to be created. Default is 'TCP'.
		/// </summary>
		public string Protocol { get; set; }
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
		/// --save-config
		///
		/// If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.
		/// </summary>
		public bool? SaveConfig { get; set; }
		/// <summary>
		/// --selector
		///
		/// A label selector to use for this service. Only equality-based selector requirements are supported. If empty (the default) infer the selector from the replication controller or replica set.)
		/// </summary>
		public string Selector { get; set; }
		/// <summary>
		/// --session-affinity
		///
		/// If non-empty, set the session affinity for the service to this; legal values: 'None', 'ClientIP'
		/// </summary>
		public string SessionAffinity { get; set; }
		/// <summary>
		/// --target-port
		///
		/// Name or number for the port on the container that the service should direct traffic to. Optional.
		/// </summary>
		public string TargetPort { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
		/// <summary>
		/// --type
		///
		/// Type for this service: ClusterIP, NodePort, LoadBalancer, or ExternalName. Default is 'ClusterIP'.
		/// </summary>
		public string Type { get; set; }
	}
}
