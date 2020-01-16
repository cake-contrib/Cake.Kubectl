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
		/// Print the logs for a container in a pod or specified resource. If the pod has only one container, the container name is optional.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlLogs(this ICakeContext context, KubectlLogsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlLogsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("logs", settings ?? new KubectlLogsSettings(), arguments);
		}
		/// <summary>
		/// Print the logs for a container in a pod or specified resource. If the pod has only one container, the container name is optional.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlLogsWithResult(this ICakeContext context, KubectlLogsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlLogsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("logs", settings ?? new KubectlLogsSettings(), arguments);
		}
	}
}
