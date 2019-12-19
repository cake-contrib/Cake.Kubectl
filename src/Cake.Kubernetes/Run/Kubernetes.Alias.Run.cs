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
		/// Create and run a particular image, possibly replicated.
		///
		/// 
		///  Creates a deployment or job to manage the created container(s).
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesRun(this ICakeContext context, KubernetesRunSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesRunSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("run", settings ?? new KubernetesRunSettings(), arguments);
		}
		/// <summary>
		/// Create and run a particular image, possibly replicated.
		///
		/// 
		///  Creates a deployment or job to manage the created container(s).
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesRunWithResult(this ICakeContext context, KubernetesRunSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesRunSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("run", settings ?? new KubernetesRunSettings(), arguments);
		}
	}
}
