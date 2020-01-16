using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Print the supported API resources on the server
	///
	/// </summary>
	/// <example>
	///   # Print the supported API Resources
	///   kubectl api-resources
	/// 
	///   # Print the supported API Resources with more information
	///   kubectl api-resources -o wide
	/// 
	///   # Print the supported namespaced resources
	///   kubectl api-resources --namespaced=true
	/// 
	///   # Print the supported non-namespaced resources
	///   kubectl api-resources --namespaced=false
	/// 
	///   # Print the supported API Resources with specific APIGroup
	///   kubectl api-resources --api-group=extensions
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlApiResourcesSettings : AutoToolSettings
	{
		/// <summary>
		/// --api-group
		///
		/// Limit to resources in the specified API group.
		/// </summary>
		public string ApiGroup { get; set; }
		/// <summary>
		/// --cached
		///
		/// Use the cached list of resources if available.
		/// </summary>
		public bool? Cached { get; set; }
		/// <summary>
		/// --namespaced
		///
		/// If false, non-namespaced resources will be returned, otherwise returning namespaced resources by default.
		/// </summary>
		public bool? Namespaced { get; set; }
		/// <summary>
		/// --no-headers
		///
		/// When using the default or custom-column output format, don't print headers (default print headers).
		/// </summary>
		public bool? NoHeaders { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: wide|name.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --verbs
		///
		/// Limit to resources that support the specified verbs.
		/// </summary>
		public string Verbs { get; set; }
	}
}
