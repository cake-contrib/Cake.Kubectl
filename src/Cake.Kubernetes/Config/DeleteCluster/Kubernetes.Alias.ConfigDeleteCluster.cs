using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	partial class KubernetesAliases
	{
		/// <summary>
		/// Delete the specified cluster from the kubeconfig
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesConfigDeleteCluster(this ICakeContext context, KubernetesConfigDeleteClusterSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigDeleteClusterSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config delete-cluster", settings ?? new KubernetesConfigDeleteClusterSettings(), arguments);
		}
		/// <summary>
		/// Delete the specified cluster from the kubeconfig
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesConfigDeleteClusterWithResult(this ICakeContext context, KubernetesConfigDeleteClusterSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigDeleteClusterSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config delete-cluster", settings ?? new KubernetesConfigDeleteClusterSettings(), arguments);
		}
	}
}
