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
		/// Update the taints on one or more nodes.
		///
		/// 
		///   *  A taint consists of a key, value, and effect. As an argument here, it is expressed as key=value:effect.
		///   *  The key must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  253 characters.
		///   *  Optionally, the key can begin with a DNS subdomain prefix and a single '/', like example.com/my-app
		///   *  The value must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  63 characters.
		///   *  The effect must be NoSchedule, PreferNoSchedule or NoExecute.
		///   *  Currently taint can only apply to node.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesTaint(this ICakeContext context, KubernetesTaintSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesTaintSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("taint", settings ?? new KubernetesTaintSettings(), arguments);
		}
		/// <summary>
		/// Update the taints on one or more nodes.
		///
		/// 
		///   *  A taint consists of a key, value, and effect. As an argument here, it is expressed as key=value:effect.
		///   *  The key must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  253 characters.
		///   *  Optionally, the key can begin with a DNS subdomain prefix and a single '/', like example.com/my-app
		///   *  The value must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  63 characters.
		///   *  The effect must be NoSchedule, PreferNoSchedule or NoExecute.
		///   *  Currently taint can only apply to node.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesTaintWithResult(this ICakeContext context, KubernetesTaintSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesTaintSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("taint", settings ?? new KubernetesTaintSettings(), arguments);
		}
	}
}
