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
		/// Create a RoleBinding for a particular Role or ClusterRole.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreateRolebinding(this ICakeContext context, KubernetesCreateRolebindingSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateRolebindingSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create rolebinding", settings ?? new KubernetesCreateRolebindingSettings(), arguments);
		}
		/// <summary>
		/// Create a RoleBinding for a particular Role or ClusterRole.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreateRolebindingWithResult(this ICakeContext context, KubernetesCreateRolebindingSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateRolebindingSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create rolebinding", settings ?? new KubernetesCreateRolebindingSettings(), arguments);
		}
	}
}
