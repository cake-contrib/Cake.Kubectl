using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Creates a proxy server or application-level gateway between localhost and the Kubernetes API server. It also allows serving static content over specified HTTP path. All incoming data enters through one port and gets forwarded to the remote Kubernetes API server port, except for the path matching the static content path.
	///
	/// </summary>
	/// <example>
	///   # To proxy all of the Kubernetes API and nothing else
	///   kubectl proxy --api-prefix=/
	/// 
	///   # To proxy only part of the Kubernetes API and also some static files
	///   # You can get pods info with 'curl localhost:8001/api/v1/pods'
	///   kubectl proxy --www=/my/files --www-prefix=/static/ --api-prefix=/api/
	/// 
	///   # To proxy the entire Kubernetes API at a different root
	///   # You can get pods info with 'curl localhost:8001/custom/api/v1/pods'
	///   kubectl proxy --api-prefix=/custom/
	/// 
	///   # Run a proxy to the Kubernetes API server on port 8011, serving static content from ./local/www/
	///   kubectl proxy --port=8011 --www=./local/www/
	/// 
	///   # Run a proxy to the Kubernetes API server on an arbitrary local port
	///   # The chosen port for the server will be output to stdout
	///   kubectl proxy --port=0
	/// 
	///   # Run a proxy to the Kubernetes API server, changing the API prefix to k8s-api
	///   # This makes e.g. the pods API available at localhost:8001/k8s-api/v1/pods/
	///   kubectl proxy --api-prefix=/k8s-api
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlProxySettings : AutoToolSettings
	{
		/// <summary>
		/// --accept-hosts
		///
		/// Regular expression for hosts that the proxy should accept.
		/// </summary>
		public string? AcceptHosts { get; set; }
		/// <summary>
		/// --accept-paths
		///
		/// Regular expression for paths that the proxy should accept.
		/// </summary>
		public string? AcceptPaths { get; set; }
		/// <summary>
		/// --address
		///
		/// The IP address on which to serve on.
		/// </summary>
		public string? Address { get; set; }
		/// <summary>
		/// --api-prefix
		///
		/// Prefix to serve the proxied API under.
		/// </summary>
		public string? ApiPrefix { get; set; }
		/// <summary>
		/// --append-server-path
		///
		/// If true, enables automatic path appending of the kube context server path to each request.
		/// </summary>
		public bool? AppendServerPath { get; set; }
		/// <summary>
		/// --disable-filter
		///
		/// If true, disable request filtering in the proxy. This is dangerous, and can leave you vulnerable to XSRF attacks, when used with an accessible port.
		/// </summary>
		public bool? DisableFilter { get; set; }
		/// <summary>
		/// --keepalive
		///
		/// keepalive specifies the keep-alive period for an active network connection. Set to 0 to disable keepalive.
		/// </summary>
		public string? Keepalive { get; set; }
		/// <summary>
		/// -p, --port
		///
		/// The port on which to run the proxy. Set to 0 to pick a random port.
		/// </summary>
		public int? Port { get; set; }
		/// <summary>
		/// --reject-methods
		///
		/// Regular expression for HTTP methods that the proxy should reject (example --reject-methods='POST,PUT,PATCH').
		/// </summary>
		public string? RejectMethods { get; set; }
		/// <summary>
		/// --reject-paths
		///
		/// Regular expression for paths that the proxy should reject. Paths specified here will be rejected even accepted by --accept-paths.
		/// </summary>
		public string? RejectPaths { get; set; }
		/// <summary>
		/// -u, --unix-socket
		///
		/// Unix socket on which to run the proxy.
		/// </summary>
		public string? UnixSocket { get; set; }
		/// <summary>
		/// -w, --www
		///
		/// Also serve static files from the given directory under the specified prefix.
		/// </summary>
		public string? Www { get; set; }
		/// <summary>
		/// -P, --www-prefix
		///
		/// Prefix to serve static files under, if static file directory is specified.
		/// </summary>
		public string? WwwPrefix { get; set; }
	}
}
