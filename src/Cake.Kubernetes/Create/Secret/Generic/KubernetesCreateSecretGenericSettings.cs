using System.Runtime.CompilerServices;

namespace Cake.Kubernetes
{
	/// <summary>
	/// Create a secret based on a file, directory, or specified literal value.
	///
	/// 
	///  A single secret may package one or more key/value pairs.
	/// 
	///  When creating a secret based on a file, the key will default to the basename of the file, and the value will default to the file content. If the basename is an invalid key or you wish to chose your own, you may specify an alternate key.
	/// 
	///  When creating a secret based on a directory, each file whose basename is a valid key in the directory will be packaged into the secret. Any directory entries except regular files are ignored (e.g. subdirectories, symlinks, devices, pipes, etc).
	/// </summary>
	/// <example>
	///   # Create a new secret named my-secret with keys for each file in folder bar
	///   kubectl create secret generic my-secret --from-file=path/to/bar
	/// 
	///   # Create a new secret named my-secret with specified keys instead of names on disk
	///   kubectl create secret generic my-secret --from-file=ssh-privatekey=~/.ssh/id_rsa --from-file=ssh-publickey=~/.ssh/id_rsa.pub
	/// 
	///   # Create a new secret named my-secret with key1=supersecret and key2=topsecret
	///   kubectl create secret generic my-secret --from-literal=key1=supersecret --from-literal=key2=topsecret
	/// 
	///   # Create a new secret named my-secret using a combination of a file and a literal
	///   kubectl create secret generic my-secret --from-file=ssh-privatekey=~/.ssh/id_rsa --from-literal=passphrase=topsecret
	/// 
	///   # Create a new secret named my-secret from an env file
	///   kubectl create secret generic my-secret --from-env-file=path/to/bar.env
	/// </example>
	[CompilerGenerated]
	public sealed class KubernetesCreateSecretGenericSettings : AutoToolSettings
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
		/// Append a hash of the secret to its name.
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
		/// Specify the path to a file to read lines of key=val pairs to create a secret (i.e. a Docker .env file).
		/// </summary>
		public string FromEnvFile { get; set; }
		/// <summary>
		/// --from-file
		///
		/// Key files can be specified using their file path, in which case a default name will be given to them, or optionally with a name and file path, in which case the given name will be used.  Specifying a directory will iterate each named file in the directory that is a valid secret key.
		/// </summary>
		public string FromFile { get; set; }
		/// <summary>
		/// --from-literal
		///
		/// Specify a key and literal value to insert in secret (i.e. mykey=somevalue)
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
		/// --type
		///
		/// The type of secret to create
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// --validate
		///
		/// If true, use a schema to validate the input before sending it
		/// </summary>
		public bool? Validate { get; set; }
	}
}
