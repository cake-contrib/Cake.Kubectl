using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Create a new secret for use with Docker registries.
	///
	/// 
	///   Dockercfg secrets are used to authenticate against Docker registries.
	/// 
	///   When using the Docker command line to push images, you can authenticate to a given registry by running:
	///   '$ docker login DOCKER_REGISTRY_SERVER --username=DOCKER_USER --password=DOCKER_PASSWORD --email=DOCKER_EMAIL'.
	/// 
	///  That produces a ~/.dockercfg file that is used by subsequent 'docker push' and 'docker pull' commands to authenticate to the registry. The email address is optional.
	/// 
	///   When creating applications, you may have a Docker registry that requires authentication.  In order for the
	///   nodes to pull images on your behalf, they must have the credentials.  You can provide this information
	///   by creating a dockercfg secret and attaching it to your service account.
	/// </summary>
	/// <example>
	///   # If you don't already have a .dockercfg file, you can create a dockercfg secret directly by using:
	///   kubectl create secret docker-registry my-secret --docker-server=DOCKER_REGISTRY_SERVER --docker-username=DOCKER_USER --docker-password=DOCKER_PASSWORD --docker-email=DOCKER_EMAIL
	/// 
	///   # Create a new secret named my-secret from ~/.docker/config.json
	///   kubectl create secret docker-registry my-secret --from-file=.dockerconfigjson=path/to/.docker/config.json
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCreateSecretDockerRegistrySettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --append-hash
		///
		/// Append a hash of the secret to its name.
		/// </summary>
		public bool? AppendHash { get; set; }
		/// <summary>
		/// --docker-email
		///
		/// Email for Docker registry
		/// </summary>
		public string? DockerEmail { get; set; }
		/// <summary>
		/// --docker-password
		///
		/// Password for Docker registry authentication
		/// </summary>
		public string? DockerPassword { get; set; }
		/// <summary>
		/// --docker-server
		///
		/// Server location for Docker registry
		/// </summary>
		public string? DockerServer { get; set; }
		/// <summary>
		/// --docker-username
		///
		/// Username for Docker registry authentication
		/// </summary>
		public string? DockerUsername { get; set; }
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
		/// --from-file
		///
		/// Key files can be specified using their file path, in which case a default name will be given to them, or optionally with a name and file path, in which case the given name will be used.  Specifying a directory will iterate each named file in the directory that is a valid secret key.
		/// </summary>
		public string? FromFile { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
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
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string? Template { get; set; }
		/// <summary>
		/// --validate
		///
		/// Must be one of: strict (or true), warn, ignore (or false). 		"true" or "strict" will use a schema to validate the input and fail the request if invalid. It will perform server side validation if ServerSideFieldValidation is enabled on the api-server, but will fall back to less reliable client-side validation if not. 		"warn" will warn about unknown or duplicate fields without blocking the request if server-side field validation is enabled on the API server, and behave as "ignore" otherwise. 		"false" or "ignore" will not perform any schema validation, silently dropping any unknown or duplicate fields.
		/// </summary>
		public string? Validate { get; set; }
	}
}
