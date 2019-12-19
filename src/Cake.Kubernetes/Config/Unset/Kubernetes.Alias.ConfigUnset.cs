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
		/// Unsets an individual value in a kubeconfig file
		///
		/// 
		///  PROPERTY_NAME is a dot delimited name where each token represents either an attribute name or a map key.  Map keys may not contain dots.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesConfigUnset(this ICakeContext context, KubernetesConfigUnsetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigUnsetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config unset", settings ?? new KubernetesConfigUnsetSettings(), arguments);
		}
		/// <summary>
		/// Unsets an individual value in a kubeconfig file
		///
		/// 
		///  PROPERTY_NAME is a dot delimited name where each token represents either an attribute name or a map key.  Map keys may not contain dots.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesConfigUnsetWithResult(this ICakeContext context, KubernetesConfigUnsetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigUnsetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config unset", settings ?? new KubernetesConfigUnsetSettings(), arguments);
		}
	}
}
