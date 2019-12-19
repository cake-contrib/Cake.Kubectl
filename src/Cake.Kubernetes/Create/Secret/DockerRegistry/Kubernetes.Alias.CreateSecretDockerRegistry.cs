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
		/// Create a new secret for use with Docker registries.
		///
		/// 
		///   Dockercfg secrets are used to authenticate against Docker registries.
		/// 
		///   When using the Docker command line to push images, you can authenticate to a given registry by running:
		///       '$ docker login DOCKER_REGISTRY_SERVER --username=DOCKER_USER --password=DOCKER_PASSWORD --email=DOCKER_EMAIL'.
		/// 
		///  That produces a ~/.dockercfg file that is used by subsequent 'docker push' and 'docker pull' commands to authenticate to the registry. The email address is optional.
		/// 
		///   When creating applications, you may have a Docker registry that requires authentication.  In order for the
		///   nodes to pull images on your behalf, they have to have the credentials.  You can provide this information
		///   by creating a dockercfg secret and attaching it to your service account.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void KubernetesCreateSecretDockerRegistry(this ICakeContext context, KubernetesCreateSecretDockerRegistrySettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateSecretDockerRegistrySettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("create secret docker-registry", settings ?? new KubernetesCreateSecretDockerRegistrySettings(), arguments);
		}
		/// <summary>
		/// Create a new secret for use with Docker registries.
		///
		/// 
		///   Dockercfg secrets are used to authenticate against Docker registries.
		/// 
		///   When using the Docker command line to push images, you can authenticate to a given registry by running:
		///       '$ docker login DOCKER_REGISTRY_SERVER --username=DOCKER_USER --password=DOCKER_PASSWORD --email=DOCKER_EMAIL'.
		/// 
		///  That produces a ~/.dockercfg file that is used by subsequent 'docker push' and 'docker pull' commands to authenticate to the registry. The email address is optional.
		/// 
		///   When creating applications, you may have a Docker registry that requires authentication.  In order for the
		///   nodes to pull images on your behalf, they have to have the credentials.  You can provide this information
		///   by creating a dockercfg secret and attaching it to your service account.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> KubernetesCreateSecretDockerRegistryWithResult(this ICakeContext context, KubernetesCreateSecretDockerRegistrySettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}
			var arguments = new string[0];
			var runner = new GenericRunner<KubernetesCreateSecretDockerRegistrySettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return  runner.RunWithResult("create secret docker-registry", settings ?? new KubernetesCreateSecretDockerRegistrySettings(), arguments);
		}
	}
}
