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
		/// Print the logs for a container in a pod or specified resource. If the pod has only one container, the container name is optional.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesLogs(this ICakeContext context, KubernetesLogsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesLogsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("logs", settings ?? new KubernetesLogsSettings(), arguments);
		}
		/// <summary>
		/// Print the logs for a container in a pod or specified resource. If the pod has only one container, the container name is optional.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesLogsWithResult(this ICakeContext context, KubernetesLogsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesLogsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("logs", settings ?? new KubernetesLogsSettings(), arguments);
		}
	}
}
