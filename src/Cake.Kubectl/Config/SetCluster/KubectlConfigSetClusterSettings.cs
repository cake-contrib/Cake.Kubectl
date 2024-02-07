using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Set a cluster entry in kubeconfig.
	///
	/// 
	///  Specifying a name that already exists will merge new fields on top of existing values for those fields.
	/// </summary>
	/// <example>
	///   # Set only the server field on the e2e cluster entry without touching other values
	///   kubectl config set-cluster e2e --server=https://1.2.3.4
	/// 
	///   # Embed certificate authority data for the e2e cluster entry
	///   kubectl config set-cluster e2e --embed-certs --certificate-authority=~/.kube/e2e/kubernetes.ca.crt
	/// 
	///   # Disable cert checking for the e2e cluster entry
	///   kubectl config set-cluster e2e --insecure-skip-tls-verify=true
	/// 
	///   # Set custom TLS server name to use for validation for the e2e cluster entry
	///   kubectl config set-cluster e2e --tls-server-name=my-cluster-name
	/// 
	///   # Set proxy url for the e2e cluster entry
	///   kubectl config set-cluster e2e --proxy-url=https://1.2.3.4
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlConfigSetClusterSettings : AutoToolSettings
	{
		/// <summary>
		/// --certificate-authority
		///
		/// Path to certificate-authority file for the cluster entry in kubeconfig
		/// </summary>
		public string? CertificateAuthority { get; set; }
		/// <summary>
		/// --embed-certs
		///
		/// embed-certs for the cluster entry in kubeconfig
		/// </summary>
		public bool? EmbedCerts { get; set; }
		/// <summary>
		/// --insecure-skip-tls-verify
		///
		/// insecure-skip-tls-verify for the cluster entry in kubeconfig
		/// </summary>
		public bool? InsecureSkipTlsVerify { get; set; }
		/// <summary>
		/// --proxy-url
		///
		/// proxy-url for the cluster entry in kubeconfig
		/// </summary>
		public string? ProxyUrl { get; set; }
		/// <summary>
		/// --server
		///
		/// server for the cluster entry in kubeconfig
		/// </summary>
		public string? Server { get; set; }
		/// <summary>
		/// --tls-server-name
		///
		/// tls-server-name for the cluster entry in kubeconfig
		/// </summary>
		public string? TlsServerName { get; set; }
	}
}
