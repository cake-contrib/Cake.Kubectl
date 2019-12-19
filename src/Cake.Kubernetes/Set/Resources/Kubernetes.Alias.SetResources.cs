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
		/// Specify compute resource requirements (cpu, memory) for any resource that defines a pod template.  If a pod is successfully scheduled, it is guaranteed the amount of resource requested, but may burst up to its specified limits.
		///
		/// 
		///  for each compute resource, if a limit is specified and a request is omitted, the request will default to the limit.
		/// 
		///  Possible resources include (case insensitive): Use "kubectl api-resources" for a complete list of supported resources..
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesSetResources(this ICakeContext context, KubernetesSetResourcesSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesSetResourcesSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("set resources", settings ?? new KubernetesSetResourcesSettings(), arguments);
		}
		/// <summary>
		/// Specify compute resource requirements (cpu, memory) for any resource that defines a pod template.  If a pod is successfully scheduled, it is guaranteed the amount of resource requested, but may burst up to its specified limits.
		///
		/// 
		///  for each compute resource, if a limit is specified and a request is omitted, the request will default to the limit.
		/// 
		///  Possible resources include (case insensitive): Use "kubectl api-resources" for a complete list of supported resources..
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesSetResourcesWithResult(this ICakeContext context, KubernetesSetResourcesSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesSetResourcesSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("set resources", settings ?? new KubernetesSetResourcesSettings(), arguments);
		}
	}
}
