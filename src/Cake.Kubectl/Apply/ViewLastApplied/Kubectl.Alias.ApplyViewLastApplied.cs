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
		/// View the latest last-applied-configuration annotations by type/name or file.
		///
		/// 
		///  The default output will be printed to stdout in YAML format. You can use the -o option to change the output format.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlApplyViewLastApplied(this ICakeContext context, KubectlApplyViewLastAppliedSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlApplyViewLastAppliedSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("apply view-last-applied", settings ?? new KubectlApplyViewLastAppliedSettings(), arguments);
		}
		/// <summary>
		/// View the latest last-applied-configuration annotations by type/name or file.
		///
		/// 
		///  The default output will be printed to stdout in YAML format. You can use the -o option to change the output format.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlApplyViewLastAppliedWithResult(this ICakeContext context, KubectlApplyViewLastAppliedSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlApplyViewLastAppliedSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("apply view-last-applied", settings ?? new KubectlApplyViewLastAppliedSettings(), arguments);
		}
	}
}
