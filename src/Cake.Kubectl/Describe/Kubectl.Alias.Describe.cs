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
		/// Show details of a specific resource or group of resources.
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
		public static void KubectlDescribe(this ICakeContext context, KubectlDescribeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlDescribeSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("describe", settings ?? new KubectlDescribeSettings(), arguments);
		}
		/// <summary>
		/// Show details of a specific resource or group of resources.
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
		public static IEnumerable<string> KubectlDescribeWithResult(this ICakeContext context, KubectlDescribeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlDescribeSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("describe", settings ?? new KubectlDescribeSettings(), arguments);
		}
	}
}
