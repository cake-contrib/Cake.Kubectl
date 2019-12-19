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
		/// Update ServiceAccount of pod template resources.
		///
		/// 
		///  Possible resources (case insensitive) can be:
		/// 
		///  replicationcontroller (rc), deployment (deploy), daemonset (ds), job, replicaset (rs), statefulset
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesSetServiceaccount(this ICakeContext context, KubernetesSetServiceaccountSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesSetServiceaccountSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("set serviceaccount", settings ?? new KubernetesSetServiceaccountSettings(), arguments);
		}
		/// <summary>
		/// Update ServiceAccount of pod template resources.
		///
		/// 
		///  Possible resources (case insensitive) can be:
		/// 
		///  replicationcontroller (rc), deployment (deploy), daemonset (ds), job, replicaset (rs), statefulset
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesSetServiceaccountWithResult(this ICakeContext context, KubernetesSetServiceaccountSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesSetServiceaccountSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("set serviceaccount", settings ?? new KubernetesSetServiceaccountSettings(), arguments);
		}
	}
}
