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
		/// Create a ClusterRoleBinding for a particular ClusterRole.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreateClusterrolebinding(this ICakeContext context, KubernetesCreateClusterrolebindingSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateClusterrolebindingSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create clusterrolebinding", settings ?? new KubernetesCreateClusterrolebindingSettings(), arguments);
		}
		/// <summary>
		/// Create a ClusterRoleBinding for a particular ClusterRole.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreateClusterrolebindingWithResult(this ICakeContext context, KubernetesCreateClusterrolebindingSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateClusterrolebindingSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create clusterrolebinding", settings ?? new KubernetesCreateClusterrolebindingSettings(), arguments);
		}
	}
}
