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
		/// Update environment variables on a pod template.
		///
		/// 
		///  List environment variable definitions in one or more pods, pod templates. Add, update, or remove container environment variable definitions in one or more pod templates (within replication controllers or deployment configurations). View or modify the environment variable definitions on all containers in the specified pods or pod templates, or just those that match a wildcard.
		/// 
		///  If "--env -" is passed, environment variables can be read from STDIN using the standard env syntax.
		/// 
		///  Possible resources include (case insensitive):
		/// 
		///   pod (po), replicationcontroller (rc), deployment (deploy), daemonset (ds), job, replicaset (rs)
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesSetEnv(this ICakeContext context, KubernetesSetEnvSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesSetEnvSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("set env", settings ?? new KubernetesSetEnvSettings(), arguments);
		}
		/// <summary>
		/// Update environment variables on a pod template.
		///
		/// 
		///  List environment variable definitions in one or more pods, pod templates. Add, update, or remove container environment variable definitions in one or more pod templates (within replication controllers or deployment configurations). View or modify the environment variable definitions on all containers in the specified pods or pod templates, or just those that match a wildcard.
		/// 
		///  If "--env -" is passed, environment variables can be read from STDIN using the standard env syntax.
		/// 
		///  Possible resources include (case insensitive):
		/// 
		///   pod (po), replicationcontroller (rc), deployment (deploy), daemonset (ds), job, replicaset (rs)
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesSetEnvWithResult(this ICakeContext context, KubernetesSetEnvSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesSetEnvSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("set env", settings ?? new KubernetesSetEnvSettings(), arguments);
		}
	}
}
