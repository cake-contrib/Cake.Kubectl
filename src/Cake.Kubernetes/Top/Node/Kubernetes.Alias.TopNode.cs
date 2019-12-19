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
		/// Display Resource (CPU/Memory/Storage) usage of nodes.
		///
		/// 
		///  The top-node command allows you to see the resource consumption of nodes.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesTopNode(this ICakeContext context, KubernetesTopNodeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesTopNodeSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("top node", settings ?? new KubernetesTopNodeSettings(), arguments);
		}
		/// <summary>
		/// Display Resource (CPU/Memory/Storage) usage of nodes.
		///
		/// 
		///  The top-node command allows you to see the resource consumption of nodes.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesTopNodeWithResult(this ICakeContext context, KubernetesTopNodeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesTopNodeSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("top node", settings ?? new KubernetesTopNodeSettings(), arguments);
		}
	}
}
