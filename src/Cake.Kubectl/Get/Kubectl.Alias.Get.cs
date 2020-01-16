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
		/// Display one or many resources
		///
		/// 
		///  Prints a table of the most important information about the specified resources. You can filter the list using a label selector and the --selector flag. If the desired resource type is namespaced you will only see results in your current namespace unless you pass --all-namespaces.
		/// 
		///  Uninitialized objects are not shown unless --include-uninitialized is passed.
		/// 
		///  By specifying the output as 'template' and providing a Go template as the value of the --template flag, you can filter the attributes of the fetched resources.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubectlGet(this ICakeContext context, KubectlGetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlGetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("get", settings ?? new KubectlGetSettings(), arguments);
		}
		/// <summary>
		/// Display one or many resources
		///
		/// 
		///  Prints a table of the most important information about the specified resources. You can filter the list using a label selector and the --selector flag. If the desired resource type is namespaced you will only see results in your current namespace unless you pass --all-namespaces.
		/// 
		///  Uninitialized objects are not shown unless --include-uninitialized is passed.
		/// 
		///  By specifying the output as 'template' and providing a Go template as the value of the --template flag, you can filter the attributes of the fetched resources.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubectlGetWithResult(this ICakeContext context, KubectlGetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubectlGetSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("get", settings ?? new KubectlGetSettings(), arguments);
		}
	}
}
