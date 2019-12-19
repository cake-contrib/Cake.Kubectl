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
		/// Sets the current-context in a kubeconfig file
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesConfigUseContext(this ICakeContext context, KubernetesConfigUseContextSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigUseContextSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config use-context", settings ?? new KubernetesConfigUseContextSettings(), arguments);
		}
		/// <summary>
		/// Sets the current-context in a kubeconfig file
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesConfigUseContextWithResult(this ICakeContext context, KubernetesConfigUseContextSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigUseContextSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config use-context", settings ?? new KubernetesConfigUseContextSettings(), arguments);
		}
	}
}
