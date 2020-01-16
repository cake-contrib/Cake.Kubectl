using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Create a configmap based on a file, directory, or specified literal value.
	///
	/// 
	///  A single configmap may package one or more key/value pairs.
	/// 
	///  When creating a configmap based on a file, the key will default to the basename of the file, and the value will default to the file content.  If the basename is an invalid key, you may specify an alternate key.
	/// 
	///  When creating a configmap based on a directory, each file whose basename is a valid key in the directory will be packaged into the configmap.  Any directory entries except regular files are ignored (e.g. subdirectories, symlinks, devices, pipes, etc).
	/// </summary>
	/// <example>
	///   # Create a new configmap named my-config based on folder bar
	///   kubectl create configmap my-config --from-file=path/to/bar
	/// 
	///   # Create a new configmap named my-config with specified keys instead of file basenames on disk
	///   kubectl create configmap my-config --from-file=key1=/path/to/bar/file1.txt --from-file=key2=/path/to/bar/file2.txt
	/// 
	///   # Create a new configmap named my-config with key1=config1 and key2=config2
	///   kubectl create configmap my-config --from-literal=key1=config1 --from-literal=key2=config2
	/// 
	///   # Create a new configmap named my-config from the key=value pairs in the file
	///   kubectl create configmap my-config --from-file=path/to/bar
	/// 
	///   # Create a new configmap named my-config from an env file
	///   kubectl create configmap my-config --from-env-file=path/to/bar.env
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCreateConfigmapSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --append-hash
		///
		/// Append a hash of the configmap to its name.
		/// </summary>
		public bool? AppendHash { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// If true, only print the object that would be sent, without sending it.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// --from-env-file
		///
		/// Specify the path to a file to read lines of key=val pairs to create a configmap (i.e. a Docker .env file).
		/// </summary>
		public string FromEnvFile { get; set; }
		/// <summary>
		/// --from-file
		///
		/// Key file can be specified using its file path, in which case file basename will be used as configmap key, or optionally with a key and file path, in which case the given key will be used.  Specifying a directory will iterate each named file in the directory whose basename is a valid configmap key.
		/// </summary>
		public string FromFile { get; set; }
		/// <summary>
		/// --from-literal
		///
		/// Specify a key and literal value to insert in configmap (i.e. mykey=somevalue)
		/// </summary>
		public string FromLiteral { get; set; }
		/// <summary>
		/// --generator
		///
		/// The name of the API generator to use.
		/// </summary>
		public string Generator { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: json|yaml|name|go-template|go-template-file|template|templatefile|jsonpath|jsonpath-file.
		/// </summary>
		public string Output { get; set; }
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
	}
}
