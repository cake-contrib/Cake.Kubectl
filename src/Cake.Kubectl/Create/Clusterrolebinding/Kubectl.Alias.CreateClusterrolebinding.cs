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
		/// Create a cluster role binding for a particular cluster role.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCreateClusterrolebinding(this ICakeContext context, KubectlCreateClusterrolebindingSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateClusterrolebindingSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create clusterrolebinding", settings ?? new KubectlCreateClusterrolebindingSettings(), arguments);
		}
		/// <summary>
		/// Create a cluster role binding for a particular cluster role.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCreateClusterrolebindingWithResult(this ICakeContext context, KubectlCreateClusterrolebindingSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateClusterrolebindingSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create clusterrolebinding", settings ?? new KubectlCreateClusterrolebindingSettings(), arguments);
		}
	}
}
