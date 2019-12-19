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
		/// Diff configurations specified by filename or stdin between the current online configuration, and the configuration as it would be if applied.
		///
		/// 
		///  Output is always YAML.
		/// 
		///  KUBECTL_EXTERNAL_DIFF environment variable can be used to select your own diff command. By default, the "diff" command available in your path will be run with "-u" (unicode) and "-N" (treat new files as empty) options.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesDiff(this ICakeContext context, KubernetesDiffSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesDiffSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("diff", settings ?? new KubernetesDiffSettings(), arguments);
		}
		/// <summary>
		/// Diff configurations specified by filename or stdin between the current online configuration, and the configuration as it would be if applied.
		///
		/// 
		///  Output is always YAML.
		/// 
		///  KUBECTL_EXTERNAL_DIFF environment variable can be used to select your own diff command. By default, the "diff" command available in your path will be run with "-u" (unicode) and "-N" (treat new files as empty) options.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesDiffWithResult(this ICakeContext context, KubernetesDiffSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesDiffSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("diff", settings ?? new KubernetesDiffSettings(), arguments);
		}
	}
}
