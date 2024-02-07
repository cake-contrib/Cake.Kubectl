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
		/// Display one or many contexts from the kubeconfig file.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlConfigGetContexts(this ICakeContext context, KubectlConfigGetContextsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigGetContextsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config get-contexts", settings ?? new KubectlConfigGetContextsSettings(), arguments);
		}
		/// <summary>
		/// Display one or many contexts from the kubeconfig file.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlConfigGetContextsWithResult(this ICakeContext context, KubectlConfigGetContextsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigGetContextsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config get-contexts", settings ?? new KubectlConfigGetContextsSettings(), arguments);
		}
	}
}
