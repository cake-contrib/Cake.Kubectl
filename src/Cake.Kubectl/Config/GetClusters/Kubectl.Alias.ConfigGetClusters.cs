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
		/// Display clusters defined in the kubeconfig.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlConfigGetClusters(this ICakeContext context, KubectlConfigGetClustersSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigGetClustersSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config get-clusters", settings ?? new KubectlConfigGetClustersSettings(), arguments);
		}
		/// <summary>
		/// Display clusters defined in the kubeconfig.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlConfigGetClustersWithResult(this ICakeContext context, KubectlConfigGetClustersSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigGetClustersSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config get-clusters", settings ?? new KubectlConfigGetClustersSettings(), arguments);
		}
	}
}
