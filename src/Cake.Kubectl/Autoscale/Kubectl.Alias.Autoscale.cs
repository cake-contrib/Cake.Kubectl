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
		/// Creates an autoscaler that automatically chooses and sets the number of pods that run in a Kubernetes cluster.
		///
		/// 
		///  Looks up a deployment, replica set, stateful set, or replication controller by name and creates an autoscaler that uses the given resource as a reference. An autoscaler can automatically increase or decrease number of pods deployed within the system as needed.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlAutoscale(this ICakeContext context, KubectlAutoscaleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlAutoscaleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("autoscale", settings ?? new KubectlAutoscaleSettings(), arguments);
		}
		/// <summary>
		/// Creates an autoscaler that automatically chooses and sets the number of pods that run in a Kubernetes cluster.
		///
		/// 
		///  Looks up a deployment, replica set, stateful set, or replication controller by name and creates an autoscaler that uses the given resource as a reference. An autoscaler can automatically increase or decrease number of pods deployed within the system as needed.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlAutoscaleWithResult(this ICakeContext context, KubectlAutoscaleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlAutoscaleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("autoscale", settings ?? new KubectlAutoscaleSettings(), arguments);
		}
	}
}
