using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azapi.DataAzapiDataPlaneResource
{
    [JsiiInterface(nativeType: typeof(IDataAzapiDataPlaneResourceTimeouts), fullyQualifiedName: "azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceTimeouts")]
    public interface IDataAzapiDataPlaneResourceTimeouts
    {
        /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#read DataAzapiDataPlaneResource#read}
        /// </remarks>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzapiDataPlaneResourceTimeouts), fullyQualifiedName: "azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#read DataAzapiDataPlaneResource#read}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
