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
		/// Check whether an action is allowed.
		///
		/// 
		///  VERB is a logical Kubernetes API verb like 'get', 'list', 'watch', 'delete', etc. TYPE is a Kubernetes resource. Shortcuts and groups will be resolved. NONRESOURCEURL is a partial URL starts with "/". NAME is the name of a particular Kubernetes resource.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesAuthCanI(this ICakeContext context, KubernetesAuthCanISettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesAuthCanISettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("auth can-i", settings ?? new KubernetesAuthCanISettings(), arguments);
		}
		/// <summary>
		/// Check whether an action is allowed.
		///
		/// 
		///  VERB is a logical Kubernetes API verb like 'get', 'list', 'watch', 'delete', etc. TYPE is a Kubernetes resource. Shortcuts and groups will be resolved. NONRESOURCEURL is a partial URL starts with "/". NAME is the name of a particular Kubernetes resource.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesAuthCanIWithResult(this ICakeContext context, KubernetesAuthCanISettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesAuthCanISettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("auth can-i", settings ?? new KubernetesAuthCanISettings(), arguments);
		}
	}
}
