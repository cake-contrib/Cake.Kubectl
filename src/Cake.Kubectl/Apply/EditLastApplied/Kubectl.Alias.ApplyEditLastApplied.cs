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
		/// Edit the latest last-applied-configuration annotations of resources from the default editor.
		///
		/// 
		///  The edit-last-applied command allows you to directly edit any API resource you can retrieve via the command line tools. It will open the editor defined by your KUBE_EDITOR, or EDITOR environment variables, or fall back to 'vi' for Linux or 'notepad' for Windows. You can edit multiple objects, although changes are applied one at a time. The command accepts filenames as well as command line arguments, although the files you point to must be previously saved versions of resources.
		/// 
		///  The default format is YAML. To edit in JSON, specify "-o json".
		/// 
		///  The flag --windows-line-endings can be used to force Windows line endings, otherwise the default for your operating system will be used.
		/// 
		///  In the event an error occurs while updating, a temporary file will be created on disk that contains your unapplied changes. The most common error when updating a resource is another editor changing the resource on the server. When this occurs, you will have to apply your changes to the newer version of the resource, or update your temporary saved copy to include the latest resource version.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlApplyEditLastApplied(this ICakeContext context, KubectlApplyEditLastAppliedSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlApplyEditLastAppliedSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("apply edit-last-applied", settings ?? new KubectlApplyEditLastAppliedSettings(), arguments);
		}
		/// <summary>
		/// Edit the latest last-applied-configuration annotations of resources from the default editor.
		///
		/// 
		///  The edit-last-applied command allows you to directly edit any API resource you can retrieve via the command line tools. It will open the editor defined by your KUBE_EDITOR, or EDITOR environment variables, or fall back to 'vi' for Linux or 'notepad' for Windows. You can edit multiple objects, although changes are applied one at a time. The command accepts filenames as well as command line arguments, although the files you point to must be previously saved versions of resources.
		/// 
		///  The default format is YAML. To edit in JSON, specify "-o json".
		/// 
		///  The flag --windows-line-endings can be used to force Windows line endings, otherwise the default for your operating system will be used.
		/// 
		///  In the event an error occurs while updating, a temporary file will be created on disk that contains your unapplied changes. The most common error when updating a resource is another editor changing the resource on the server. When this occurs, you will have to apply your changes to the newer version of the resource, or update your temporary saved copy to include the latest resource version.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlApplyEditLastAppliedWithResult(this ICakeContext context, KubectlApplyEditLastAppliedSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlApplyEditLastAppliedSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("apply edit-last-applied", settings ?? new KubectlApplyEditLastAppliedSettings(), arguments);
		}
	}
}
