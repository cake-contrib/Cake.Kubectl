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
		/// Create a service using a specified subcommand.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCreateService(this ICakeContext context, KubectlCreateServiceSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateServiceSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create service", settings ?? new KubectlCreateServiceSettings(), arguments);
		}
		/// <summary>
		/// Create a service using a specified subcommand.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCreateServiceWithResult(this ICakeContext context, KubectlCreateServiceSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateServiceSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create service", settings ?? new KubectlCreateServiceSettings(), arguments);
		}
	}
}
