using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayGateway
{
    [JsiiByValue(fqn: "oci.apigatewayGateway.ApigatewayGatewayIpv4AddressConfiguration")]
    public class ApigatewayGatewayIpv4AddressConfiguration : oci.ApigatewayGateway.IApigatewayGatewayIpv4AddressConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/apigateway_gateway#reserved_ip_ids ApigatewayGateway#reserved_ip_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reservedIpIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ReservedIpIds
        {
            get;
            set;
        }
    }
}
