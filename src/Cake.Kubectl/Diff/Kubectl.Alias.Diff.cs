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
		/// Diff configurations specified by file name or stdin between the current online configuration, and the configuration as it would be if applied.
		///
		/// 
		///  The output is always YAML.
		/// 
		///  KUBECTL_EXTERNAL_DIFF environment variable can be used to select your own diff command. Users can use external commands with params too, example: KUBECTL_EXTERNAL_DIFF="colordiff -N -u"
		/// 
		///  By default, the "diff" command available in your path will be run with the "-u" (unified diff) and "-N" (treat absent files as empty) options.
		/// 
		///  Exit status: 0 No differences were found. 1 Differences were found. &gt;1 Kubectl or diff failed with an error.
		/// 
		///  Note: KUBECTL_EXTERNAL_DIFF, if used, is expected to follow that convention.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlDiff(this ICakeContext context, KubectlDiffSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlDiffSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("diff", settings ?? new KubectlDiffSettings(), arguments);
		}
		/// <summary>
		/// Diff configurations specified by file name or stdin between the current online configuration, and the configuration as it would be if applied.
		///
		/// 
		///  The output is always YAML.
		/// 
		///  KUBECTL_EXTERNAL_DIFF environment variable can be used to select your own diff command. Users can use external commands with params too, example: KUBECTL_EXTERNAL_DIFF="colordiff -N -u"
		/// 
		///  By default, the "diff" command available in your path will be run with the "-u" (unified diff) and "-N" (treat absent files as empty) options.
		/// 
		///  Exit status: 0 No differences were found. 1 Differences were found. &gt;1 Kubectl or diff failed with an error.
		/// 
		///  Note: KUBECTL_EXTERNAL_DIFF, if used, is expected to follow that convention.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlDiffWithResult(this ICakeContext context, KubectlDiffSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlDiffSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("diff", settings ?? new KubectlDiffSettings(), arguments);
		}
	}
}
