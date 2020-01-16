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
		/// Reconciles rules for RBAC Role, RoleBinding, ClusterRole, and ClusterRole binding objects.
		///
		/// 
		///  Missing objects are created, and the containing namespace is created for namespaced objects, if required.
		/// 
		///  Existing roles are updated to include the permissions in the input objects, and remove extra permissions if --remove-extra-permissions is specified.
		/// 
		///  Existing bindings are updated to include the subjects in the input objects, and remove extra subjects if --remove-extra-subjects is specified.
		/// 
		///  This is preferred to 'apply' for RBAC resources so that semantically-aware merging of rules and subjects is done.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlAuthReconcile(this ICakeContext context, KubectlAuthReconcileSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlAuthReconcileSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("auth reconcile", settings ?? new KubectlAuthReconcileSettings(), arguments);
		}
		/// <summary>
		/// Reconciles rules for RBAC Role, RoleBinding, ClusterRole, and ClusterRole binding objects.
		///
		/// 
		///  Missing objects are created, and the containing namespace is created for namespaced objects, if required.
		/// 
		///  Existing roles are updated to include the permissions in the input objects, and remove extra permissions if --remove-extra-permissions is specified.
		/// 
		///  Existing bindings are updated to include the subjects in the input objects, and remove extra subjects if --remove-extra-subjects is specified.
		/// 
		///  This is preferred to 'apply' for RBAC resources so that semantically-aware merging of rules and subjects is done.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlAuthReconcileWithResult(this ICakeContext context, KubectlAuthReconcileSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlAuthReconcileSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("auth reconcile", settings ?? new KubectlAuthReconcileSettings(), arguments);
		}
	}
}
