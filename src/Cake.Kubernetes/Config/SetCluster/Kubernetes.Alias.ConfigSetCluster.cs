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
		/// Sets a cluster entry in kubeconfig.
		///
		/// 
		///  Specifying a name that already exists will merge new fields on top of existing values for those fields.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesConfigSetCluster(this ICakeContext context, KubernetesConfigSetClusterSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigSetClusterSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config set-cluster", settings ?? new KubernetesConfigSetClusterSettings(), arguments);
		}
		/// <summary>
		/// Sets a cluster entry in kubeconfig.
		///
		/// 
		///  Specifying a name that already exists will merge new fields on top of existing values for those fields.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesConfigSetClusterWithResult(this ICakeContext context, KubernetesConfigSetClusterSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigSetClusterSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config set-cluster", settings ?? new KubernetesConfigSetClusterSettings(), arguments);
		}
	}
}
