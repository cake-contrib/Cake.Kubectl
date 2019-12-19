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
		/// Create a resourcequota with the specified name, hard limits and optional scopes
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreateQuota(this ICakeContext context, KubernetesCreateQuotaSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateQuotaSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create quota", settings ?? new KubernetesCreateQuotaSettings(), arguments);
		}
		/// <summary>
		/// Create a resourcequota with the specified name, hard limits and optional scopes
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreateQuotaWithResult(this ICakeContext context, KubernetesCreateQuotaSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateQuotaSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create quota", settings ?? new KubernetesCreateQuotaSettings(), arguments);
		}
	}
}
