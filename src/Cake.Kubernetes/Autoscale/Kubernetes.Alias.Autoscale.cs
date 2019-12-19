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
		/// Creates an autoscaler that automatically chooses and sets the number of pods that run in a kubernetes cluster.
		///
		/// 
		///  Looks up a Deployment, ReplicaSet, StatefulSet, or ReplicationController by name and creates an autoscaler that uses the given resource as a reference. An autoscaler can automatically increase or decrease number of pods deployed within the system as needed.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesAutoscale(this ICakeContext context, KubernetesAutoscaleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesAutoscaleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("autoscale", settings ?? new KubernetesAutoscaleSettings(), arguments);
		}
		/// <summary>
		/// Creates an autoscaler that automatically chooses and sets the number of pods that run in a kubernetes cluster.
		///
		/// 
		///  Looks up a Deployment, ReplicaSet, StatefulSet, or ReplicationController by name and creates an autoscaler that uses the given resource as a reference. An autoscaler can automatically increase or decrease number of pods deployed within the system as needed.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesAutoscaleWithResult(this ICakeContext context, KubernetesAutoscaleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesAutoscaleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("autoscale", settings ?? new KubernetesAutoscaleSettings(), arguments);
		}
	}
}
