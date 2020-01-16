using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Create a RoleBinding for a particular Role or ClusterRole.
	///
	/// </summary>
	/// <example>
	///   # Create a RoleBinding for user1, user2, and group1 using the admin ClusterRole
	///   kubectl create rolebinding admin --clusterrole=admin --user=user1 --user=user2 --group=group1
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCreateRolebindingSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --clusterrole
		///
		/// ClusterRole this RoleBinding should reference
		/// </summary>
		public string Clusterrole { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// --generator
		///
		/// The name of the API generator to use.
		/// </summary>
		public string Generator { get; set; }
		/// <summary>
		/// --group
		///
		/// Groups to bind to the role
		/// </summary>
		public string Group { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --role
		///
		/// Role this RoleBinding should reference
		/// </summary>
		public string Role { get; set; }
		/// <summary>
		/// --save-config
		///
		/// If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.
		/// </summary>
		public bool? SaveConfig { get; set; }
		/// <summary>
		/// --serviceaccount
		///
		/// Service accounts to bind to the role, in the format <namespace>:<name>
		/// </summary>
		public string Serviceaccount { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
		/// <summary>
		/// --validate
		///
		/// If true, use a schema to validate the input before sending it
		/// </summary>
		public bool? Validate { get; set; }
	}
}
