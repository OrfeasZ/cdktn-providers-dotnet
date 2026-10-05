using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey")]
    public interface IZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey
    {
        /// <summary>Anthropic Workspace API key. This value is write-only and is never persisted to Terraform state.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#api_key ZeroTrustCasbIntegration#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        string ApiKey
        {
            get;
        }

        /// <summary>Workspace ID, found in the Anthropic Console URL after /workspaces/.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#tenant_id ZeroTrustCasbIntegration#tenant_id}
        /// </remarks>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        string TenantId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropicAnthropicWorkspaceApiKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Anthropic Workspace API key. This value is write-only and is never persisted to Terraform state.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#api_key ZeroTrustCasbIntegration#api_key}
            /// </remarks>
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Workspace ID, found in the Anthropic Console URL after /workspaces/.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#tenant_id ZeroTrustCasbIntegration#tenant_id}
            /// </remarks>
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
            public string TenantId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
