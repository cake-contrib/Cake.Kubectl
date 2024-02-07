using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Set a user entry in kubeconfig.
	///
	/// 
	///  Specifying a name that already exists will merge new fields on top of existing values.
	/// 
	///   Client-certificate flags:
	///   --client-certificate=certfile --client-key=keyfile
	/// 
	///   Bearer token flags:
	///   --token=bearer_token
	/// 
	///   Basic auth flags:
	///   --username=basic_user --password=basic_password
	/// 
	///  Bearer token and basic auth are mutually exclusive.
	/// </summary>
	/// <example>
	///   # Set only the "client-key" field on the "cluster-admin"
	///   # entry, without touching other values
	///   kubectl config set-credentials cluster-admin --client-key=~/.kube/admin.key
	/// 
	///   # Set basic auth for the "cluster-admin" entry
	///   kubectl config set-credentials cluster-admin --username=admin --password=uXFGweU9l35qcif
	/// 
	///   # Embed client certificate data in the "cluster-admin" entry
	///   kubectl config set-credentials cluster-admin --client-certificate=~/.kube/admin.crt --embed-certs=true
	/// 
	///   # Enable the Google Compute Platform auth provider for the "cluster-admin" entry
	///   kubectl config set-credentials cluster-admin --auth-provider=gcp
	/// 
	///   # Enable the OpenID Connect auth provider for the "cluster-admin" entry with additional args
	///   kubectl config set-credentials cluster-admin --auth-provider=oidc --auth-provider-arg=client-id=foo --auth-provider-arg=client-secret=bar
	/// 
	///   # Remove the "client-secret" config value for the OpenID Connect auth provider for the "cluster-admin" entry
	///   kubectl config set-credentials cluster-admin --auth-provider=oidc --auth-provider-arg=client-secret-
	/// 
	///   # Enable new exec auth plugin for the "cluster-admin" entry
	///   kubectl config set-credentials cluster-admin --exec-command=/path/to/the/executable --exec-api-version=client.authentication.k8s.io/v1beta1
	/// 
	///   # Define new exec auth plugin args for the "cluster-admin" entry
	///   kubectl config set-credentials cluster-admin --exec-arg=arg1 --exec-arg=arg2
	/// 
	///   # Create or update exec auth plugin environment variables for the "cluster-admin" entry
	///   kubectl config set-credentials cluster-admin --exec-env=key1=val1 --exec-env=key2=val2
	/// 
	///   # Remove exec auth plugin environment variables for the "cluster-admin" entry
	///   kubectl config set-credentials cluster-admin --exec-env=var-to-remove-
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlConfigSetCredentialsSettings : AutoToolSettings
	{
		/// <summary>
		/// --auth-provider
		///
		/// Auth provider for the user entry in kubeconfig
		/// </summary>
		public string? AuthProvider { get; set; }
		/// <summary>
		/// --auth-provider-arg
		///
		/// 'key=value' arguments for the auth provider
		/// </summary>
		public string? AuthProviderArg { get; set; }
		/// <summary>
		/// --client-certificate
		///
		/// Path to client-certificate file for the user entry in kubeconfig
		/// </summary>
		public string? ClientCertificate { get; set; }
		/// <summary>
		/// --client-key
		///
		/// Path to client-key file for the user entry in kubeconfig
		/// </summary>
		public string? ClientKey { get; set; }
		/// <summary>
		/// --embed-certs
		///
		/// Embed client cert/key for the user entry in kubeconfig
		/// </summary>
		public bool? EmbedCerts { get; set; }
		/// <summary>
		/// --exec-api-version
		///
		/// API version of the exec credential plugin for the user entry in kubeconfig
		/// </summary>
		public string? ExecApiVersion { get; set; }
		/// <summary>
		/// --exec-arg
		///
		/// New arguments for the exec credential plugin command for the user entry in kubeconfig
		/// </summary>
		public string? ExecArg { get; set; }
		/// <summary>
		/// --exec-command
		///
		/// Command for the exec credential plugin for the user entry in kubeconfig
		/// </summary>
		public string? ExecCommand { get; set; }
		/// <summary>
		/// --exec-env
		///
		/// 'key=value' environment values for the exec credential plugin
		/// </summary>
		public string? ExecEnv { get; set; }
		/// <summary>
		/// --password
		///
		/// password for the user entry in kubeconfig
		/// </summary>
		public string? Password { get; set; }
		/// <summary>
		/// --token
		///
		/// token for the user entry in kubeconfig
		/// </summary>
		public string? Token { get; set; }
		/// <summary>
		/// --username
		///
		/// username for the user entry in kubeconfig
		/// </summary>
		public string? Username { get; set; }
	}
}
