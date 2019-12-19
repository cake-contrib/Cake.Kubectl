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
		/// View the latest last-applied-configuration annotations by type/name or file.
		///
		/// 
		///  The default output will be printed to stdout in YAML format. One can use -o option to change output format.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesApplyViewLastApplied(this ICakeContext context, KubernetesApplyViewLastAppliedSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesApplyViewLastAppliedSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("apply view-last-applied", settings ?? new KubernetesApplyViewLastAppliedSettings(), arguments);
		}
		/// <summary>
		/// View the latest last-applied-configuration annotations by type/name or file.
		///
		/// 
		///  The default output will be printed to stdout in YAML format. One can use -o option to change output format.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesApplyViewLastAppliedWithResult(this ICakeContext context, KubernetesApplyViewLastAppliedSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesApplyViewLastAppliedSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("apply view-last-applied", settings ?? new KubernetesApplyViewLastAppliedSettings(), arguments);
		}
	}
}
