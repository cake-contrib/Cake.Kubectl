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
		/// Output shell completion code for the specified shell (bash or zsh). The shell code must be evaluated to provide interactive completion of kubectl commands.  This can be done by sourcing it from the .bash_profile.
		///
		/// 
		///  Detailed instructions on how to do this are available here: https://kubernetes.io/docs/tasks/tools/install-kubectl/#enabling-shell-autocompletion
		/// 
		///  Note for zsh users: [1] zsh completions are only supported in versions of zsh >= 5.2
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCompletion(this ICakeContext context, KubernetesCompletionSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCompletionSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("completion", settings ?? new KubernetesCompletionSettings(), arguments);
		}
		/// <summary>
		/// Output shell completion code for the specified shell (bash or zsh). The shell code must be evaluated to provide interactive completion of kubectl commands.  This can be done by sourcing it from the .bash_profile.
		///
		/// 
		///  Detailed instructions on how to do this are available here: https://kubernetes.io/docs/tasks/tools/install-kubectl/#enabling-shell-autocompletion
		/// 
		///  Note for zsh users: [1] zsh completions are only supported in versions of zsh >= 5.2
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCompletionWithResult(this ICakeContext context, KubernetesCompletionSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCompletionSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("completion", settings ?? new KubernetesCompletionSettings(), arguments);
		}
	}
}
