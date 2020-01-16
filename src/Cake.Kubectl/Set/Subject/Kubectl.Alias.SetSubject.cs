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
		/// Update User, Group or ServiceAccount in a RoleBinding/ClusterRoleBinding.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlSetSubject(this ICakeContext context, KubectlSetSubjectSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlSetSubjectSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("set subject", settings ?? new KubectlSetSubjectSettings(), arguments);
		}
		/// <summary>
		/// Update User, Group or ServiceAccount in a RoleBinding/ClusterRoleBinding.
		///
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlSetSubjectWithResult(this ICakeContext context, KubectlSetSubjectSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlSetSubjectSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("set subject", settings ?? new KubectlSetSubjectSettings(), arguments);
		}
	}
}
