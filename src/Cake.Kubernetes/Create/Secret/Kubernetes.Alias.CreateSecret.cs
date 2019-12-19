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
		/// Create a secret using specified subcommand.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreateSecret(this ICakeContext context, KubernetesCreateSecretSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateSecretSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create secret", settings ?? new KubernetesCreateSecretSettings(), arguments);
		}
		/// <summary>
		/// Create a secret using specified subcommand.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreateSecretWithResult(this ICakeContext context, KubernetesCreateSecretSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateSecretSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create secret", settings ?? new KubernetesCreateSecretSettings(), arguments);
		}
	}
}
