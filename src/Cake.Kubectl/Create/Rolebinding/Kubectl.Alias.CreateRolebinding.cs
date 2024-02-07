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
		/// Create a role binding for a particular role or cluster role.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlCreateRolebinding(this ICakeContext context, KubectlCreateRolebindingSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateRolebindingSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create rolebinding", settings ?? new KubectlCreateRolebindingSettings(), arguments);
		}
		/// <summary>
		/// Create a role binding for a particular role or cluster role.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlCreateRolebindingWithResult(this ICakeContext context, KubectlCreateRolebindingSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlCreateRolebindingSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create rolebinding", settings ?? new KubectlCreateRolebindingSettings(), arguments);
		}
	}
}
