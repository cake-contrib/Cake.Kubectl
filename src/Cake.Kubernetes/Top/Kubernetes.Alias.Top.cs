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
		/// Display Resource (CPU/Memory/Storage) usage.
		///
		/// 
		///  The top command allows you to see the resource consumption for nodes or pods.
		/// 
		///  This command requires Heapster to be correctly configured and working on the server.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesTop(this ICakeContext context, KubernetesTopSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesTopSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("top", settings ?? new KubernetesTopSettings(), arguments);
		}
		/// <summary>
		/// Display Resource (CPU/Memory/Storage) usage.
		///
		/// 
		///  The top command allows you to see the resource consumption for nodes or pods.
		/// 
		///  This command requires Heapster to be correctly configured and working on the server.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesTopWithResult(this ICakeContext context, KubernetesTopSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesTopSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("top", settings ?? new KubernetesTopSettings(), arguments);
		}
	}
}
