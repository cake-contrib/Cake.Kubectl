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
		/// Expose a resource as a new Kubernetes service.
		///
		/// 
		///  Looks up a deployment, service, replica set, replication controller or pod by name and uses the selector for that resource as the selector for a new service on the specified port. A deployment or replica set will be exposed as a service only if its selector is convertible to a selector that service supports, i.e. when the selector contains only the matchLabels component. Note that if no port is specified via --port and the exposed resource has multiple ports, all will be re-used by the new service. Also if no labels are specified, the new service will re-use the labels from the resource it exposes.
		/// 
		///  Possible resources include (case insensitive):
		/// 
		///  pod (po), service (svc), replicationcontroller (rc), deployment (deploy), replicaset (rs)
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlExpose(this ICakeContext context, KubectlExposeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlExposeSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("expose", settings ?? new KubectlExposeSettings(), arguments);
		}
		/// <summary>
		/// Expose a resource as a new Kubernetes service.
		///
		/// 
		///  Looks up a deployment, service, replica set, replication controller or pod by name and uses the selector for that resource as the selector for a new service on the specified port. A deployment or replica set will be exposed as a service only if its selector is convertible to a selector that service supports, i.e. when the selector contains only the matchLabels component. Note that if no port is specified via --port and the exposed resource has multiple ports, all will be re-used by the new service. Also if no labels are specified, the new service will re-use the labels from the resource it exposes.
		/// 
		///  Possible resources include (case insensitive):
		/// 
		///  pod (po), service (svc), replicationcontroller (rc), deployment (deploy), replicaset (rs)
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlExposeWithResult(this ICakeContext context, KubectlExposeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlExposeSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("expose", settings ?? new KubectlExposeSettings(), arguments);
		}
	}
}
