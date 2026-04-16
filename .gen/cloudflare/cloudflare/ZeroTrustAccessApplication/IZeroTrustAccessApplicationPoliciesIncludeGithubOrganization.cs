using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationPoliciesIncludeGithubOrganization), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGithubOrganization")]
    public interface IZeroTrustAccessApplicationPoliciesIncludeGithubOrganization
    {
        /// <summary>The ID of your Github identity provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#identity_provider_id ZeroTrustAccessApplication#identity_provider_id}
        /// </remarks>
        [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityProviderId
        {
            get;
        }

        /// <summary>The name of the organization.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#name ZeroTrustAccessApplication#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The name of the team.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#team ZeroTrustAccessApplication#team}
        /// </remarks>
        [JsiiProperty(name: "team", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Team
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationPoliciesIncludeGithubOrganization), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGithubOrganization")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGithubOrganization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of your Github identity provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#identity_provider_id ZeroTrustAccessApplication#identity_provider_id}
            /// </remarks>
            [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityProviderId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the organization.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#name ZeroTrustAccessApplication#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the team.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#team ZeroTrustAccessApplication#team}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "team", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Team
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
