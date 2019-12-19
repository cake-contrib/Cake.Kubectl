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
		/// View previous rollout revisions and configurations.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesRolloutHistory(this ICakeContext context, KubernetesRolloutHistorySettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesRolloutHistorySettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("rollout history", settings ?? new KubernetesRolloutHistorySettings(), arguments);
		}
		/// <summary>
		/// View previous rollout revisions and configurations.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesRolloutHistoryWithResult(this ICakeContext context, KubernetesRolloutHistorySettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesRolloutHistorySettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("rollout history", settings ?? new KubernetesRolloutHistorySettings(), arguments);
		}
	}
}
