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
		/// Mark node as schedulable.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlUncordon(this ICakeContext context, KubectlUncordonSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlUncordonSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("uncordon", settings ?? new KubectlUncordonSettings(), arguments);
		}
		/// <summary>
		/// Mark node as schedulable.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlUncordonWithResult(this ICakeContext context, KubectlUncordonSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlUncordonSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("uncordon", settings ?? new KubectlUncordonSettings(), arguments);
		}
	}
}
