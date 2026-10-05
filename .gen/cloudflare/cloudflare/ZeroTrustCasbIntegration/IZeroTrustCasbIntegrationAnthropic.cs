using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationAnthropic), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropic")]
    public interface IZeroTrustCasbIntegrationAnthropic
    {
        /// <summary>Authenticate with an Anthropic Admin API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#anthropic_admin_api_key ZeroTrustCasbIntegration#anthropic_admin_api_key}
        /// </remarks>
        [JsiiProperty(name: "anthropicAdminApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicAdminApiKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicAdminApiKey? AnthropicAdminApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Authenticate with an Anthropic Compliance API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#anthropic_compliance_api_key ZeroTrustCasbIntegration#anthropic_compliance_api_key}
        /// </remarks>
        [JsiiProperty(name: "anthropicComplianceApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey? AnthropicComplianceApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Authenticate with an Anthropic Workspace API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#anthropic_workspace_api_key ZeroTrustCasbIntegration#anthropic_workspace_api_key}
        /// </remarks>
        [JsiiProperty(name: "anthropicWorkspaceApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey? AnthropicWorkspaceApiKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationAnthropic), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropic")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Authenticate with an Anthropic Admin API key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#anthropic_admin_api_key ZeroTrustCasbIntegration#anthropic_admin_api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anthropicAdminApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicAdminApiKey\"}", isOptional: true)]
            public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicAdminApiKey? AnthropicAdminApiKey
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicAdminApiKey?>();
            }

            /// <summary>Authenticate with an Anthropic Compliance API key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#anthropic_compliance_api_key ZeroTrustCasbIntegration#anthropic_compliance_api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anthropicComplianceApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey\"}", isOptional: true)]
            public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey? AnthropicComplianceApiKey
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicComplianceApiKey?>();
            }

            /// <summary>Authenticate with an Anthropic Workspace API key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#anthropic_workspace_api_key ZeroTrustCasbIntegration#anthropic_workspace_api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anthropicWorkspaceApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey\"}", isOptional: true)]
            public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey? AnthropicWorkspaceApiKey
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey?>();
            }
        }
    }
}
