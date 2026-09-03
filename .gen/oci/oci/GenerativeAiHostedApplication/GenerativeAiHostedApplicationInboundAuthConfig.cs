using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfig")]
    public class GenerativeAiHostedApplicationInboundAuthConfig : oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application#inbound_auth_config_type GenerativeAiHostedApplication#inbound_auth_config_type}.</summary>
        [JsiiProperty(name: "inboundAuthConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public string InboundAuthConfigType
        {
            get;
            set;
        }

        /// <summary>idcs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application#idcs_config GenerativeAiHostedApplication#idcs_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idcsConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfig\"}", isOptional: true)]
        public oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig? IdcsConfig
        {
            get;
            set;
        }
    }
}
