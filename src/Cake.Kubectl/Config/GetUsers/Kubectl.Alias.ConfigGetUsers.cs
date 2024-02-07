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
		/// Display users defined in the kubeconfig.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlConfigGetUsers(this ICakeContext context, KubectlConfigGetUsersSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigGetUsersSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config get-users", settings ?? new KubectlConfigGetUsersSettings(), arguments);
		}
		/// <summary>
		/// Display users defined in the kubeconfig.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlConfigGetUsersWithResult(this ICakeContext context, KubectlConfigGetUsersSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigGetUsersSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config get-users", settings ?? new KubectlConfigGetUsersSettings(), arguments);
		}
	}
}
