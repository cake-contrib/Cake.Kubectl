using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Update environment variables on a pod template.
	///
	/// 
	///  List environment variable definitions in one or more pods, pod templates. Add, update, or remove container environment variable definitions in one or more pod templates (within replication controllers or deployment configurations). View or modify the environment variable definitions on all containers in the specified pods or pod templates, or just those that match a wildcard.
	/// 
	///  If "--env -" is passed, environment variables can be read from STDIN using the standard env syntax.
	/// 
	///  Possible resources include (case insensitive):
	/// 
	///   pod (po), replicationcontroller (rc), deployment (deploy), daemonset (ds), job, replicaset (rs)
	/// </summary>
	/// <example>
	///   # Update deployment 'registry' with a new environment variable
	///   kubectl set env deployment/registry STORAGE_DIR=/local
	/// 
	///   # List the environment variables defined on a deployments 'sample-build'
	///   kubectl set env deployment/sample-build --list
	/// 
	///   # List the environment variables defined on all pods
	///   kubectl set env pods --all --list
	/// 
	///   # Output modified deployment in YAML, and does not alter the object on the server
	///   kubectl set env deployment/sample-build STORAGE_DIR=/data -o yaml
	/// 
	///   # Update all containers in all replication controllers in the project to have ENV=prod
	///   kubectl set env rc --all ENV=prod
	/// 
	///   # Import environment from a secret
	///   kubectl set env --from=secret/mysecret deployment/myapp
	/// 
	///   # Import environment from a config map with a prefix
	///   kubectl set env --from=configmap/myconfigmap --prefix=MYSQL_ deployment/myapp
	/// 
	///   # Import specific keys from a config map
	///   kubectl set env --keys=my-example-key --from=configmap/myconfigmap deployment/myapp
	/// 
	///   # Remove the environment variable ENV from container 'c1' in all deployment configs
	///   kubectl set env deployments --all --containers="c1" ENV-
	/// 
	///   # Remove the environment variable ENV from a deployment definition on disk and
	///   # update the deployment config on the server
	///   kubectl set env -f deploy.json ENV-
	/// 
	///   # Set some of the local shell environment into a deployment config on the server
	///   env | grep RAILS_ | kubectl set env -e - deployment/registry
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlSetEnvSettings : AutoToolSettings
	{
		/// <summary>
		/// --all
		///
		/// If true, select all resources in the namespace of the specified resource types
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
		/// The names of containers in the selected pod templates to change - may use wildcards
		/// </summary>
		public string Containers { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// -e, --env
		///
		/// Specify a key-value pair for an environment variable to set into each container.
		/// </summary>
		public string Env { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files the resource to update the env
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// --from
		///
		/// The name of a resource from which to inject environment variables
		/// </summary>
		public string From { get; set; }
		/// <summary>
		/// --keys
		///
		/// Comma-separated list of keys to import from specified resource
		/// </summary>
		public string Keys { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// --list
		///
		/// If true, display the environment and any changes in the standard format. this flag will removed when we have kubectl view env.
		/// </summary>
		public bool? List { get; set; }
		/// <summary>
		/// --local
		///
		/// If true, set env will NOT contact api-server but run locally.
		/// </summary>
		public bool? Local { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --overwrite
		///
		/// If true, allow environment to be overwritten, otherwise reject updates that overwrite existing environment.
		/// </summary>
		public bool? Overwrite { get; set; }
		/// <summary>
		/// --prefix
		///
		/// Prefix to append to variable names
		/// </summary>
		public string Prefix { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
		/// <summary>
		/// --resolve
		///
		/// If true, show secret or configmap references when listing variables
		/// </summary>
		public bool? Resolve { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on
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
