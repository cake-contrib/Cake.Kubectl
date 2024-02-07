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
		/// Display the current-context.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlConfigCurrentContext(this ICakeContext context, KubectlConfigCurrentContextSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigCurrentContextSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config current-context", settings ?? new KubectlConfigCurrentContextSettings(), arguments);
		}
		/// <summary>
		/// Display the current-context.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlConfigCurrentContextWithResult(this ICakeContext context, KubectlConfigCurrentContextSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigCurrentContextSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config current-context", settings ?? new KubectlConfigCurrentContextSettings(), arguments);
		}
	}
}
