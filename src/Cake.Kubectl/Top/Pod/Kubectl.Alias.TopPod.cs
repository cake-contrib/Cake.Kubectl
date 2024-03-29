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
		/// Display resource (CPU/memory) usage of pods.
		///
		/// 
		///  The 'top pod' command allows you to see the resource consumption of pods.
		/// 
		///  Due to the metrics pipeline delay, they may be unavailable for a few minutes since pod creation.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlTopPod(this ICakeContext context, KubectlTopPodSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlTopPodSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("top pod", settings ?? new KubectlTopPodSettings(), arguments);
		}
		/// <summary>
		/// Display resource (CPU/memory) usage of pods.
		///
		/// 
		///  The 'top pod' command allows you to see the resource consumption of pods.
		/// 
		///  Due to the metrics pipeline delay, they may be unavailable for a few minutes since pod creation.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlTopPodWithResult(this ICakeContext context, KubectlTopPodSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlTopPodSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("top pod", settings ?? new KubectlTopPodSettings(), arguments);
		}
	}
}
