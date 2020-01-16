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
		/// Update field(s) of a resource using strategic merge patch, a JSON merge patch, or a JSON patch.
		///
		/// 
		///  JSON and YAML formats are accepted.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlPatch(this ICakeContext context, KubectlPatchSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlPatchSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("patch", settings ?? new KubectlPatchSettings(), arguments);
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
		public static IEnumerable<string> KubectlPatchWithResult(this ICakeContext context, KubectlPatchSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlPatchSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("patch", settings ?? new KubectlPatchSettings(), arguments);
		}
	}
}
