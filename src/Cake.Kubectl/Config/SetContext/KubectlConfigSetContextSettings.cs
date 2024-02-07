using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Set a context entry in kubeconfig.
	///
	/// 
	///  Specifying a name that already exists will merge new fields on top of existing values for those fields.
	/// </summary>
	/// <example>
	///   # Set the user field on the gce context entry without touching other values
	///   kubectl config set-context gce --user=cluster-admin
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlConfigSetContextSettings : AutoToolSettings
	{
		/// <summary>
		/// --cluster
		///
		/// cluster for the context entry in kubeconfig
		/// </summary>
		public string? Cluster { get; set; }
		/// <summary>
		/// --current
		///
		/// Modify the current context
		/// </summary>
		public bool? Current { get; set; }
		/// <summary>
		/// --namespace
		///
		/// namespace for the context entry in kubeconfig
		/// </summary>
		public string? Namespace { get; set; }
		/// <summary>
		/// --user
		///
		/// user for the context entry in kubeconfig
		/// </summary>
		public string? User { get; set; }
	}
}
