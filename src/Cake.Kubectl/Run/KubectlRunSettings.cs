using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Create and run a particular image in a pod.
	///
	/// </summary>
	/// <example>
	///   # Start a nginx pod
	///   kubectl run nginx --image=nginx
	/// 
	///   # Start a hazelcast pod and let the container expose port 5701
	///   kubectl run hazelcast --image=hazelcast/hazelcast --port=5701
	/// 
	///   # Start a hazelcast pod and set environment variables "DNS_DOMAIN=cluster" and "POD_NAMESPACE=default" in the container
	///   kubectl run hazelcast --image=hazelcast/hazelcast --env="DNS_DOMAIN=cluster" --env="POD_NAMESPACE=default"
	/// 
	///   # Start a hazelcast pod and set labels "app=hazelcast" and "env=prod" in the container
	///   kubectl run hazelcast --image=hazelcast/hazelcast --labels="app=hazelcast,env=prod"
	/// 
	///   # Dry run; print the corresponding API objects without creating them
	///   kubectl run nginx --image=nginx --dry-run=client
	/// 
	///   # Start a nginx pod, but overload the spec with a partial set of values parsed from JSON
	///   kubectl run nginx --image=nginx --overrides='{ "apiVersion": "v1", "spec": { ... } }'
	/// 
	///   # Start a busybox pod and keep it in the foreground, don't restart it if it exits
	///   kubectl run -i -t busybox --image=busybox --restart=Never
	/// 
	///   # Start the nginx pod using the default command, but use custom arguments (arg1 .. argN) for that command
	///   kubectl run nginx --image=nginx -- &lt;arg1&gt; &lt;arg2&gt; ... &lt;argN&gt;
	/// 
	///   # Start the nginx pod using a different command and custom arguments
	///   kubectl run nginx --image=nginx --command -- &lt;cmd&gt; &lt;arg1&gt; ... &lt;argN&gt;
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlRunSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --annotations
		///
		/// Annotations to apply to the pod.
		/// </summary>
		public string? Annotations { get; set; }
		/// <summary>
		/// --attach
		///
		/// If true, wait for the Pod to start running, and then attach to the Pod as if 'kubectl attach ...' were called.  Default false, unless '-i/--stdin' is set, in which case the default is true. With '--restart=Never' the exit code of the container process is returned.
		/// </summary>
		public bool? Attach { get; set; }
		/// <summary>
		/// --command
		///
		/// If true and extra arguments are present, use them as the 'command' field in the container, rather than the 'args' field which is the default.
		/// </summary>
		public bool? Command { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// Must be "none", "server", or "client". If client strategy, only print the object that would be sent, without sending it. If server strategy, submit server-side request without persisting the resource.
		/// </summary>
		public string? DryRun { get; set; }
		/// <summary>
		/// --env
		///
		/// Environment variables to set in the container.
		/// </summary>
		public string? Env { get; set; }
		/// <summary>
		/// --expose
		///
		/// If true, create a ClusterIP service associated with the pod.  Requires `--port`.
		/// </summary>
		public bool? Expose { get; set; }
		/// <summary>
		/// --field-manager
		///
		/// Name of the manager used to track field ownership.
		/// </summary>
		public string? FieldManager { get; set; }
		/// <summary>
		/// --image
		///
		/// The image for the container to run.
		/// </summary>
		public string? Image { get; set; }
		/// <summary>
		/// --image-pull-policy
		///
		/// The image pull policy for the container.  If left empty, this value will not be specified by the client and defaulted by the server.
		/// </summary>
		public string? ImagePullPolicy { get; set; }
		/// <summary>
		/// -l, --labels
		///
		/// Comma separated labels to apply to the pod. Will override previous values.
		/// </summary>
		public string? Labels { get; set; }
		/// <summary>
		/// --leave-stdin-open
		///
		/// If the pod is started in interactive mode or with stdin, leave stdin open after the first attach completes. By default, stdin will be closed after the first attach completes.
		/// </summary>
		public bool? LeaveStdinOpen { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// --override-type
		///
		/// The method used to override the generated object: json, merge, or strategic.
		/// </summary>
		public string? OverrideType { get; set; }
		/// <summary>
		/// --overrides
		///
		/// An inline JSON override for the generated object. If this is non-empty, it is used to override the generated object. Requires that the object supply a valid apiVersion field.
		/// </summary>
		public string? Overrides { get; set; }
		/// <summary>
		/// --pod-running-timeout
		///
		/// The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running
		/// </summary>
		public string? PodRunningTimeout { get; set; }
		/// <summary>
		/// --port
		///
		/// The port that this container exposes.
		/// </summary>
		public string? Port { get; set; }
		/// <summary>
		/// --privileged
		///
		/// If true, run the container in privileged mode.
		/// </summary>
		public bool? Privileged { get; set; }
		/// <summary>
		/// -q, --quiet
		///
		/// If true, suppress prompt messages.
		/// </summary>
		public bool? Quiet { get; set; }
		/// <summary>
		/// --restart
		///
		/// The restart policy for this Pod.  Legal values [Always, OnFailure, Never].
		/// </summary>
		public string? Restart { get; set; }
		/// <summary>
		/// --rm
		///
		/// If true, delete the pod after it exits.  Only valid when attaching to the container, e.g. with '--attach' or with '-i/--stdin'.
		/// </summary>
		public bool? Rm { get; set; }
		/// <summary>
		/// --save-config
		///
		/// If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.
		/// </summary>
		public bool? SaveConfig { get; set; }
		/// <summary>
		/// --show-managed-fields
		///
		/// If true, keep the managedFields when printing objects in JSON or YAML format.
		/// </summary>
		public bool? ShowManagedFields { get; set; }
		/// <summary>
		/// -i, --stdin
		///
		/// Keep stdin open on the container in the pod, even if nothing is attached.
		/// </summary>
		public bool? Stdin { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string? Template { get; set; }
		/// <summary>
		/// -t, --tty
		///
		/// Allocate a TTY for the container in the pod.
		/// </summary>
		public bool? Tty { get; set; }
	}
}
