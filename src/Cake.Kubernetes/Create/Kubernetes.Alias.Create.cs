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
		/// Create a resource from a file or from stdin.
		///
		/// 
		///  JSON and YAML formats are accepted.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreate(this ICakeContext context, KubernetesCreateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create", settings ?? new KubernetesCreateSettings(), arguments);
		}
		/// <summary>
		/// Create a resource from a file or from stdin.
		///
		/// 
		///  JSON and YAML formats are accepted.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreateWithResult(this ICakeContext context, KubernetesCreateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create", settings ?? new KubernetesCreateSettings(), arguments);
		}
	}
}
