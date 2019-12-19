using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Update User, Group or ServiceAccount in a RoleBinding/ClusterRoleBinding.
	///
	/// </summary>
	/// <example>
	///   # Update a ClusterRoleBinding for serviceaccount1
	///   kubectl set subject clusterrolebinding admin --serviceaccount=namespace:serviceaccount1
	/// 
	///   # Update a RoleBinding for user1, user2, and group1
	///   kubectl set subject rolebinding admin --user=user1 --user=user2 --group=group1
	/// 
	///   # Print the result (in yaml format) of updating rolebinding subjects from a local, without hitting the server
	///   kubectl create rolebinding admin --role=admin --user=admin -o yaml --dry-run | kubectl set subject --local -f - --user=foo -o yaml
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesSetSubjectSettings : AutoToolSettings
	{
		/// <summary>
		/// --all
		///
		/// Select all resources, including uninitialized ones, in the namespace of the specified resource types
		/// </summary>
		public bool? All { get; set; }
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files the resource to update the subjects
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// --group
		///
		/// Groups to bind to the role
		/// </summary>
		public string Group { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// --local
		///
		/// If true, set subject will NOT contact api-server but run locally.
		/// </summary>
		public bool? Local { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, not including uninitialized ones, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2)
		/// </summary>
		public string Selector { get; set; }
		/// <summary>
		/// --serviceaccount
		///
		/// Service accounts to bind to the role
		/// </summary>
		public string Serviceaccount { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
	}
}
