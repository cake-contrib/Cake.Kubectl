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
		/// Attach to a process that is already running inside an existing container.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlAttach(this ICakeContext context, KubectlAttachSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlAttachSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("attach", settings ?? new KubectlAttachSettings(), arguments);
		}
		/// <summary>
		/// Attach to a process that is already running inside an existing container.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlAttachWithResult(this ICakeContext context, KubectlAttachSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlAttachSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("attach", settings ?? new KubectlAttachSettings(), arguments);
		}
	}
}
