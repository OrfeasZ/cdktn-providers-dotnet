using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig")]
    public class GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig : oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#endpoint_mode GenerativeAiHostedApplication#endpoint_mode}.</summary>
        [JsiiProperty(name: "endpointMode", typeJson: "{\"primitive\":\"string\"}")]
        public string EndpointMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#private_endpoint_id GenerativeAiHostedApplication#private_endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateEndpointId
        {
            get;
            set;
        }
    }
}
