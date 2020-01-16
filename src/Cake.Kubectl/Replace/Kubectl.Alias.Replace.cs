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
		/// Replace a resource by filename or stdin.
		///
		/// 
		///  JSON and YAML formats are accepted. If replacing an existing resource, the complete resource spec must be provided. This can be obtained by
		/// 
		///   $ kubectl get TYPE NAME -o yaml
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlReplace(this ICakeContext context, KubectlReplaceSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlReplaceSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("replace", settings ?? new KubectlReplaceSettings(), arguments);
		}
		/// <summary>
		/// Replace a resource by filename or stdin.
		///
		/// 
		///  JSON and YAML formats are accepted. If replacing an existing resource, the complete resource spec must be provided. This can be obtained by
		/// 
		///   $ kubectl get TYPE NAME -o yaml
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlReplaceWithResult(this ICakeContext context, KubectlReplaceSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlReplaceSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("replace", settings ?? new KubectlReplaceSettings(), arguments);
		}
	}
}
