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
		/// Display merged kubeconfig settings or a specified kubeconfig file.
		///
		/// 
		///  You can use --output jsonpath={...} to extract specific values using a jsonpath expression.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesConfigView(this ICakeContext context, KubernetesConfigViewSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigViewSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config view", settings ?? new KubernetesConfigViewSettings(), arguments);
		}
		/// <summary>
		/// Display merged kubeconfig settings or a specified kubeconfig file.
		///
		/// 
		///  You can use --output jsonpath={...} to extract specific values using a jsonpath expression.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesConfigViewWithResult(this ICakeContext context, KubernetesConfigViewSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigViewSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config view", settings ?? new KubernetesConfigViewSettings(), arguments);
		}
	}
}
