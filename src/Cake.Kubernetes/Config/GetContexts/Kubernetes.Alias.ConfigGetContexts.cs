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
		/// Displays one or many contexts from the kubeconfig file.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesConfigGetContexts(this ICakeContext context, KubernetesConfigGetContextsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigGetContextsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config get-contexts", settings ?? new KubernetesConfigGetContextsSettings(), arguments);
		}
		/// <summary>
		/// Displays one or many contexts from the kubeconfig file.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesConfigGetContextsWithResult(this ICakeContext context, KubernetesConfigGetContextsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigGetContextsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config get-contexts", settings ?? new KubernetesConfigGetContextsSettings(), arguments);
		}
	}
}
