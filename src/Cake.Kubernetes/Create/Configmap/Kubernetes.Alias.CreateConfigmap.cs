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
		/// Create a configmap based on a file, directory, or specified literal value.
		///
		/// 
		///  A single configmap may package one or more key/value pairs.
		/// 
		///  When creating a configmap based on a file, the key will default to the basename of the file, and the value will default to the file content.  If the basename is an invalid key, you may specify an alternate key.
		/// 
		///  When creating a configmap based on a directory, each file whose basename is a valid key in the directory will be packaged into the configmap.  Any directory entries except regular files are ignored (e.g. subdirectories, symlinks, devices, pipes, etc).
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreateConfigmap(this ICakeContext context, KubernetesCreateConfigmapSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateConfigmapSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create configmap", settings ?? new KubernetesCreateConfigmapSettings(), arguments);
		}
		/// <summary>
		/// Create a configmap based on a file, directory, or specified literal value.
		///
		/// 
		///  A single configmap may package one or more key/value pairs.
		/// 
		///  When creating a configmap based on a file, the key will default to the basename of the file, and the value will default to the file content.  If the basename is an invalid key, you may specify an alternate key.
		/// 
		///  When creating a configmap based on a directory, each file whose basename is a valid key in the directory will be packaged into the configmap.  Any directory entries except regular files are ignored (e.g. subdirectories, symlinks, devices, pipes, etc).
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreateConfigmapWithResult(this ICakeContext context, KubernetesCreateConfigmapSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateConfigmapSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create configmap", settings ?? new KubernetesCreateConfigmapSettings(), arguments);
		}
	}
}
