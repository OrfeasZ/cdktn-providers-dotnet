using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfig")]
    public class GenerativeAiHostedApplicationIamNetworkingConfig : oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfig
    {
        /// <summary>inbound_networking_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_hosted_application_iam#inbound_networking_config GenerativeAiHostedApplicationIam#inbound_networking_config}
        /// </remarks>
        [JsiiProperty(name: "inboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig\"}")]
        public oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig InboundNetworkingConfig
        {
            get;
            set;
        }

        /// <summary>outbound_networking_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_hosted_application_iam#outbound_networking_config GenerativeAiHostedApplicationIam#outbound_networking_config}
        /// </remarks>
        [JsiiProperty(name: "outboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig\"}")]
        public oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig OutboundNetworkingConfig
        {
            get;
            set;
        }
    }
}
