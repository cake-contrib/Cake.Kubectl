using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Diff configurations specified by filename or stdin between the current online configuration, and the configuration as it would be if applied.
	///
	/// 
	///  Output is always YAML.
	/// 
	///  KUBECTL_EXTERNAL_DIFF environment variable can be used to select your own diff command. By default, the "diff" command available in your path will be run with "-u" (unicode) and "-N" (treat new files as empty) options.
	/// </summary>
	/// <example>
	///   # Diff resources included in pod.json.
	///   kubectl diff -f pod.json
	/// 
	///   # Diff file read from stdin
	///   cat service.yaml | kubectl diff -f -
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesDiffSettings : AutoToolSettings
	{
		/// <summary>
		/// --experimental-field-manager
		///
		/// Name of the manager used to track field ownership. This is an alpha feature and flag.
		/// </summary>
		public string ExperimentalFieldManager { get; set; }
		/// <summary>
		/// --experimental-force-conflicts
		///
		/// If true, server-side apply will force the changes against conflicts. This is an alpha feature and flag.
		/// </summary>
		public bool? ExperimentalForceConflicts { get; set; }
		/// <summary>
		/// --experimental-server-side
		///
		/// If true, apply runs in the server instead of the client. This is an alpha feature and flag.
		/// </summary>
		public bool? ExperimentalServerSide { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files contains the configuration to diff
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
	}
}
