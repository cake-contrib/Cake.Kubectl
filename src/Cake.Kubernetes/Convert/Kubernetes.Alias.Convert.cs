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
		/// Convert config files between different API versions. Both YAML and JSON formats are accepted.
		///
		/// 
		///  The command takes filename, directory, or URL as input, and convert it into format of version specified by --output-version flag. If target version is not specified or not supported, convert to latest version.
		/// 
		///  The default output will be printed to stdout in YAML format. One can use -o option to change to output destination.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesConvert(this ICakeContext context, KubernetesConvertSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConvertSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("convert", settings ?? new KubernetesConvertSettings(), arguments);
		}
		/// <summary>
		/// Convert config files between different API versions. Both YAML and JSON formats are accepted.
		///
		/// 
		///  The command takes filename, directory, or URL as input, and convert it into format of version specified by --output-version flag. If target version is not specified or not supported, convert to latest version.
		/// 
		///  The default output will be printed to stdout in YAML format. One can use -o option to change to output destination.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesConvertWithResult(this ICakeContext context, KubernetesConvertSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesConvertSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("convert", settings ?? new KubernetesConvertSettings(), arguments);
		}
	}
}
