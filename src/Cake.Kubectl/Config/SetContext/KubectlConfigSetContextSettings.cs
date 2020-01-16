using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Sets a context entry in kubeconfig
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
		/// --current
		///
		/// Modify the current context
		/// </summary>
		public bool? Current { get; set; }
	}
}
