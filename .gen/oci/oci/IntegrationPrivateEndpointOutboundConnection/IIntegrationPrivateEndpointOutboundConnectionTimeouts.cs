using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationPrivateEndpointOutboundConnection
{
    [JsiiInterface(nativeType: typeof(IIntegrationPrivateEndpointOutboundConnectionTimeouts), fullyQualifiedName: "oci.integrationPrivateEndpointOutboundConnection.IntegrationPrivateEndpointOutboundConnectionTimeouts")]
    public interface IIntegrationPrivateEndpointOutboundConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_private_endpoint_outbound_connection#create IntegrationPrivateEndpointOutboundConnection#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_private_endpoint_outbound_connection#delete IntegrationPrivateEndpointOutboundConnection#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_private_endpoint_outbound_connection#update IntegrationPrivateEndpointOutboundConnection#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIntegrationPrivateEndpointOutboundConnectionTimeouts), fullyQualifiedName: "oci.integrationPrivateEndpointOutboundConnection.IntegrationPrivateEndpointOutboundConnectionTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.IntegrationPrivateEndpointOutboundConnection.IIntegrationPrivateEndpointOutboundConnectionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_private_endpoint_outbound_connection#create IntegrationPrivateEndpointOutboundConnection#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_private_endpoint_outbound_connection#delete IntegrationPrivateEndpointOutboundConnection#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_private_endpoint_outbound_connection#update IntegrationPrivateEndpointOutboundConnection#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
