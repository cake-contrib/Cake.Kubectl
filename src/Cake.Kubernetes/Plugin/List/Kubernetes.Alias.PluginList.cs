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
		/// List all available plugin files on a user's PATH.
		///
		/// 
		///  Available plugin files are those that are: - executable - anywhere on the user's PATH - begin with "kubectl-"
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesPluginList(this ICakeContext context, KubernetesPluginListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesPluginListSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("plugin list", settings ?? new KubernetesPluginListSettings(), arguments);
		}
		/// <summary>
		/// List all available plugin files on a user's PATH.
		///
		/// 
		///  Available plugin files are those that are: - executable - anywhere on the user's PATH - begin with "kubectl-"
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesPluginListWithResult(this ICakeContext context, KubernetesPluginListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesPluginListSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("plugin list", settings ?? new KubernetesPluginListSettings(), arguments);
		}
	}
}
