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
		/// Forward one or more local ports to a pod. This command requires the node to have 'socat' installed.
		///
		/// 
		///  Use resource type/name such as deployment/mydeployment to select a pod. Resource type defaults to 'pod' if omitted.
		/// 
		///  If there are multiple pods matching the criteria, a pod will be selected automatically. The forwarding session ends when the selected pod terminates, and rerun of the command is needed to resume forwarding.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesPortForward(this ICakeContext context, KubernetesPortForwardSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesPortForwardSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("port-forward", settings ?? new KubernetesPortForwardSettings(), arguments);
		}
		/// <summary>
		/// Forward one or more local ports to a pod. This command requires the node to have 'socat' installed.
		///
		/// 
		///  Use resource type/name such as deployment/mydeployment to select a pod. Resource type defaults to 'pod' if omitted.
		/// 
		///  If there are multiple pods matching the criteria, a pod will be selected automatically. The forwarding session ends when the selected pod terminates, and rerun of the command is needed to resume forwarding.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesPortForwardWithResult(this ICakeContext context, KubernetesPortForwardSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesPortForwardSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("port-forward", settings ?? new KubernetesPortForwardSettings(), arguments);
		}
	}
}
