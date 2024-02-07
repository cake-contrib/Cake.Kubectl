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
		/// Provides utilities for interacting with plugins.
		///
		/// 
		///  Plugins provide extended functionality that is not part of the major command-line distribution. Please refer to the documentation and examples for more information about how write your own plugins.
		/// 
		///  The easiest way to discover and install plugins is via the kubernetes sub-project krew. To install krew, visit https://krew.sigs.k8s.io/docs/user-guide/setup/install/ krew.sigs.k8s.io https://krew.sigs.k8s.io/docs/user-guide/setup/install/
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlPlugin(this ICakeContext context, KubectlPluginSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlPluginSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("plugin", settings ?? new KubectlPluginSettings(), arguments);
		}
		/// <summary>
		/// Provides utilities for interacting with plugins.
		///
		/// 
		///  Plugins provide extended functionality that is not part of the major command-line distribution. Please refer to the documentation and examples for more information about how write your own plugins.
		/// 
		///  The easiest way to discover and install plugins is via the kubernetes sub-project krew. To install krew, visit https://krew.sigs.k8s.io/docs/user-guide/setup/install/ krew.sigs.k8s.io https://krew.sigs.k8s.io/docs/user-guide/setup/install/
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlPluginWithResult(this ICakeContext context, KubectlPluginSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlPluginSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("plugin", settings ?? new KubectlPluginSettings(), arguments);
		}
	}
}
