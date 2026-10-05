using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey")]
    public interface IZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey
    {
        /// <summary>OpenAI Admin API key with api.management.read access. This value is write-only and is never persisted to Terraform state.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#admin_api_key ZeroTrustCasbIntegration#admin_api_key}
        /// </remarks>
        [JsiiProperty(name: "adminApiKey", typeJson: "{\"primitive\":\"string\"}")]
        string AdminApiKey
        {
            get;
        }

        /// <summary>OpenAI Organization ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#organization_id ZeroTrustCasbIntegration#organization_id}
        /// </remarks>
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        string OrganizationId
        {
            get;
        }

        /// <summary>OpenAI Project API key, used for DLP. This value is write-only and is never persisted to Terraform state.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#project_api_key ZeroTrustCasbIntegration#project_api_key}
        /// </remarks>
        [JsiiProperty(name: "projectApiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>OpenAI Project ID, used for DLP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#project_id ZeroTrustCasbIntegration#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>OpenAI Admin API key with api.management.read access. This value is write-only and is never persisted to Terraform state.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#admin_api_key ZeroTrustCasbIntegration#admin_api_key}
            /// </remarks>
            [JsiiProperty(name: "adminApiKey", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminApiKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>OpenAI Organization ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#organization_id ZeroTrustCasbIntegration#organization_id}
            /// </remarks>
            [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
            public string OrganizationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>OpenAI Project API key, used for DLP. This value is write-only and is never persisted to Terraform state.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#project_api_key ZeroTrustCasbIntegration#project_api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectApiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectApiKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>OpenAI Project ID, used for DLP.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#project_id ZeroTrustCasbIntegration#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
