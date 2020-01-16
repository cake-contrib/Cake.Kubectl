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
		/// Create a priorityclass with the specified name, value, globalDefault and description
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCreatePriorityclass(this ICakeContext context, KubectlCreatePriorityclassSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreatePriorityclassSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create priorityclass", settings ?? new KubectlCreatePriorityclassSettings(), arguments);
		}
		/// <summary>
		/// Create a priorityclass with the specified name, value, globalDefault and description
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCreatePriorityclassWithResult(this ICakeContext context, KubectlCreatePriorityclassSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreatePriorityclassSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create priorityclass", settings ?? new KubectlCreatePriorityclassSettings(), arguments);
		}
	}
}
