using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// View the latest last-applied-configuration annotations by type/name or file.
	///
	/// 
	///  The default output will be printed to stdout in YAML format. One can use -o option to change output format.
	/// </summary>
	/// <example>
	///   # View the last-applied-configuration annotations by type/name in YAML.
	///   kubectl apply view-last-applied deployment/nginx
	/// 
	///   # View the last-applied-configuration annotations by file in JSON
	///   kubectl apply view-last-applied -f deploy.yaml -o json
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlApplyViewLastAppliedSettings : AutoToolSettings
	{
		/// <summary>
		/// --all
		///
		/// Select all resources in the namespace of the specified resource types
		/// </summary>
		public bool? All { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files that contains the last-applied-configuration annotations
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. Must be one of yaml|json
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
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2)
		/// </summary>
		public string Selector { get; set; }
	}
}
