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
		/// Experimental: Check who you are and your attributes (groups, extra).
		///
		/// 
		///   This command is helpful to get yourself aware of the current user attributes,
		///   especially when dynamic authentication, e.g., token webhook, auth proxy, or OIDC provider,
		///   is enabled in the Kubernetes cluster.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlAuthWhoami(this ICakeContext context, KubectlAuthWhoamiSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlAuthWhoamiSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("auth whoami", settings ?? new KubectlAuthWhoamiSettings(), arguments);
		}
		/// <summary>
		/// Experimental: Check who you are and your attributes (groups, extra).
		///
		/// 
		///   This command is helpful to get yourself aware of the current user attributes,
		///   especially when dynamic authentication, e.g., token webhook, auth proxy, or OIDC provider,
		///   is enabled in the Kubernetes cluster.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlAuthWhoamiWithResult(this ICakeContext context, KubectlAuthWhoamiSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlAuthWhoamiSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("auth whoami", settings ?? new KubectlAuthWhoamiSettings(), arguments);
		}
	}
}
