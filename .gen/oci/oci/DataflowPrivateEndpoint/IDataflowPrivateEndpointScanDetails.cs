using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowPrivateEndpoint
{
    [JsiiInterface(nativeType: typeof(IDataflowPrivateEndpointScanDetails), fullyQualifiedName: "oci.dataflowPrivateEndpoint.DataflowPrivateEndpointScanDetails")]
    public interface IDataflowPrivateEndpointScanDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_private_endpoint#fqdn DataflowPrivateEndpoint#fqdn}.</summary>
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Fqdn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_private_endpoint#port DataflowPrivateEndpoint#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataflowPrivateEndpointScanDetails), fullyQualifiedName: "oci.dataflowPrivateEndpoint.DataflowPrivateEndpointScanDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DataflowPrivateEndpoint.IDataflowPrivateEndpointScanDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_private_endpoint#fqdn DataflowPrivateEndpoint#fqdn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Fqdn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_private_endpoint#port DataflowPrivateEndpoint#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Port
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
