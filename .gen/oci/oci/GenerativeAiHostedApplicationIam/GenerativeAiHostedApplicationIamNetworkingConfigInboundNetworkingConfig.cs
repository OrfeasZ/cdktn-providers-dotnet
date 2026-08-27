using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig")]
    public class GenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig : oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#endpoint_mode GenerativeAiHostedApplicationIam#endpoint_mode}.</summary>
        [JsiiProperty(name: "endpointMode", typeJson: "{\"primitive\":\"string\"}")]
        public string EndpointMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#private_endpoint_id GenerativeAiHostedApplicationIam#private_endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateEndpointId
        {
            get;
            set;
        }
    }
}
