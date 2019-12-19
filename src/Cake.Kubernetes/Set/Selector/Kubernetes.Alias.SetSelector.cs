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
		/// Set the selector on a resource. Note that the new selector will overwrite the old selector if the resource had one prior to the invocation of 'set selector'.
		///
		/// 
		///  A selector must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  63 characters. If --resource-version is specified, then updates will use this resource version, otherwise the existing resource-version will be used. Note: currently selectors can only be set on Service objects.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesSetSelector(this ICakeContext context, KubernetesSetSelectorSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesSetSelectorSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("set selector", settings ?? new KubernetesSetSelectorSettings(), arguments);
		}
		/// <summary>
		/// Set the selector on a resource. Note that the new selector will overwrite the old selector if the resource had one prior to the invocation of 'set selector'.
		///
		/// 
		///  A selector must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  63 characters. If --resource-version is specified, then updates will use this resource version, otherwise the existing resource-version will be used. Note: currently selectors can only be set on Service objects.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesSetSelectorWithResult(this ICakeContext context, KubernetesSetSelectorSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesSetSelectorSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("set selector", settings ?? new KubernetesSetSelectorSettings(), arguments);
		}
	}
}
