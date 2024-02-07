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
		/// Display Resource (CPU/Memory) usage.
		///
		/// 
		///  The top command allows you to see the resource consumption for nodes or pods.
		/// 
		///  This command requires Metrics Server to be correctly configured and working on the server.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlTop(this ICakeContext context, KubectlTopSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlTopSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("top", settings ?? new KubectlTopSettings(), arguments);
		}
		/// <summary>
		/// Display Resource (CPU/Memory) usage.
		///
		/// 
		///  The top command allows you to see the resource consumption for nodes or pods.
		/// 
		///  This command requires Metrics Server to be correctly configured and working on the server.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlTopWithResult(this ICakeContext context, KubectlTopSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlTopSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("top", settings ?? new KubectlTopSettings(), arguments);
		}
	}
}
