using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Diff configurations specified by file name or stdin between the current online configuration, and the configuration as it would be if applied.
	///
	/// 
	///  The output is always YAML.
	/// 
	///  KUBECTL_EXTERNAL_DIFF environment variable can be used to select your own diff command. Users can use external commands with params too, example: KUBECTL_EXTERNAL_DIFF="colordiff -N -u"
	/// 
	///  By default, the "diff" command available in your path will be run with the "-u" (unified diff) and "-N" (treat absent files as empty) options.
	/// 
	///  Exit status: 0 No differences were found. 1 Differences were found. &gt;1 Kubectl or diff failed with an error.
	/// 
	///  Note: KUBECTL_EXTERNAL_DIFF, if used, is expected to follow that convention.
	/// </summary>
	/// <example>
	///   # Diff resources included in pod.json
	///   kubectl diff -f pod.json
	/// 
	///   # Diff file read from stdin
	///   cat service.yaml | kubectl diff -f -
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlDiffSettings : AutoToolSettings
	{
		/// <summary>
		/// --field-manager
		///
		/// Name of the manager used to track field ownership.
		/// </summary>
		public string? FieldManager { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files contains the configuration to diff
		/// </summary>
		public string? Filename { get; set; }
		/// <summary>
		/// --force-conflicts
		///
		/// If true, server-side apply will force the changes against conflicts.
		/// </summary>
		public bool? ForceConflicts { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string? Kustomize { get; set; }
		/// <summary>
		/// --prune
		///
		/// Include resources that would be deleted by pruning. Can be used with -l and default shows all resources would be pruned
		/// </summary>
		public bool? Prune { get; set; }
		/// <summary>
		/// --prune-allowlist
		///
		/// Overwrite the default whitelist with &lt;group/version/kind&gt; for --prune
		/// </summary>
		public string? PruneAllowlist { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
		/// <summary>
		/// -l, --selector
		///
		/// Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2). Matching objects must satisfy all of the specified label constraints.
		/// </summary>
		public string? Selector { get; set; }
		/// <summary>
		/// --server-side
		///
		/// If true, apply runs in the server instead of the client.
		/// </summary>
		public bool? ServerSide { get; set; }
		/// <summary>
		/// --show-managed-fields
		///
		/// If true, include managed fields in the diff.
		/// </summary>
		public bool? ShowManagedFields { get; set; }
	}
}
