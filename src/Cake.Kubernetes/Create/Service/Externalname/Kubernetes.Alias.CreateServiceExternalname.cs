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
		/// Create an ExternalName service with the specified name.
		///
		/// 
		///  ExternalName service references to an external DNS address instead of only pods, which will allow application authors to reference services that exist off platform, on other clusters, or locally.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreateServiceExternalname(this ICakeContext context, KubernetesCreateServiceExternalnameSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateServiceExternalnameSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create service externalname", settings ?? new KubernetesCreateServiceExternalnameSettings(), arguments);
		}
		/// <summary>
		/// Create an ExternalName service with the specified name.
		///
		/// 
		///  ExternalName service references to an external DNS address instead of only pods, which will allow application authors to reference services that exist off platform, on other clusters, or locally.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreateServiceExternalnameWithResult(this ICakeContext context, KubernetesCreateServiceExternalnameSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateServiceExternalnameSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create service externalname", settings ?? new KubernetesCreateServiceExternalnameSettings(), arguments);
		}
	}
}
