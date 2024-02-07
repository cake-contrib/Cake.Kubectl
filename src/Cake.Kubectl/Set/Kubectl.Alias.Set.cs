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
		/// Configure application resources.
		///
		/// 
		///  These commands help you make changes to existing application resources.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlSet(this ICakeContext context, KubectlSetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlSetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("set", settings ?? new KubectlSetSettings(), arguments);
		}
		/// <summary>
		/// Configure application resources.
		///
		/// 
		///  These commands help you make changes to existing application resources.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlSetWithResult(this ICakeContext context, KubectlSetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlSetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("set", settings ?? new KubectlSetSettings(), arguments);
		}
	}
}
