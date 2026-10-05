using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKey")]
    public class ZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKey : cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKey
    {
        /// <summary>OpenAI Admin API key with api.management.read access. This value is write-only and is never persisted to Terraform state.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#admin_api_key ZeroTrustCasbIntegration#admin_api_key}
        /// </remarks>
        [JsiiProperty(name: "adminApiKey", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminApiKey
        {
            get;
            set;
        }

        /// <summary>OpenAI Compliance API key for audit logs. This value is write-only and is never persisted to Terraform state.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#compliance_api_key ZeroTrustCasbIntegration#compliance_api_key}
        /// </remarks>
        [JsiiProperty(name: "complianceApiKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ComplianceApiKey
        {
            get;
            set;
        }

        /// <summary>OpenAI Organization ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#organization_id ZeroTrustCasbIntegration#organization_id}
        /// </remarks>
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public string OrganizationId
        {
            get;
            set;
        }

        /// <summary>OpenAI Workspace ID for compliance data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#workspace_id ZeroTrustCasbIntegration#workspace_id}
        /// </remarks>
        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string WorkspaceId
        {
            get;
            set;
        }

        /// <summary>OpenAI Project API key, used for DLP. This value is write-only and is never persisted to Terraform state.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#project_api_key ZeroTrustCasbIntegration#project_api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "projectApiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProjectApiKey
        {
            get;
            set;
        }

        /// <summary>OpenAI Project ID, used for DLP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#project_id ZeroTrustCasbIntegration#project_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProjectId
        {
            get;
            set;
        }
    }
}
