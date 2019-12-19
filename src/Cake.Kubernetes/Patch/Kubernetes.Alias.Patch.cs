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
		/// Update field(s) of a resource using strategic merge patch, a JSON merge patch, or a JSON patch.
		///
		/// 
		///  JSON and YAML formats are accepted.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesPatch(this ICakeContext context, KubernetesPatchSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesPatchSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("patch", settings ?? new KubernetesPatchSettings(), arguments);
		}
		/// <summary>
		/// Update field(s) of a resource using strategic merge patch, a JSON merge patch, or a JSON patch.
		///
		/// 
		///  JSON and YAML formats are accepted.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesPatchWithResult(this ICakeContext context, KubernetesPatchSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesPatchSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("patch", settings ?? new KubernetesPatchSettings(), arguments);
		}
	}
}
