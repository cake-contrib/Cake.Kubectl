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
		/// Configure application resources
		///
		/// 
		///  These commands help you make changes to existing application resources.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesSet(this ICakeContext context, KubernetesSetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesSetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("set", settings ?? new KubernetesSetSettings(), arguments);
		}
		/// <summary>
		/// Configure application resources
		///
		/// 
		///  These commands help you make changes to existing application resources.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesSetWithResult(this ICakeContext context, KubernetesSetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesSetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("set", settings ?? new KubernetesSetSettings(), arguments);
		}
	}
}
