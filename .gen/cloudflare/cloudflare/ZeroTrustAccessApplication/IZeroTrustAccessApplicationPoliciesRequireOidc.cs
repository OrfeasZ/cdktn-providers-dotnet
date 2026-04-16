using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationPoliciesRequireOidc), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOidc")]
    public interface IZeroTrustAccessApplicationPoliciesRequireOidc
    {
        /// <summary>The name of the OIDC claim.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#claim_name ZeroTrustAccessApplication#claim_name}
        /// </remarks>
        [JsiiProperty(name: "claimName", typeJson: "{\"primitive\":\"string\"}")]
        string ClaimName
        {
            get;
        }

        /// <summary>The OIDC claim value to look for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#claim_value ZeroTrustAccessApplication#claim_value}
        /// </remarks>
        [JsiiProperty(name: "claimValue", typeJson: "{\"primitive\":\"string\"}")]
        string ClaimValue
        {
            get;
        }

        /// <summary>The ID of your OIDC identity provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#identity_provider_id ZeroTrustAccessApplication#identity_provider_id}
        /// </remarks>
        [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityProviderId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationPoliciesRequireOidc), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOidc")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireOidc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the OIDC claim.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#claim_name ZeroTrustAccessApplication#claim_name}
            /// </remarks>
            [JsiiProperty(name: "claimName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClaimName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The OIDC claim value to look for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#claim_value ZeroTrustAccessApplication#claim_value}
            /// </remarks>
            [JsiiProperty(name: "claimValue", typeJson: "{\"primitive\":\"string\"}")]
            public string ClaimValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of your OIDC identity provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#identity_provider_id ZeroTrustAccessApplication#identity_provider_id}
            /// </remarks>
            [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityProviderId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
