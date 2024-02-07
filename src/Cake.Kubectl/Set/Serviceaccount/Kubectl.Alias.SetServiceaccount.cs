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
		/// Update the service account of pod template resources.
		///
		/// 
		///  Possible resources (case insensitive) can be:
		/// 
		///  replicationcontroller (rc), deployment (deploy), daemonset (ds), job, replicaset (rs), statefulset
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlSetServiceaccount(this ICakeContext context, KubectlSetServiceaccountSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlSetServiceaccountSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("set serviceaccount", settings ?? new KubectlSetServiceaccountSettings(), arguments);
		}
		/// <summary>
		/// Update the service account of pod template resources.
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
		public static IEnumerable<string> KubectlSetServiceaccountWithResult(this ICakeContext context, KubectlSetServiceaccountSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlSetServiceaccountSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("set serviceaccount", settings ?? new KubectlSetServiceaccountSettings(), arguments);
		}
	}
}
