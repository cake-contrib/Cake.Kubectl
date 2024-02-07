using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Build a set of KRM resources using a 'kustomization.yaml' file. The DIR argument must be a path to a directory containing 'kustomization.yaml', or a git repository URL with a path suffix specifying same with respect to the repository root. If DIR is omitted, '.' is assumed.
	///
	/// </summary>
	/// <example>
	///   # Build the current working directory
	///   kubectl kustomize
	/// 
	///   # Build some shared configuration directory
	///   kubectl kustomize /home/config/production
	/// 
	///   # Build from github
	///   kubectl kustomize https://github.com/kubernetes-sigs/kustomize.git/examples/helloWorld?ref=v1.0.6
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlKustomizeSettings : AutoToolSettings
	{
		/// <summary>
		/// --as-current-user
		///
		/// use the uid and gid of the command executor to run the function in the container
		/// </summary>
		public bool? AsCurrentUser { get; set; }
		/// <summary>
		/// --enable-alpha-plugins
		///
		/// enable kustomize plugins
		/// </summary>
		public bool? EnableAlphaPlugins { get; set; }
		/// <summary>
		/// --enable-helm
		///
		/// Enable use of the Helm chart inflator generator.
		/// </summary>
		public bool? EnableHelm { get; set; }
		/// <summary>
		/// -e, --env
		///
		/// a list of environment variables to be used by functions
		/// </summary>
		public string? Env { get; set; }
		/// <summary>
		/// --helm-command
		///
		/// helm command (path to executable)
		/// </summary>
		public string? HelmCommand { get; set; }
		/// <summary>
		/// --load-restrictor
		///
		/// if set to 'LoadRestrictionsNone', local kustomizations may load files from outside their root. This does, however, break the relocatability of the kustomization.
		/// </summary>
		public string? LoadRestrictor { get; set; }
		/// <summary>
		/// --mount
		///
		/// a list of storage options read from the filesystem
		/// </summary>
		public string? Mount { get; set; }
		/// <summary>
		/// --network
		///
		/// enable network access for functions that declare it
		/// </summary>
		public bool? Network { get; set; }
		/// <summary>
		/// --network-name
		///
		/// the docker network to run the container in
		/// </summary>
		public string? NetworkName { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// If specified, write output to this path.
		/// </summary>
		public string? Output { get; set; }
	}
}
