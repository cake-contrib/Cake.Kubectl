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
		/// Create a resourcequota with the specified name, hard limits and optional scopes
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCreateQuota(this ICakeContext context, KubectlCreateQuotaSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateQuotaSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create quota", settings ?? new KubectlCreateQuotaSettings(), arguments);
		}
		/// <summary>
		/// Create a resourcequota with the specified name, hard limits and optional scopes
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCreateQuotaWithResult(this ICakeContext context, KubectlCreateQuotaSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateQuotaSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create quota", settings ?? new KubectlCreateQuotaSettings(), arguments);
		}
	}
}
