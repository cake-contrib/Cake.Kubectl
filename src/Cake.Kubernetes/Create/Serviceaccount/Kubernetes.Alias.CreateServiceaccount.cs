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
		/// Create a service account with the specified name.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreateServiceaccount(this ICakeContext context, KubernetesCreateServiceaccountSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateServiceaccountSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create serviceaccount", settings ?? new KubernetesCreateServiceaccountSettings(), arguments);
		}
		/// <summary>
		/// Create a service account with the specified name.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreateServiceaccountWithResult(this ICakeContext context, KubernetesCreateServiceaccountSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateServiceaccountSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create serviceaccount", settings ?? new KubernetesCreateServiceaccountSettings(), arguments);
		}
	}
}
