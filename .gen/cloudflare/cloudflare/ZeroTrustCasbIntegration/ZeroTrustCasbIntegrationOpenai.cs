using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenai")]
    public class ZeroTrustCasbIntegrationOpenai : cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenai
    {
        /// <summary>Authenticate with an OpenAI Compliance API key. Requires an Enterprise plan.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#chatgpt_compliance_api_key ZeroTrustCasbIntegration#chatgpt_compliance_api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chatgptComplianceApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKey\"}", isOptional: true)]
        public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKey? ChatgptComplianceApiKey
        {
            get;
            set;
        }

        /// <summary>Authenticate with an OpenAI Admin API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#chatgpt_standard_api_key ZeroTrustCasbIntegration#chatgpt_standard_api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chatgptStandardApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey\"}", isOptional: true)]
        public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey? ChatgptStandardApiKey
        {
            get;
            set;
        }
    }
}
