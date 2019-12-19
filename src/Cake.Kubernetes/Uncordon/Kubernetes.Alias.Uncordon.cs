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
		/// Mark node as schedulable.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesUncordon(this ICakeContext context, KubernetesUncordonSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesUncordonSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("uncordon", settings ?? new KubernetesUncordonSettings(), arguments);
		}
		/// <summary>
		/// Mark node as schedulable.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesUncordonWithResult(this ICakeContext context, KubernetesUncordonSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesUncordonSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("uncordon", settings ?? new KubernetesUncordonSettings(), arguments);
		}
	}
}
