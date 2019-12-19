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
		/// Execute a command in a container.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesExec(this ICakeContext context, KubernetesExecSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesExecSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("exec", settings ?? new KubernetesExecSettings(), arguments);
		}
		/// <summary>
		/// Execute a command in a container.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesExecWithResult(this ICakeContext context, KubernetesExecSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesExecSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("exec", settings ?? new KubernetesExecSettings(), arguments);
		}
	}
}
