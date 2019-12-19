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
		/// List the fields for supported resources
		///
		/// 
		///  This command describes the fields associated with each supported API resource. Fields are identified via a simple JSONPath identifier:
		/// 
		///   <type>.<fieldName>[.<fieldName>]
		/// 
		///  Add the --recursive flag to display all of the fields at once without descriptions. Information about each field is retrieved from the server in OpenAPI format.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesExplain(this ICakeContext context, KubernetesExplainSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesExplainSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("explain", settings ?? new KubernetesExplainSettings(), arguments);
		}
		/// <summary>
		/// List the fields for supported resources
		///
		/// 
		///  This command describes the fields associated with each supported API resource. Fields are identified via a simple JSONPath identifier:
		/// 
		///   <type>.<fieldName>[.<fieldName>]
		/// 
		///  Add the --recursive flag to display all of the fields at once without descriptions. Information about each field is retrieved from the server in OpenAPI format.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesExplainWithResult(this ICakeContext context, KubernetesExplainSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesExplainSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("explain", settings ?? new KubernetesExplainSettings(), arguments);
		}
	}
}
