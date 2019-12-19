using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Create and run a particular image, possibly replicated.
	///
	/// 
	///  Creates a deployment or job to manage the created container(s).
	/// </summary>
	/// <example>
	///   # Start a single instance of nginx.
	///   kubectl run nginx --image=nginx
	/// 
	///   # Start a single instance of hazelcast and let the container expose port 5701 .
	///   kubectl run hazelcast --image=hazelcast --port=5701
	/// 
	///   # Start a single instance of hazelcast and set environment variables "DNS_DOMAIN=cluster" and "POD_NAMESPACE=default" in the container.
	///   kubectl run hazelcast --image=hazelcast --env="DNS_DOMAIN=cluster" --env="POD_NAMESPACE=default"
	/// 
	///   # Start a single instance of hazelcast and set labels "app=hazelcast" and "env=prod" in the container.
	///   kubectl run hazelcast --image=hazelcast --labels="app=hazelcast,env=prod"
	/// 
	///   # Start a replicated instance of nginx.
	///   kubectl run nginx --image=nginx --replicas=5
	/// 
	///   # Dry run. Print the corresponding API objects without creating them.
	///   kubectl run nginx --image=nginx --dry-run
	/// 
	///   # Start a single instance of nginx, but overload the spec of the deployment with a partial set of values parsed from JSON.
	///   kubectl run nginx --image=nginx --overrides='{ "apiVersion": "v1", "spec": { ... } }'
	/// 
	///   # Start a pod of busybox and keep it in the foreground, don't restart it if it exits.
	///   kubectl run -i -t busybox --image=busybox --restart=Never
	/// 
	///   # Start the nginx container using the default command, but use custom arguments (arg1 .. argN) for that command.
	///   kubectl run nginx --image=nginx -- <arg1> <arg2> ... <argN>
	/// 
	///   # Start the nginx container using a different command and custom arguments.
	///   kubectl run nginx --image=nginx --command -- <cmd> <arg1> ... <argN>
	/// 
	///   # Start the perl container to compute ╧Ç to 2000 places and print it out.
	///   kubectl run pi --image=perl --restart=OnFailure -- perl -Mbignum=bpi -wle 'print bpi(2000)'
	/// 
	///   # Start the cron job to compute ╧Ç to 2000 places and print it out every 5 minutes.
	///   kubectl run pi --schedule="0/5 * * * ?" --image=perl --restart=OnFailure -- perl -Mbignum=bpi -wle 'print bpi(2000)'
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesRunSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --attach
		///
		/// If true, wait for the Pod to start running, and then attach to the Pod as if 'kubectl attach ...' were called.  Default false, unless '-i/--stdin' is set, in which case the default is true. With '--restart=Never' the exit code of the container process is returned.
		/// </summary>
		public bool? Attach { get; set; }
		/// <summary>
		/// --cascade
		///
		/// If true, cascade the deletion of the resources managed by this resource (e.g. Pods created by a ReplicationController).  Default true.
		/// </summary>
		public bool? Cascade { get; set; }
		/// <summary>
		/// --command
		///
		/// If true and extra arguments are present, use them as the 'command' field in the container, rather than the 'args' field which is the default.
		/// </summary>
		public bool? Command { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// --env
		///
		/// Environment variables to set in the container
		/// </summary>
		public string Env { get; set; }
		/// <summary>
		/// --expose
		///
		/// If true, a public, external service is created for the container(s) which are run
		/// </summary>
		public bool? Expose { get; set; }
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
		/// --generator
		///
		/// The name of the API generator to use, see http://kubernetes.io/docs/user-guide/kubectl-conventions/#generators for a list.
		/// </summary>
		public string Generator { get; set; }
		/// <summary>
		/// --grace-period
		///
		/// Period of time in seconds given to the resource to terminate gracefully. Ignored if negative. Set to 1 for immediate shutdown. Can only be set to 0 when --force is true (force deletion).
		/// </summary>
		public int? GracePeriod { get; set; }
		/// <summary>
		/// --hostport
		///
		/// The host port mapping for the container port. To demonstrate a single-machine container.
		/// </summary>
		public int? Hostport { get; set; }
		/// <summary>
		/// --image
		///
		/// The image for the container to run.
		/// </summary>
		public string Image { get; set; }
		/// <summary>
		/// --image-pull-policy
		///
		/// The image pull policy for the container. If left empty, this value will not be specified by the client and defaulted by the server
		/// </summary>
		public string ImagePullPolicy { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process a kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// -l, --labels
		///
		/// Comma separated labels to apply to the pod(s). Will override previous values.
		/// </summary>
		public string Labels { get; set; }
		/// <summary>
		/// --leave-stdin-open
		///
		/// If the pod is started in interactive mode or with stdin, leave stdin open after the first attach completes. By default, stdin will be closed after the first attach completes.
		/// </summary>
		public bool? LeaveStdinOpen { get; set; }
		/// <summary>
		/// --limits
		///
		/// The resource requirement limits for this container.  For example, 'cpu=200m,memory=512Mi'.  Note that server side components may assign limits depending on the server configuration, such as limit ranges.
		/// </summary>
		public string Limits { get; set; }
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
		/// --pod-running-timeout
		///
		/// The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running
		/// </summary>
		public string PodRunningTimeout { get; set; }
		/// <summary>
		/// --port
		///
		/// The port that this container exposes.  If --expose is true, this is also the port used by the service that is created.
		/// </summary>
		public string Port { get; set; }
		/// <summary>
		/// --quiet
		///
		/// If true, suppress prompt messages.
		/// </summary>
		public bool? Quiet { get; set; }
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
		/// -r, --replicas
		///
		/// Number of replicas to create for this container. Default is 1.
		/// </summary>
		public string Replicas { get; set; }
		/// <summary>
		/// --requests
		///
		/// The resource requirement requests for this container.  For example, 'cpu=100m,memory=256Mi'.  Note that server side components may assign requests depending on the server configuration, such as limit ranges.
		/// </summary>
		public string Requests { get; set; }
		/// <summary>
		/// --restart
		///
		/// The restart policy for this Pod.  Legal values [Always, OnFailure, Never].  If set to 'Always' a deployment is created, if set to 'OnFailure' a job is created, if set to 'Never', a regular pod is created. For the latter two --replicas must be 1.  Default 'Always', for CronJobs `Never`.
		/// </summary>
		public string Restart { get; set; }
		/// <summary>
		/// --rm
		///
		/// If true, delete resources created in this command for attached containers.
		/// </summary>
		public bool? Rm { get; set; }
		/// <summary>
		/// --save-config
		///
		/// If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.
		/// </summary>
		public bool? SaveConfig { get; set; }
		/// <summary>
		/// --schedule
		///
		/// A schedule in the Cron format the job should be run with.
		/// </summary>
		public string Schedule { get; set; }
		/// <summary>
		/// --service-generator
		///
		/// The name of the generator to use for creating a service.  Only used if --expose is true
		/// </summary>
		public string ServiceGenerator { get; set; }
		/// <summary>
		/// --service-overrides
		///
		/// An inline JSON override for the generated service object. If this is non-empty, it is used to override the generated object. Requires that the object supply a valid apiVersion field.  Only used if --expose is true.
		/// </summary>
		public string ServiceOverrides { get; set; }
		/// <summary>
		/// --serviceaccount
		///
		/// Service account to set in the pod spec
		/// </summary>
		public string Serviceaccount { get; set; }
		/// <summary>
		/// -i, --stdin
		///
		/// Keep stdin open on the container(s) in the pod, even if nothing is attached.
		/// </summary>
		public bool? Stdin { get; set; }
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
		/// -t, --tty
		///
		/// Allocated a TTY for each container in the pod.
		/// </summary>
		public bool? Tty { get; set; }
		/// <summary>
		/// --wait
		///
		/// If true, wait for resources to be gone before returning. This waits for finalizers.
		/// </summary>
		public bool? Wait { get; set; }
	}
}
