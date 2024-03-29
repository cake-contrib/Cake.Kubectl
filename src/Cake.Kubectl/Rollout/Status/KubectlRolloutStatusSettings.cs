using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Show the status of the rollout.
	///
	/// 
	///  By default 'rollout status' will watch the status of the latest rollout until it's done. If you don't want to wait for the rollout to finish then you can use --watch=false. Note that if a new rollout starts in-between, then 'rollout status' will continue watching the latest revision. If you want to pin to a specific revision and abort if it is rolled over by another revision, use --revision=N where N is the revision you need to watch for.
	/// </summary>
	/// <example>
	///   # Watch the rollout status of a deployment
	///   kubectl rollout status deployment/nginx
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlRolloutStatusSettings : AutoToolSettings
	{
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files identifying the resource to get from a server.
		/// </summary>
		public string? Filename { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string? Kustomize { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
		/// <summary>
		/// --revision
		///
		/// Pin to a specific revision for showing its status. Defaults to 0 (last revision).
		/// </summary>
		public string? Revision { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2). Matching objects must satisfy all of the specified label constraints.
		/// </summary>
		public string? Selector { get; set; }
		/// <summary>
		/// --timeout
		///
		/// The length of time to wait before ending watch, zero means never. Any other values should contain a corresponding time unit (e.g. 1s, 2m, 3h).
		/// </summary>
		public string? Timeout { get; set; }
		/// <summary>
		/// -w, --watch
		///
		/// Watch the status of the rollout until it's done.
		/// </summary>
		public bool? Watch { get; set; }
	}
}
