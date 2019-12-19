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
		/// Create a role with single rule.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreateRole(this ICakeContext context, KubernetesCreateRoleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateRoleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create role", settings ?? new KubernetesCreateRoleSettings(), arguments);
		}
		/// <summary>
		/// Create a role with single rule.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreateRoleWithResult(this ICakeContext context, KubernetesCreateRoleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateRoleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create role", settings ?? new KubernetesCreateRoleSettings(), arguments);
		}
	}
}
