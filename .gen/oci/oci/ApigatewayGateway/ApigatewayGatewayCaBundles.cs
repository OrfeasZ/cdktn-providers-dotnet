using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayGateway.ApigatewayGatewayCaBundles")]
    public class ApigatewayGatewayCaBundles : oci.ApigatewayGateway.IApigatewayGatewayCaBundles
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#type ApigatewayGateway#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#ca_bundle_id ApigatewayGateway#ca_bundle_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "caBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaBundleId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#certificate_authority_id ApigatewayGateway#certificate_authority_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateAuthorityId
        {
            get;
            set;
        }
    }
}
