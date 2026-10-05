using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey")]
    public interface IZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey
    {
        /// <summary>Anthropic Compliance API key. This value is write-only and is never persisted to Terraform state.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#compliance_api_key ZeroTrustCasbIntegration#compliance_api_key}
        /// </remarks>
        [JsiiProperty(name: "complianceApiKey", typeJson: "{\"primitive\":\"string\"}")]
        string ComplianceApiKey
        {
            get;
        }

        /// <summary>Organization ID. Auto-extracted from the key if not provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#tenant_id ZeroTrustCasbIntegration#tenant_id}
        /// </remarks>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenantId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Anthropic Compliance API key. This value is write-only and is never persisted to Terraform state.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#compliance_api_key ZeroTrustCasbIntegration#compliance_api_key}
            /// </remarks>
            [JsiiProperty(name: "complianceApiKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ComplianceApiKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Organization ID. Auto-extracted from the key if not provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#tenant_id ZeroTrustCasbIntegration#tenant_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
