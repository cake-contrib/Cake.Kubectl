using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Edit a resource from the default editor.
	///
	/// 
	///  The edit command allows you to directly edit any API resource you can retrieve via the command-line tools. It will open the editor defined by your KUBE_EDITOR, or EDITOR environment variables, or fall back to 'vi' for Linux or 'notepad' for Windows. You can edit multiple objects, although changes are applied one at a time. The command accepts file names as well as command-line arguments, although the files you point to must be previously saved versions of resources.
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
	///   # Edit the service named 'registry'
	///   kubectl edit svc/registry
	/// 
	///   # Use an alternative editor
	///   KUBE_EDITOR="nano" kubectl edit svc/registry
	/// 
	///   # Edit the job 'myjob' in JSON using the v1 API format
	///   kubectl edit job.v1.batch/myjob -o json
	/// 
	///   # Edit the deployment 'mydeployment' in YAML and save the modified config in its annotation
	///   kubectl edit deployment/mydeployment -o yaml --save-config
	/// 
	///   # Edit the deployment/mydeployment's status subresource
	///   kubectl edit deployment mydeployment --subresource='status'
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlEditSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --field-manager
		///
		/// Name of the manager used to track field ownership.
		/// </summary>
		public string? FieldManager { get; set; }
		/// <summary>
		/// -f, --filename
		///
		/// Filename, directory, or URL to files to use to edit the resource
		/// </summary>
		public string? Filename { get; set; }
		/// <summary>
		/// -k, --kustomize
		///
		/// Process the kustomization directory. This flag can't be used together with -f or -R.
		/// </summary>
		public string? Kustomize { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// --output-patch
		///
		/// Output the patch if the resource is edited.
		/// </summary>
		public bool? OutputPatch { get; set; }
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
		/// --show-managed-fields
		///
		/// If true, keep the managedFields when printing objects in JSON or YAML format.
		/// </summary>
		public bool? ShowManagedFields { get; set; }
		/// <summary>
		/// --subresource
		///
		/// If specified, edit will operate on the subresource of the requested object. Must be one of [status]. This flag is beta and may change in the future.
		/// </summary>
		public string? Subresource { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string? Template { get; set; }
		/// <summary>
		/// --validate
		///
		/// Must be one of: strict (or true), warn, ignore (or false). 		"true" or "strict" will use a schema to validate the input and fail the request if invalid. It will perform server side validation if ServerSideFieldValidation is enabled on the api-server, but will fall back to less reliable client-side validation if not. 		"warn" will warn about unknown or duplicate fields without blocking the request if server-side field validation is enabled on the API server, and behave as "ignore" otherwise. 		"false" or "ignore" will not perform any schema validation, silently dropping any unknown or duplicate fields.
		/// </summary>
		public string? Validate { get; set; }
		/// <summary>
		/// --windows-line-endings
		///
		/// Defaults to the line ending native to your platform.
		/// </summary>
		public bool? WindowsLineEndings { get; set; }
	}
}
