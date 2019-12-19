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
		/// Sets a context entry in kubeconfig
		///
		/// 
		///  Specifying a name that already exists will merge new fields on top of existing values for those fields.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesConfigSetContext(this ICakeContext context, KubernetesConfigSetContextSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigSetContextSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config set-context", settings ?? new KubernetesConfigSetContextSettings(), arguments);
		}
		/// <summary>
		/// Sets a context entry in kubeconfig
		///
		/// 
		///  Specifying a name that already exists will merge new fields on top of existing values for those fields.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesConfigSetContextWithResult(this ICakeContext context, KubernetesConfigSetContextSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigSetContextSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config set-context", settings ?? new KubernetesConfigSetContextSettings(), arguments);
		}
	}
}
