using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Sets a user entry in kubeconfig
	///
	/// 
	///  Specifying a name that already exists will merge new fields on top of existing values.
	/// 
	///   Client-certificate flags:
	///   --client-certificate=certfile --client-key=keyfile
	/// 
	///   Bearer token flags:
	///     --token=bearer_token
	/// 
	///   Basic auth flags:
	///     --username=basic_user --password=basic_password
	/// 
	///  Bearer token and basic auth are mutually exclusive.
	/// </summary>
	/// <example>
	///   # Set only the "client-key" field on the "cluster-admin"
	///   # entry, without touching other values:
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
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlConfigSetCredentialsSettings : AutoToolSettings
	{
		/// <summary>
		/// --auth-provider
		///
		/// Auth provider for the user entry in kubeconfig
		/// </summary>
		public string AuthProvider { get; set; }
		/// <summary>
		/// --auth-provider-arg
		///
		/// 'key=value' arguments for the auth provider
		/// </summary>
		public string AuthProviderArg { get; set; }
		/// <summary>
		/// --embed-certs
		///
		/// Embed client cert/key for the user entry in kubeconfig
		/// </summary>
		public bool? EmbedCerts { get; set; }
	}
}
