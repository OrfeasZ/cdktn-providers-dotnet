using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayGateway
{
    [JsiiInterface(nativeType: typeof(IApigatewayGatewayIpv6AddressConfiguration), fullyQualifiedName: "oci.apigatewayGateway.ApigatewayGatewayIpv6AddressConfiguration")]
    public interface IApigatewayGatewayIpv6AddressConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/apigateway_gateway#addresses ApigatewayGateway#addresses}.</summary>
        [JsiiProperty(name: "addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Addresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/apigateway_gateway#subnet_cidrs ApigatewayGateway#subnet_cidrs}.</summary>
        [JsiiProperty(name: "subnetCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubnetCidrs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayGatewayIpv6AddressConfiguration), fullyQualifiedName: "oci.apigatewayGateway.ApigatewayGatewayIpv6AddressConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayGateway.IApigatewayGatewayIpv6AddressConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/apigateway_gateway#addresses ApigatewayGateway#addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Addresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/apigateway_gateway#subnet_cidrs ApigatewayGateway#subnet_cidrs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubnetCidrs
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
