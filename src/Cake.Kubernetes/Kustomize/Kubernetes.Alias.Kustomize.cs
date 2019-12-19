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
		/// Print a set of API resources generated from instructions in a kustomization.yaml file.
		///
		/// 
		///  The argument must be the path to the directory containing the file, or a git repository URL with a path suffix specifying same with respect to the repository root.
		/// 
		///  kubectl kustomize somedir
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesKustomize(this ICakeContext context, KubernetesKustomizeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesKustomizeSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("kustomize", settings ?? new KubernetesKustomizeSettings(), arguments);
		}
		/// <summary>
		/// Print a set of API resources generated from instructions in a kustomization.yaml file.
		///
		/// 
		///  The argument must be the path to the directory containing the file, or a git repository URL with a path suffix specifying same with respect to the repository root.
		/// 
		///  kubectl kustomize somedir
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesKustomizeWithResult(this ICakeContext context, KubernetesKustomizeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesKustomizeSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("kustomize", settings ?? new KubernetesKustomizeSettings(), arguments);
		}
	}
}
