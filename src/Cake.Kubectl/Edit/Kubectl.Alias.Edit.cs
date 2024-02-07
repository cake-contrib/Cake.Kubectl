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
		/// Edit a resource from the default editor.
		///
		/// 
		///  The edit command allows you to directly edit any API resource you can retrieve via the command-line tools. It will open the editor defined by your KUBE_EDITOR, or EDITOR environment variables, or fall back to 'vi' for Linux or 'notepad' for Windows. You can edit multiple objects, although changes are applied one at a time. The command accepts file names as well as command-line arguments, although the files you point to must be previously saved versions of resources.
		/// 
		///  Editing is done with the API version used to fetch the resource. To edit using a specific API version, fully-qualify the resource, version, and group.
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
		public static void KubectlEdit(this ICakeContext context, KubectlEditSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlEditSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("edit", settings ?? new KubectlEditSettings(), arguments);
		}
		/// <summary>
		/// Edit a resource from the default editor.
		///
		/// 
		///  The edit command allows you to directly edit any API resource you can retrieve via the command-line tools. It will open the editor defined by your KUBE_EDITOR, or EDITOR environment variables, or fall back to 'vi' for Linux or 'notepad' for Windows. You can edit multiple objects, although changes are applied one at a time. The command accepts file names as well as command-line arguments, although the files you point to must be previously saved versions of resources.
		/// 
		///  Editing is done with the API version used to fetch the resource. To edit using a specific API version, fully-qualify the resource, version, and group.
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
		public static IEnumerable<string> KubectlEditWithResult(this ICakeContext context, KubectlEditSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlEditSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("edit", settings ?? new KubectlEditSettings(), arguments);
		}
	}
}
