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
		/// Create a deployment with the specified name.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCreateDeployment(this ICakeContext context, KubectlCreateDeploymentSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateDeploymentSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create deployment", settings ?? new KubectlCreateDeploymentSettings(), arguments);
		}
		/// <summary>
		/// Create a deployment with the specified name.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCreateDeploymentWithResult(this ICakeContext context, KubectlCreateDeploymentSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateDeploymentSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create deployment", settings ?? new KubectlCreateDeploymentSettings(), arguments);
		}
	}
}
