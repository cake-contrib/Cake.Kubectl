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
		/// Output shell completion code for the specified shell (bash, zsh, fish, or powershell). The shell code must be evaluated to provide interactive completion of kubectl commands.  This can be done by sourcing it from the .bash_profile.
		///
		/// 
		///  Detailed instructions on how to do this are available here:
		/// 
		///   for macOS:
		///   https://kubernetes.io/docs/tasks/tools/install-kubectl-macos/#enable-shell-autocompletion
		/// 
		///   for linux:
		///   https://kubernetes.io/docs/tasks/tools/install-kubectl-linux/#enable-shell-autocompletion
		/// 
		///   for windows:
		///   https://kubernetes.io/docs/tasks/tools/install-kubectl-windows/#enable-shell-autocompletion
		/// 
		///  Note for zsh users: [1] zsh completions are only supported in versions of zsh &gt;= 5.2.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCompletion(this ICakeContext context, KubectlCompletionSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCompletionSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("completion", settings ?? new KubectlCompletionSettings(), arguments);
		}
		/// <summary>
		/// Output shell completion code for the specified shell (bash, zsh, fish, or powershell). The shell code must be evaluated to provide interactive completion of kubectl commands.  This can be done by sourcing it from the .bash_profile.
		///
		/// 
		///  Detailed instructions on how to do this are available here:
		/// 
		///   for macOS:
		///   https://kubernetes.io/docs/tasks/tools/install-kubectl-macos/#enable-shell-autocompletion
		/// 
		///   for linux:
		///   https://kubernetes.io/docs/tasks/tools/install-kubectl-linux/#enable-shell-autocompletion
		/// 
		///   for windows:
		///   https://kubernetes.io/docs/tasks/tools/install-kubectl-windows/#enable-shell-autocompletion
		/// 
		///  Note for zsh users: [1] zsh completions are only supported in versions of zsh &gt;= 5.2.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCompletionWithResult(this ICakeContext context, KubectlCompletionSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCompletionSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("completion", settings ?? new KubectlCompletionSettings(), arguments);
		}
	}
}
