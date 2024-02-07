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
		/// Create a config map based on a file, directory, or specified literal value.
		///
		/// 
		///  A single config map may package one or more key/value pairs.
		/// 
		///  When creating a config map based on a file, the key will default to the basename of the file, and the value will default to the file content.  If the basename is an invalid key, you may specify an alternate key.
		/// 
		///  When creating a config map based on a directory, each file whose basename is a valid key in the directory will be packaged into the config map.  Any directory entries except regular files are ignored (e.g. subdirectories, symlinks, devices, pipes, etc).
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCreateConfigmap(this ICakeContext context, KubectlCreateConfigmapSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateConfigmapSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create configmap", settings ?? new KubectlCreateConfigmapSettings(), arguments);
		}
		/// <summary>
		/// Create a config map based on a file, directory, or specified literal value.
		///
		/// 
		///  A single config map may package one or more key/value pairs.
		/// 
		///  When creating a config map based on a file, the key will default to the basename of the file, and the value will default to the file content.  If the basename is an invalid key, you may specify an alternate key.
		/// 
		///  When creating a config map based on a directory, each file whose basename is a valid key in the directory will be packaged into the config map.  Any directory entries except regular files are ignored (e.g. subdirectories, symlinks, devices, pipes, etc).
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCreateConfigmapWithResult(this ICakeContext context, KubectlCreateConfigmapSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateConfigmapSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create configmap", settings ?? new KubectlCreateConfigmapSettings(), arguments);
		}
	}
}
