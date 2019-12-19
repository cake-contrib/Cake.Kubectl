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
		/// Print the supported API resources on the server
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesApiResources(this ICakeContext context, KubernetesApiResourcesSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesApiResourcesSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("api-resources", settings ?? new KubernetesApiResourcesSettings(), arguments);
		}
		/// <summary>
		/// Print the supported API resources on the server
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesApiResourcesWithResult(this ICakeContext context, KubernetesApiResourcesSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesApiResourcesSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("api-resources", settings ?? new KubernetesApiResourcesSettings(), arguments);
		}
	}
}
