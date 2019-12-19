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
		/// Mark the provided resource as paused
		///
		/// 
		///  Paused resources will not be reconciled by a controller. Use "kubectl rollout resume" to resume a paused resource. Currently only deployments support being paused.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesRolloutPause(this ICakeContext context, KubernetesRolloutPauseSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesRolloutPauseSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("rollout pause", settings ?? new KubernetesRolloutPauseSettings(), arguments);
		}
		/// <summary>
		/// Mark the provided resource as paused
		///
		/// 
		///  Paused resources will not be reconciled by a controller. Use "kubectl rollout resume" to resume a paused resource. Currently only deployments support being paused.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesRolloutPauseWithResult(this ICakeContext context, KubernetesRolloutPauseSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesRolloutPauseSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("rollout pause", settings ?? new KubernetesRolloutPauseSettings(), arguments);
		}
	}
}
