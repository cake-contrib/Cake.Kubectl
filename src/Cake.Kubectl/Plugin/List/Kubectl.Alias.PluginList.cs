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
		/// List all available plugin files on a user's PATH.
		///
		/// 
		///  Available plugin files are those that are: - executable - anywhere on the user's PATH - begin with "kubectl-"
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlPluginList(this ICakeContext context, KubectlPluginListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlPluginListSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("plugin list", settings ?? new KubectlPluginListSettings(), arguments);
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
		public static IEnumerable<string> KubectlPluginListWithResult(this ICakeContext context, KubectlPluginListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlPluginListSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("plugin list", settings ?? new KubectlPluginListSettings(), arguments);
		}
	}
}
