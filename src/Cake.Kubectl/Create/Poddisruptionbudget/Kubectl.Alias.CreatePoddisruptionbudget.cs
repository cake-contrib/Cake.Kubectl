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
		/// Create a pod disruption budget with the specified name, selector, and desired minimum available pods
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCreatePoddisruptionbudget(this ICakeContext context, KubectlCreatePoddisruptionbudgetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreatePoddisruptionbudgetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create poddisruptionbudget", settings ?? new KubectlCreatePoddisruptionbudgetSettings(), arguments);
		}
		/// <summary>
		/// Create a pod disruption budget with the specified name, selector, and desired minimum available pods
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCreatePoddisruptionbudgetWithResult(this ICakeContext context, KubectlCreatePoddisruptionbudgetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreatePoddisruptionbudgetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create poddisruptionbudget", settings ?? new KubectlCreatePoddisruptionbudgetSettings(), arguments);
		}
	}
}
