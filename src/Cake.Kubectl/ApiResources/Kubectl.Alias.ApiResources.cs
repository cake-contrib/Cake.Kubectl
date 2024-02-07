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
		/// Print the supported API resources on the server.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlApiResources(this ICakeContext context, KubectlApiResourcesSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlApiResourcesSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("api-resources", settings ?? new KubectlApiResourcesSettings(), arguments);
		}
		/// <summary>
		/// Print the supported API resources on the server.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlApiResourcesWithResult(this ICakeContext context, KubectlApiResourcesSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlApiResourcesSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("api-resources", settings ?? new KubectlApiResourcesSettings(), arguments);
		}
	}
}
