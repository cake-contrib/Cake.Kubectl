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
		/// Renames a context from the kubeconfig file.
		///
		/// 
		///  CONTEXT_NAME is the context name that you want to change.
		/// 
		///  NEW_NAME is the new name you want to set.
		/// 
		///  Note: If the context being renamed is the 'current-context', this field will also be updated.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlConfigRenameContext(this ICakeContext context, KubectlConfigRenameContextSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigRenameContextSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config rename-context", settings ?? new KubectlConfigRenameContextSettings(), arguments);
		}
		/// <summary>
		/// Renames a context from the kubeconfig file.
		///
		/// 
		///  CONTEXT_NAME is the context name that you want to change.
		/// 
		///  NEW_NAME is the new name you want to set.
		/// 
		///  Note: If the context being renamed is the 'current-context', this field will also be updated.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlConfigRenameContextWithResult(this ICakeContext context, KubectlConfigRenameContextSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigRenameContextSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config rename-context", settings ?? new KubectlConfigRenameContextSettings(), arguments);
		}
	}
}
