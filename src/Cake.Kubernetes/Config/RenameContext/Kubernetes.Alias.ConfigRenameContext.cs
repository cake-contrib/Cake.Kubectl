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
		/// Renames a context from the kubeconfig file.
		///
		/// 
		///  CONTEXT_NAME is the context name that you wish change.
		/// 
		///  NEW_NAME is the new name you wish to set.
		/// 
		///  Note: In case the context being renamed is the 'current-context', this field will also be updated.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesConfigRenameContext(this ICakeContext context, KubernetesConfigRenameContextSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigRenameContextSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config rename-context", settings ?? new KubernetesConfigRenameContextSettings(), arguments);
		}
		/// <summary>
		/// Renames a context from the kubeconfig file.
		///
		/// 
		///  CONTEXT_NAME is the context name that you wish change.
		/// 
		///  NEW_NAME is the new name you wish to set.
		/// 
		///  Note: In case the context being renamed is the 'current-context', this field will also be updated.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesConfigRenameContextWithResult(this ICakeContext context, KubernetesConfigRenameContextSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigRenameContextSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config rename-context", settings ?? new KubernetesConfigRenameContextSettings(), arguments);
		}
	}
}
