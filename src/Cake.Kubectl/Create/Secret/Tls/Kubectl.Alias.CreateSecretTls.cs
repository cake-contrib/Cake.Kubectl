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
		/// Create a TLS secret from the given public/private key pair.
		///
		/// 
		///  The public/private key pair must exist beforehand. The public key certificate must be .PEM encoded and match the given private key.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCreateSecretTls(this ICakeContext context, KubectlCreateSecretTlsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateSecretTlsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create secret tls", settings ?? new KubectlCreateSecretTlsSettings(), arguments);
		}
		/// <summary>
		/// Create a TLS secret from the given public/private key pair.
		///
		/// 
		///  The public/private key pair must exist beforehand. The public key certificate must be .PEM encoded and match the given private key.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCreateSecretTlsWithResult(this ICakeContext context, KubectlCreateSecretTlsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateSecretTlsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create secret tls", settings ?? new KubectlCreateSecretTlsSettings(), arguments);
		}
	}
}
