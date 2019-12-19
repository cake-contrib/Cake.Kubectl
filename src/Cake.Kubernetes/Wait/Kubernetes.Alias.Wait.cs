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
		/// Experimental: Wait for a specific condition on one or many resources.
		///
		/// 
		///  The command takes multiple resources and waits until the specified condition is seen in the Status field of every given resource.
		/// 
		///  Alternatively, the command can wait for the given set of resources to be deleted by providing the "delete" keyword as the value to the --for flag.
		/// 
		///  A successful message will be printed to stdout indicating when the specified condition has been met. One can use -o option to change to output destination.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesWait(this ICakeContext context, KubernetesWaitSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesWaitSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("wait", settings ?? new KubernetesWaitSettings(), arguments);
		}
		/// <summary>
		/// Experimental: Wait for a specific condition on one or many resources.
		///
		/// 
		///  The command takes multiple resources and waits until the specified condition is seen in the Status field of every given resource.
		/// 
		///  Alternatively, the command can wait for the given set of resources to be deleted by providing the "delete" keyword as the value to the --for flag.
		/// 
		///  A successful message will be printed to stdout indicating when the specified condition has been met. One can use -o option to change to output destination.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesWaitWithResult(this ICakeContext context, KubernetesWaitSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesWaitSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("wait", settings ?? new KubernetesWaitSettings(), arguments);
		}
	}
}
