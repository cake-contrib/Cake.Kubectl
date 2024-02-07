using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Create an ingress with the specified name.
	///
	/// </summary>
	/// <example>
	///   # Create a single ingress called 'simple' that directs requests to foo.com/bar to svc
	///   # svc1:8080 with a tls secret "my-cert"
	///   kubectl create ingress simple --rule="foo.com/bar=svc1:8080,tls=my-cert"
	/// 
	///   # Create a catch all ingress of "/path" pointing to service svc:port and Ingress Class as "otheringress"
	///   kubectl create ingress catch-all --class=otheringress --rule="/path=svc:port"
	/// 
	///   # Create an ingress with two annotations: ingress.annotation1 and ingress.annotations2
	///   kubectl create ingress annotated --class=default --rule="foo.com/bar=svc:port" \
	///   --annotation ingress.annotation1=foo \
	///   --annotation ingress.annotation2=bla
	/// 
	///   # Create an ingress with the same host and multiple paths
	///   kubectl create ingress multipath --class=default \
	///   --rule="foo.com/=svc:port" \
	///   --rule="foo.com/admin/=svcadmin:portadmin"
	/// 
	///   # Create an ingress with multiple hosts and the pathType as Prefix
	///   kubectl create ingress ingress1 --class=default \
	///   --rule="foo.com/path*=svc:8080" \
	///   --rule="bar.com/admin*=svc2:http"
	/// 
	///   # Create an ingress with TLS enabled using the default ingress certificate and different path types
	///   kubectl create ingress ingtls --class=default \
	///   --rule="foo.com/=svc:https,tls" \
	///   --rule="foo.com/path/subpath*=othersvc:8080"
	/// 
	///   # Create an ingress with TLS enabled using a specific secret and pathType as Prefix
	///   kubectl create ingress ingsecret --class=default \
	///   --rule="foo.com/*=svc:8080,tls=secret1"
	/// 
	///   # Create an ingress with a default backend
	///   kubectl create ingress ingdefault --class=default \
	///   --default-backend=defaultsvc:http \
	///   --rule="foo.com/*=svc:8080,tls=secret1"
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCreateIngressSettings : AutoToolSettings
	{
		/// <summary>
		/// --allow-missing-template-keys
		///
		/// If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.
		/// </summary>
		public bool? AllowMissingTemplateKeys { get; set; }
		/// <summary>
		/// --annotation
		///
		/// Annotation to insert in the ingress object, in the format annotation=value
		/// </summary>
		public string? Annotation { get; set; }
		/// <summary>
		/// --class
		///
		/// Ingress Class to be used
		/// </summary>
		public string? Class { get; set; }
		/// <summary>
		/// --default-backend
		///
		/// Default service for backend, in format of svcname:port
		/// </summary>
		public string? DefaultBackend { get; set; }
		/// <summary>
		/// --dry-run
		///
		/// Must be "none", "server", or "client". If client strategy, only print the object that would be sent, without sending it. If server strategy, submit server-side request without persisting the resource.
		/// </summary>
		public string? DryRun { get; set; }
		/// <summary>
		/// --field-manager
		///
		/// Name of the manager used to track field ownership.
		/// </summary>
		public string? FieldManager { get; set; }
		/// <summary>
		/// -o, --output
		///
		/// Output format. One of: (json, yaml, name, go-template, go-template-file, template, templatefile, jsonpath, jsonpath-as-json, jsonpath-file).
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// --rule
		///
		/// Rule in format host/path=service:port[,tls=secretname]. Paths containing the leading character '*' are considered pathType=Prefix. tls argument is optional.
		/// </summary>
		public string? Rule { get; set; }
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
	}
}
