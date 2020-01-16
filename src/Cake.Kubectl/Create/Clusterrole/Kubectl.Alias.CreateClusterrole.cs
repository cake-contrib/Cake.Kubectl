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
		/// Create a ClusterRole.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCreateClusterrole(this ICakeContext context, KubectlCreateClusterroleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateClusterroleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create clusterrole", settings ?? new KubectlCreateClusterroleSettings(), arguments);
		}
		/// <summary>
		/// Create a ClusterRole.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCreateClusterroleWithResult(this ICakeContext context, KubectlCreateClusterroleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateClusterroleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create clusterrole", settings ?? new KubectlCreateClusterroleSettings(), arguments);
		}
	}
}
