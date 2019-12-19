using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Sets a cluster entry in kubeconfig.
	///
	/// 
	///  Specifying a name that already exists will merge new fields on top of existing values for those fields.
	/// </summary>
	/// <example>
	///   # Set only the server field on the e2e cluster entry without touching other values.
	///   kubectl config set-cluster e2e --server=https://1.2.3.4
	/// 
	///   # Embed certificate authority data for the e2e cluster entry
	///   kubectl config set-cluster e2e --certificate-authority=~/.kube/e2e/kubernetes.ca.crt
	/// 
	///   # Disable cert checking for the dev cluster entry
	///   kubectl config set-cluster e2e --insecure-skip-tls-verify=true
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesConfigSetClusterSettings : AutoToolSettings
	{
		/// <summary>
		/// --embed-certs
		///
		/// embed-certs for the cluster entry in kubeconfig
		/// </summary>
		public bool? EmbedCerts { get; set; }
	}
}
