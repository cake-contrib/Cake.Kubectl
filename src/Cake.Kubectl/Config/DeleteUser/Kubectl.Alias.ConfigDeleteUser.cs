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
		/// Delete the specified user from the kubeconfig.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlConfigDeleteUser(this ICakeContext context, KubectlConfigDeleteUserSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigDeleteUserSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config delete-user", settings ?? new KubectlConfigDeleteUserSettings(), arguments);
		}
		/// <summary>
		/// Delete the specified user from the kubeconfig.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlConfigDeleteUserWithResult(this ICakeContext context, KubectlConfigDeleteUserSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigDeleteUserSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config delete-user", settings ?? new KubectlConfigDeleteUserSettings(), arguments);
		}
	}
}
