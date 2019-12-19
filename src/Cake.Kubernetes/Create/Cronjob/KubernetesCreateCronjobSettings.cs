using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Create a cronjob with the specified name.
	///
	/// </summary>
	/// <example>
	///   # Create a cronjob
	///   kubectl create cronjob my-job --image=busybox
	/// 
	///   # Create a cronjob with command
	///   kubectl create cronjob my-job --image=busybox -- date
	/// 
	///   # Create a cronjob with schedule
	///   kubectl create cronjob test-job --image=busybox --schedule="*/1 * * * *"
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesCreateCronjobSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// --image
		///
		/// Image name to run.
		/// </summary>
		public string Image { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --restart
		///
		/// job's restart policy. supported values: OnFailure, Never
		/// </summary>
		public string Restart { get; set; }
		/// <summary>
		/// --save-config
		///
		/// If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.
		/// </summary>
		public bool? SaveConfig { get; set; }
		/// <summary>
		/// --schedule
		///
		/// A schedule in the Cron format the job should be run with.
		/// </summary>
		public string Schedule { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string Template { get; set; }
		/// <summary>
		/// --validate
		///
		/// If true, use a schema to validate the input before sending it
		/// </summary>
		public bool? Validate { get; set; }
	}
}
