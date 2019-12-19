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
		/// Create a pod disruption budget with the specified name, selector, and desired minimum available pods
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreatePoddisruptionbudget(this ICakeContext context, KubernetesCreatePoddisruptionbudgetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreatePoddisruptionbudgetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create poddisruptionbudget", settings ?? new KubernetesCreatePoddisruptionbudgetSettings(), arguments);
		}
		/// <summary>
		/// Create a pod disruption budget with the specified name, selector, and desired minimum available pods
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreatePoddisruptionbudgetWithResult(this ICakeContext context, KubernetesCreatePoddisruptionbudgetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreatePoddisruptionbudgetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create poddisruptionbudget", settings ?? new KubernetesCreatePoddisruptionbudgetSettings(), arguments);
		}
	}
}
