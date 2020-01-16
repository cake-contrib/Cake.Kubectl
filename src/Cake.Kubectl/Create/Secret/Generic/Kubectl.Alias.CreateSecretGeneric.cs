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
		/// Create a secret based on a file, directory, or specified literal value.
		///
		/// 
		///  A single secret may package one or more key/value pairs.
		/// 
		///  When creating a secret based on a file, the key will default to the basename of the file, and the value will default to the file content. If the basename is an invalid key or you wish to chose your own, you may specify an alternate key.
		/// 
		///  When creating a secret based on a directory, each file whose basename is a valid key in the directory will be packaged into the secret. Any directory entries except regular files are ignored (e.g. subdirectories, symlinks, devices, pipes, etc).
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCreateSecretGeneric(this ICakeContext context, KubectlCreateSecretGenericSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateSecretGenericSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create secret generic", settings ?? new KubectlCreateSecretGenericSettings(), arguments);
		}
		/// <summary>
		/// Create a secret based on a file, directory, or specified literal value.
		///
		/// 
		///  A single secret may package one or more key/value pairs.
		/// 
		///  When creating a secret based on a file, the key will default to the basename of the file, and the value will default to the file content. If the basename is an invalid key or you wish to chose your own, you may specify an alternate key.
		/// 
		///  When creating a secret based on a directory, each file whose basename is a valid key in the directory will be packaged into the secret. Any directory entries except regular files are ignored (e.g. subdirectories, symlinks, devices, pipes, etc).
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCreateSecretGenericWithResult(this ICakeContext context, KubectlCreateSecretGenericSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateSecretGenericSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create secret generic", settings ?? new KubectlCreateSecretGenericSettings(), arguments);
		}
	}
}
