using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	partial class KubectlAliases
	{
		/// <summary>
		/// Dumps cluster info out suitable for debugging and diagnosing cluster problems.  By default, dumps everything to stdout. You can optionally specify a directory with --output-directory.  If you specify a directory, kubernetes will build a set of files in that directory.  By default only dumps things in the 'kube-system' namespace, but you can switch to a different namespace with the --namespaces flag, or specify --all-namespaces to dump all namespaces.
		///
		/// 
		///  The command also dumps the logs of all of the pods in the cluster, these logs are dumped into different directories based on namespace and pod name.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlClusterInfoDump(this ICakeContext context, KubectlClusterInfoDumpSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlClusterInfoDumpSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("cluster-info dump", settings ?? new KubectlClusterInfoDumpSettings(), arguments);
		}
		/// <summary>
		/// Dumps cluster info out suitable for debugging and diagnosing cluster problems.  By default, dumps everything to stdout. You can optionally specify a directory with --output-directory.  If you specify a directory, kubernetes will build a set of files in that directory.  By default only dumps things in the 'kube-system' namespace, but you can switch to a different namespace with the --namespaces flag, or specify --all-namespaces to dump all namespaces.
		///
		/// 
		///  The command also dumps the logs of all of the pods in the cluster, these logs are dumped into different directories based on namespace and pod name.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlClusterInfoDumpWithResult(this ICakeContext context, KubectlClusterInfoDumpSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlClusterInfoDumpSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("cluster-info dump", settings ?? new KubectlClusterInfoDumpSettings(), arguments);
		}
	}
}
