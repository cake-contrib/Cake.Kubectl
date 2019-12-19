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
		/// Manage the rollout of a resource.
		///
		/// 
		///  Valid resource types include:
		/// 
		///   *  deployments
		///   *  daemonsets
		///   *  statefulsets
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesRollout(this ICakeContext context, KubernetesRolloutSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesRolloutSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("rollout", settings ?? new KubernetesRolloutSettings(), arguments);
		}
		/// <summary>
		/// Manage the rollout of a resource.
		///
		/// 
		///  Valid resource types include:
		/// 
		///   *  deployments
		///   *  daemonsets
		///   *  statefulsets
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesRolloutWithResult(this ICakeContext context, KubernetesRolloutSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesRolloutSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("rollout", settings ?? new KubernetesRolloutSettings(), arguments);
		}
	}
}
