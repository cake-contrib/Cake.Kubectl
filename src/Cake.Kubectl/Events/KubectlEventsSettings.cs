using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Display events
	///
	/// 
	///  Prints a table of the most important information about events. You can request events for a namespace, for all namespace, or filtered to only those pertaining to a specified resource.
	/// </summary>
	/// <example>
	///   # List recent events in the default namespace.
	///   kubectl events
	/// 
	///   # List recent events in all namespaces.
	///   kubectl events --all-namespaces
	/// 
	///   # List recent events for the specified pod, then wait for more events and list them as they arrive.
	///   kubectl events --for pod/web-pod-13je7 --watch
	/// 
	///   # List recent events in given format. Supported ones, apart from default, are json and yaml.
	///   kubectl events -oyaml
	/// 
	///   # List recent only events in given event types
	///   kubectl events --types=Warning,Normal
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlEventsSettings : AutoToolSettings
	{
		/// <summary>
		/// -A, --all-namespaces
		///
		/// If present, list the requested object(s) across all namespaces. Namespace in current context is ignored even if specified with --namespace.
		/// </summary>
		public bool? AllNamespaces { get; set; }
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --chunk-size
		///
		/// Return large lists in chunks rather than all at once. Pass 0 to disable. This flag is beta and may change in the future.
		/// </summary>
		public int? ChunkSize { get; set; }
		/// <summary>
		/// --for
		///
		/// Filter events to only those pertaining to the specified resource.
		/// </summary>
		public string? For { get; set; }
		/// <summary>
		/// --no-headers
		///
		/// When using the default output format, don't print headers.
		/// </summary>
		public bool? NoHeaders { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// --show-managed-fields
		///
		/// If true, keep the managedFields when printing objects in JSON or YAML format.
		/// </summary>
		public bool? ShowManagedFields { get; set; }
		/// <summary>
		/// --template
		///
		/// Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].
		/// </summary>
		public string? Template { get; set; }
		/// <summary>
		/// --types
		///
		/// Output only events of given types.
		/// </summary>
		public string? Types { get; set; }
		/// <summary>
		/// -w, --watch
		///
		/// After listing the requested events, watch for more events.
		/// </summary>
		public bool? Watch { get; set; }
	}
}
