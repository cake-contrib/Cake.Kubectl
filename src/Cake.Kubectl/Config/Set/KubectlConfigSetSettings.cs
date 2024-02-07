using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Set an individual value in a kubeconfig file.
	///
	/// 
	///  PROPERTY_NAME is a dot delimited name where each token represents either an attribute name or a map key.  Map keys may not contain dots.
	/// 
	///  PROPERTY_VALUE is the new value you want to set. Binary fields such as 'certificate-authority-data' expect a base64 encoded string unless the --set-raw-bytes flag is used.
	/// 
	///  Specifying an attribute name that already exists will merge new fields on top of existing values.
	/// </summary>
	/// <example>
	///   # Set the server field on the my-cluster cluster to https://1.2.3.4
	///   kubectl config set clusters.my-cluster.server https://1.2.3.4
	/// 
	///   # Set the certificate-authority-data field on the my-cluster cluster
	///   kubectl config set clusters.my-cluster.certificate-authority-data $(echo "cert_data_here" | base64 -i -)
	/// 
	///   # Set the cluster field in the my-context context to my-cluster
	///   kubectl config set contexts.my-context.cluster my-cluster
	/// 
	///   # Set the client-key-data field in the cluster-admin user using --set-raw-bytes option
	///   kubectl config set users.cluster-admin.client-key-data cert_data_here --set-raw-bytes=true
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlConfigSetSettings : AutoToolSettings
	{
		/// <summary>
		/// --set-raw-bytes
		///
		/// When writing a []byte PROPERTY_VALUE, write the given string directly without base64 decoding.
		/// </summary>
		public bool? SetRawBytes { get; set; }
	}
}
