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
		/// Restart a resource.
		///
		/// 
		///   Resource rollout will be restarted.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlRolloutRestart(this ICakeContext context, KubectlRolloutRestartSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlRolloutRestartSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("rollout restart", settings ?? new KubectlRolloutRestartSettings(), arguments);
		}
		/// <summary>
		/// Restart a resource.
		///
		/// 
		///   Resource rollout will be restarted.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlRolloutRestartWithResult(this ICakeContext context, KubectlRolloutRestartSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlRolloutRestartSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("rollout restart", settings ?? new KubectlRolloutRestartSettings(), arguments);
		}
	}
}
