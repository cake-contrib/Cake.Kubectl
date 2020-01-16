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
		public static void KubectlRollout(this ICakeContext context, KubectlRolloutSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlRolloutSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("rollout", settings ?? new KubectlRolloutSettings(), arguments);
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
		public static IEnumerable<string> KubectlRolloutWithResult(this ICakeContext context, KubectlRolloutSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlRolloutSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("rollout", settings ?? new KubectlRolloutSettings(), arguments);
		}
	}
}
