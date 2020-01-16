using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Creates an autoscaler that automatically chooses and sets the number of pods that run in a kubernetes cluster.
	///
	/// 
	///  Looks up a Deployment, ReplicaSet, StatefulSet, or ReplicationController by name and creates an autoscaler that uses the given resource as a reference. An autoscaler can automatically increase or decrease number of pods deployed within the system as needed.
	/// </summary>
	/// <example>
	///   # Auto scale a deployment "foo", with the number of pods between 2 and 10, no target CPU utilization specified so a default autoscaling policy will be used:
	///   kubectl autoscale deployment foo --min=2 --max=10
	/// 
	///   # Auto scale a replication controller "foo", with the number of pods between 1 and 5, target CPU utilization at 80%:
	///   kubectl autoscale rc foo --max=5 --cpu-percent=80
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlAutoscaleSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --cpu-percent
		///
		/// The target average CPU utilization (represented as a percent of requested CPU) over all the pods. If it's not specified or negative, a default autoscaling policy will be used.
		/// </summary>
		public int? CpuPercent { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files identifying the resource to autoscale.
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// --generator
		///
		/// The name of the API generator to use. Currently there is only 1 generator.
		/// </summary>
		public string Generator { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// --max
		///
		/// The upper limit for the number of pods that can be set by the autoscaler. Required.
		/// </summary>
		public int? Max { get; set; }
		/// <summary>
		/// --min
		///
		/// The lower limit for the number of pods that can be set by the autoscaler. If it's not specified or negative, the server will apply a default value.
		/// </summary>
		public int? Min { get; set; }
		/// <summary>
		/// --name
		///
		/// The name for the newly created object. If not specified, the name of the input resource will be used.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --record
		///
		/// Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.
		/// </summary>
		public bool? Record { get; set; }
		/// <summary>
		/// -R, --recursive
		///
		/// Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.
		/// </summary>
		public bool? Recursive { get; set; }
		/// <summary>
		/// --save-config
		///
		/// If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.
		/// </summary>
		public bool? SaveConfig { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
	}
}
