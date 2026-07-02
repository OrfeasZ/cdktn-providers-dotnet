using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayGateway
{
    [JsiiInterface(nativeType: typeof(IApigatewayGatewayIpv4AddressConfiguration), fullyQualifiedName: "oci.apigatewayGateway.ApigatewayGatewayIpv4AddressConfiguration")]
    public interface IApigatewayGatewayIpv4AddressConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/apigateway_gateway#reserved_ip_ids ApigatewayGateway#reserved_ip_ids}.</summary>
        [JsiiProperty(name: "reservedIpIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ReservedIpIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayGatewayIpv4AddressConfiguration), fullyQualifiedName: "oci.apigatewayGateway.ApigatewayGatewayIpv4AddressConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayGateway.IApigatewayGatewayIpv4AddressConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/apigateway_gateway#reserved_ip_ids ApigatewayGateway#reserved_ip_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reservedIpIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ReservedIpIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
