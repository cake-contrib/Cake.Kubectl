using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// List the fields for supported resources
	///
	/// 
	///  This command describes the fields associated with each supported API resource. Fields are identified via a simple JSONPath identifier:
	/// 
	///   <type>.<fieldName>[.<fieldName>]
	/// 
	///  Add the --recursive flag to display all of the fields at once without descriptions. Information about each field is retrieved from the server in OpenAPI format.
	/// </summary>
	[CompilerGenerated]
	public sealed class KubectlExplainSettings : AutoToolSettings
	{
	}
}
