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
		/// Rollback to a previous rollout.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesRolloutUndo(this ICakeContext context, KubernetesRolloutUndoSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesRolloutUndoSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("rollout undo", settings ?? new KubernetesRolloutUndoSettings(), arguments);
		}
		/// <summary>
		/// Rollback to a previous rollout.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesRolloutUndoWithResult(this ICakeContext context, KubernetesRolloutUndoSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesRolloutUndoSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("rollout undo", settings ?? new KubernetesRolloutUndoSettings(), arguments);
		}
	}
}
