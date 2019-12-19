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
		/// Set a new size for a Deployment, ReplicaSet, Replication Controller, or StatefulSet.
		///
		/// 
		///  Scale also allows users to specify one or more preconditions for the scale action.
		/// 
		///  If --current-replicas or --resource-version is specified, it is validated before the scale is attempted, and it is guaranteed that the precondition holds true when the scale is sent to the server.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesScale(this ICakeContext context, KubernetesScaleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesScaleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("scale", settings ?? new KubernetesScaleSettings(), arguments);
		}
		/// <summary>
		/// Set a new size for a Deployment, ReplicaSet, Replication Controller, or StatefulSet.
		///
		/// 
		///  Scale also allows users to specify one or more preconditions for the scale action.
		/// 
		///  If --current-replicas or --resource-version is specified, it is validated before the scale is attempted, and it is guaranteed that the precondition holds true when the scale is sent to the server.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesScaleWithResult(this ICakeContext context, KubernetesScaleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesScaleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("scale", settings ?? new KubernetesScaleSettings(), arguments);
		}
	}
}
