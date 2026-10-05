using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey")]
    public class ZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey : cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey
    {
        /// <summary>Anthropic Compliance API key. This value is write-only and is never persisted to Terraform state.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#compliance_api_key ZeroTrustCasbIntegration#compliance_api_key}
        /// </remarks>
        [JsiiProperty(name: "complianceApiKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ComplianceApiKey
        {
            get;
            set;
        }

        /// <summary>Organization ID. Auto-extracted from the key if not provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#tenant_id ZeroTrustCasbIntegration#tenant_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenantId
        {
            get;
            set;
        }
    }
}
