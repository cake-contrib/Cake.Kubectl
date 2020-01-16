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
		/// Check whether an action is allowed.
		///
		/// 
		///  VERB is a logical Kubectl API verb like 'get', 'list', 'watch', 'delete', etc. TYPE is a Kubectl resource. Shortcuts and groups will be resolved. NONRESOURCEURL is a partial URL starts with "/". NAME is the name of a particular Kubectl resource.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlAuthCanI(this ICakeContext context, KubectlAuthCanISettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlAuthCanISettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("auth can-i", settings ?? new KubectlAuthCanISettings(), arguments);
		}
		/// <summary>
		/// Check whether an action is allowed.
		///
		/// 
		///  VERB is a logical Kubectl API verb like 'get', 'list', 'watch', 'delete', etc. TYPE is a Kubectl resource. Shortcuts and groups will be resolved. NONRESOURCEURL is a partial URL starts with "/". NAME is the name of a particular Kubectl resource.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlAuthCanIWithResult(this ICakeContext context, KubectlAuthCanISettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlAuthCanISettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("auth can-i", settings ?? new KubectlAuthCanISettings(), arguments);
		}
	}
}
