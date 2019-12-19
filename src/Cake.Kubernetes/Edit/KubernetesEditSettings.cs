using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Edit a resource from the default editor.
	///
	/// 
	///  The edit command allows you to directly edit any API resource you can retrieve via the command line tools. It will open the editor defined by your KUBE_EDITOR, or EDITOR environment variables, or fall back to 'vi' for Linux or 'notepad' for Windows. You can edit multiple objects, although changes are applied one at a time. The command accepts filenames as well as command line arguments, although the files you point to must be previously saved versions of resources.
	/// 
	///  Editing is done with the API version used to fetch the resource. To edit using a specific API version, fully-qualify the resource, version, and group.
	/// 
	///  The default format is YAML. To edit in JSON, specify "-o json".
	/// 
	///  The flag --windows-line-endings can be used to force Windows line endings, otherwise the default for your operating system will be used.
	/// 
	///  In the event an error occurs while updating, a temporary file will be created on disk that contains your unapplied changes. The most common error when updating a resource is another editor changing the resource on the server. When this occurs, you will have to apply your changes to the newer version of the resource, or update your temporary saved copy to include the latest resource version.
	/// </summary>
	/// <example>
	///   # Edit the service named 'docker-registry':
	///   kubectl edit svc/docker-registry
	/// 
	///   # Use an alternative editor
	///   KUBE_EDITOR="nano" kubectl edit svc/docker-registry
	/// 
	///   # Edit the job 'myjob' in JSON using the v1 API format:
	///   kubectl edit job.v1.batch/myjob -o json
	/// 
	///   # Edit the deployment 'mydeployment' in YAML and save the modified config in its annotation:
	///   kubectl edit deployment/mydeployment -o yaml --save-config
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesEditSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files to use to edit the resource
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string Kustomize { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --output-patch
		///
		/// Output the patch if the resource is edited.
		/// </summary>
		public bool? OutputPatch { get; set; }
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
		/// <summary>
		/// --validate
		///
		/// If true, use a schema to validate the input before sending it
		/// </summary>
		public bool? Validate { get; set; }
		/// <summary>
		/// --windows-line-endings
		///
		/// Defaults to the line ending native to your platform.
		/// </summary>
		public bool? WindowsLineEndings { get; set; }
	}
}
