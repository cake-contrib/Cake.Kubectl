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
		/// Set a user entry in kubeconfig.
		///
		/// 
		///  Specifying a name that already exists will merge new fields on top of existing values.
		/// 
		///   Client-certificate flags:
		///   --client-certificate=certfile --client-key=keyfile
		/// 
		///   Bearer token flags:
		///   --token=bearer_token
		/// 
		///   Basic auth flags:
		///   --username=basic_user --password=basic_password
		/// 
		///  Bearer token and basic auth are mutually exclusive.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlConfigSetCredentials(this ICakeContext context, KubectlConfigSetCredentialsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigSetCredentialsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("config set-credentials", settings ?? new KubectlConfigSetCredentialsSettings(), arguments);
		}
		/// <summary>
		/// Set a user entry in kubeconfig.
		///
		/// 
		///  Specifying a name that already exists will merge new fields on top of existing values.
		/// 
		///   Client-certificate flags:
		///   --client-certificate=certfile --client-key=keyfile
		/// 
		///   Bearer token flags:
		///   --token=bearer_token
		/// 
		///   Basic auth flags:
		///   --username=basic_user --password=basic_password
		/// 
		///  Bearer token and basic auth are mutually exclusive.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlConfigSetCredentialsWithResult(this ICakeContext context, KubectlConfigSetCredentialsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlConfigSetCredentialsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("config set-credentials", settings ?? new KubectlConfigSetCredentialsSettings(), arguments);
		}
	}
}
