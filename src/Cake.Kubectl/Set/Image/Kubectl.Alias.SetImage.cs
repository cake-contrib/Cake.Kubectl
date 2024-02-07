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
		/// Update existing container image(s) of resources.
		///
		/// 
		///  Possible resources include (case insensitive):
		/// 
		///   pod (po), replicationcontroller (rc), deployment (deploy), daemonset (ds), statefulset (sts), cronjob (cj), replicaset (rs)
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlSetImage(this ICakeContext context, KubectlSetImageSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlSetImageSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("set image", settings ?? new KubectlSetImageSettings(), arguments);
		}
		/// <summary>
		/// Update existing container image(s) of resources.
		///
		/// 
		///  Possible resources include (case insensitive):
		/// 
		///   pod (po), replicationcontroller (rc), deployment (deploy), daemonset (ds), statefulset (sts), cronjob (cj), replicaset (rs)
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlSetImageWithResult(this ICakeContext context, KubectlSetImageSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlSetImageSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("set image", settings ?? new KubectlSetImageSettings(), arguments);
		}
	}
}
