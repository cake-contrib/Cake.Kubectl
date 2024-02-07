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
		/// Print the supported API versions on the server, in the form of "group/version".
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlApiVersions(this ICakeContext context, KubectlApiVersionsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlApiVersionsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("api-versions", settings ?? new KubectlApiVersionsSettings(), arguments);
		}
		/// <summary>
		/// Print the supported API versions on the server, in the form of "group/version".
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlApiVersionsWithResult(this ICakeContext context, KubectlApiVersionsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlApiVersionsSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("api-versions", settings ?? new KubectlApiVersionsSettings(), arguments);
		}
	}
}
