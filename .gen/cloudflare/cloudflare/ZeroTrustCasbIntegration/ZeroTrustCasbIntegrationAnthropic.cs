using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropic")]
    public class ZeroTrustCasbIntegrationAnthropic : cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropic
    {
        /// <summary>Authenticate with an Anthropic Admin API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#anthropic_admin_api_key ZeroTrustCasbIntegration#anthropic_admin_api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anthropicAdminApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicAdminApiKey\"}", isOptional: true)]
        public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicAdminApiKey? AnthropicAdminApiKey
        {
            get;
            set;
        }

        /// <summary>Authenticate with an Anthropic Compliance API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#anthropic_compliance_api_key ZeroTrustCasbIntegration#anthropic_compliance_api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anthropicComplianceApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey\"}", isOptional: true)]
        public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey? AnthropicComplianceApiKey
        {
            get;
            set;
        }

        /// <summary>Authenticate with an Anthropic Workspace API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#anthropic_workspace_api_key ZeroTrustCasbIntegration#anthropic_workspace_api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anthropicWorkspaceApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey\"}", isOptional: true)]
        public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey? AnthropicWorkspaceApiKey
        {
            get;
            set;
        }
    }
}
