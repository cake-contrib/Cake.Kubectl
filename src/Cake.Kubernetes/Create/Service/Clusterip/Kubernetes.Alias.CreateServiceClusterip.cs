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
		/// Create a ClusterIP service with the specified name.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreateServiceClusterip(this ICakeContext context, KubernetesCreateServiceClusteripSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateServiceClusteripSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create service clusterip", settings ?? new KubernetesCreateServiceClusteripSettings(), arguments);
		}
		/// <summary>
		/// Create a ClusterIP service with the specified name.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreateServiceClusteripWithResult(this ICakeContext context, KubernetesCreateServiceClusteripSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateServiceClusteripSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create service clusterip", settings ?? new KubernetesCreateServiceClusteripSettings(), arguments);
		}
	}
}
