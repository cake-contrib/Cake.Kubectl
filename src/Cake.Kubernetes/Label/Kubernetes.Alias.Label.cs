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
		/// Update the labels on a resource.
		///
		/// 
		///   *  A label key and value must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  63 characters each.
		///   *  Optionally, the key can begin with a DNS subdomain prefix and a single '/', like example.com/my-app
		///   *  If --overwrite is true, then existing labels can be overwritten, otherwise attempting to overwrite a label will result in an error.
		///   *  If --resource-version is specified, then updates will use this resource version, otherwise the existing resource-version will be used.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesLabel(this ICakeContext context, KubernetesLabelSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesLabelSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("label", settings ?? new KubernetesLabelSettings(), arguments);
		}
		/// <summary>
		/// Update the labels on a resource.
		///
		/// 
		///   *  A label key and value must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  63 characters each.
		///   *  Optionally, the key can begin with a DNS subdomain prefix and a single '/', like example.com/my-app
		///   *  If --overwrite is true, then existing labels can be overwritten, otherwise attempting to overwrite a label will result in an error.
		///   *  If --resource-version is specified, then updates will use this resource version, otherwise the existing resource-version will be used.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesLabelWithResult(this ICakeContext context, KubernetesLabelSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesLabelSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("label", settings ?? new KubernetesLabelSettings(), arguments);
		}
	}
}
