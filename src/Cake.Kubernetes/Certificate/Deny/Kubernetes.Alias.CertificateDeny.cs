using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	partial class KubernetesAliases
	{
		/// <summary>
		/// Deny a certificate signing request.
		///
		/// 
		///  kubectl certificate deny allows a cluster admin to deny a certificate signing request (CSR). This action tells a certificate signing controller to not to issue a certificate to the requestor.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCertificateDeny(this ICakeContext context, KubernetesCertificateDenySettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCertificateDenySettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("certificate deny", settings ?? new KubernetesCertificateDenySettings(), arguments);
		}
		/// <summary>
		/// Deny a certificate signing request.
		///
		/// 
		///  kubectl certificate deny allows a cluster admin to deny a certificate signing request (CSR). This action tells a certificate signing controller to not to issue a certificate to the requestor.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCertificateDenyWithResult(this ICakeContext context, KubernetesCertificateDenySettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCertificateDenySettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("certificate deny", settings ?? new KubernetesCertificateDenySettings(), arguments);
		}
	}
}
