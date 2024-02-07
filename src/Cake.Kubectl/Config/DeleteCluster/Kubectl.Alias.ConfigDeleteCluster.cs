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
		/// Delete the specified cluster from the kubeconfig.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlConfigDeleteCluster(this ICakeContext context, KubectlConfigDeleteClusterSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigDeleteClusterSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config delete-cluster", settings ?? new KubectlConfigDeleteClusterSettings(), arguments);
		}
		/// <summary>
		/// Delete the specified cluster from the kubeconfig.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlConfigDeleteClusterWithResult(this ICakeContext context, KubectlConfigDeleteClusterSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigDeleteClusterSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config delete-cluster", settings ?? new KubectlConfigDeleteClusterSettings(), arguments);
		}
	}
}
