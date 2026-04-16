using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessPolicyExcludeGithubOrganization), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGithubOrganization")]
    public interface IZeroTrustAccessPolicyExcludeGithubOrganization
    {
        /// <summary>The ID of your Github identity provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#identity_provider_id ZeroTrustAccessPolicy#identity_provider_id}
        /// </remarks>
        [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityProviderId
        {
            get;
        }

        /// <summary>The name of the organization.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#name ZeroTrustAccessPolicy#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The name of the team.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#team ZeroTrustAccessPolicy#team}
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

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessPolicyExcludeGithubOrganization), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGithubOrganization")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGithubOrganization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of your Github identity provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#identity_provider_id ZeroTrustAccessPolicy#identity_provider_id}
            /// </remarks>
            [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityProviderId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the organization.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#name ZeroTrustAccessPolicy#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the team.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#team ZeroTrustAccessPolicy#team}
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
