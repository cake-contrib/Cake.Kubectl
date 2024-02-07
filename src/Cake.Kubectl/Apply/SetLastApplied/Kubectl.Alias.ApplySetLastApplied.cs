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
		/// Set the latest last-applied-configuration annotations by setting it to match the contents of a file. This results in the last-applied-configuration being updated as though 'kubectl apply -f&lt;file&gt; ' was run, without updating any other parts of the object.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlApplySetLastApplied(this ICakeContext context, KubectlApplySetLastAppliedSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlApplySetLastAppliedSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("apply set-last-applied", settings ?? new KubectlApplySetLastAppliedSettings(), arguments);
		}
		/// <summary>
		/// Set the latest last-applied-configuration annotations by setting it to match the contents of a file. This results in the last-applied-configuration being updated as though 'kubectl apply -f&lt;file&gt; ' was run, without updating any other parts of the object.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlApplySetLastAppliedWithResult(this ICakeContext context, KubectlApplySetLastAppliedSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlApplySetLastAppliedSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("apply set-last-applied", settings ?? new KubectlApplySetLastAppliedSettings(), arguments);
		}
	}
}
