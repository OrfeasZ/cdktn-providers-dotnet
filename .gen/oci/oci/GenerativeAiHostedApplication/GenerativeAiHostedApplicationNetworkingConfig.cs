using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfig")]
    public class GenerativeAiHostedApplicationNetworkingConfig : oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfig
    {
        /// <summary>inbound_networking_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application#inbound_networking_config GenerativeAiHostedApplication#inbound_networking_config}
        /// </remarks>
        [JsiiProperty(name: "inboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig\"}")]
        public oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig InboundNetworkingConfig
        {
            get;
            set;
        }

        /// <summary>outbound_networking_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application#outbound_networking_config GenerativeAiHostedApplication#outbound_networking_config}
        /// </remarks>
        [JsiiProperty(name: "outboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig\"}")]
        public oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig OutboundNetworkingConfig
        {
            get;
            set;
        }
    }
}
