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
		/// Sets an individual value in a kubeconfig file
		///
		/// 
		///  PROPERTY_NAME is a dot delimited name where each token represents either an attribute name or a map key.  Map keys may not contain dots.
		/// 
		///  PROPERTY_VALUE is the new value you wish to set. Binary fields such as 'certificate-authority-data' expect a base64 encoded string unless the --set-raw-bytes flag is used.
		/// 
		///  Specifying a attribute name that already exists will merge new fields on top of existing values.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesConfigSet(this ICakeContext context, KubernetesConfigSetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigSetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config set", settings ?? new KubernetesConfigSetSettings(), arguments);
		}
		/// <summary>
		/// Sets an individual value in a kubeconfig file
		///
		/// 
		///  PROPERTY_NAME is a dot delimited name where each token represents either an attribute name or a map key.  Map keys may not contain dots.
		/// 
		///  PROPERTY_VALUE is the new value you wish to set. Binary fields such as 'certificate-authority-data' expect a base64 encoded string unless the --set-raw-bytes flag is used.
		/// 
		///  Specifying a attribute name that already exists will merge new fields on top of existing values.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesConfigSetWithResult(this ICakeContext context, KubernetesConfigSetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConfigSetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config set", settings ?? new KubernetesConfigSetSettings(), arguments);
		}
	}
}
