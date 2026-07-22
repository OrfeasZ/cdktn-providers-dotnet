using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig")]
    public class GenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig : oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_hosted_application#network_mode GenerativeAiHostedApplication#network_mode}.</summary>
        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_hosted_application#custom_subnet_id GenerativeAiHostedApplication#custom_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomSubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_hosted_application#nsg_ids GenerativeAiHostedApplication#nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NsgIds
        {
            get;
            set;
        }
    }
}
