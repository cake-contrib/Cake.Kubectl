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
		/// Show details of a specific resource or group of resources
		///
		/// 
		///  Print a detailed description of the selected resources, including related resources such as events or controllers. You may select a single object by name, all objects of that type, provide a name prefix, or label selector. For example:
		/// 
		///   $ kubectl describe TYPE NAME_PREFIX
		/// 
		///  will first check for an exact match on TYPE and NAME_PREFIX. If no such resource exists, it will output details for every resource that has a name prefixed with NAME_PREFIX.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesDescribe(this ICakeContext context, KubernetesDescribeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesDescribeSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("describe", settings ?? new KubernetesDescribeSettings(), arguments);
		}
		/// <summary>
		/// Show details of a specific resource or group of resources
		///
		/// 
		///  Print a detailed description of the selected resources, including related resources such as events or controllers. You may select a single object by name, all objects of that type, provide a name prefix, or label selector. For example:
		/// 
		///   $ kubectl describe TYPE NAME_PREFIX
		/// 
		///  will first check for an exact match on TYPE and NAME_PREFIX. If no such resource exists, it will output details for every resource that has a name prefixed with NAME_PREFIX.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesDescribeWithResult(this ICakeContext context, KubernetesDescribeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesDescribeSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("describe", settings ?? new KubernetesDescribeSettings(), arguments);
		}
	}
}
