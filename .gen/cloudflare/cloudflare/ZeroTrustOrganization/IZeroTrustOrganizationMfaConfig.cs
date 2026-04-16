using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustOrganization
{
    [JsiiInterface(nativeType: typeof(IZeroTrustOrganizationMfaConfig), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationMfaConfig")]
    public interface IZeroTrustOrganizationMfaConfig
    {
        /// <summary>Lists the MFA methods that users can authenticate with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#allowed_authenticators ZeroTrustOrganization#allowed_authenticators}
        /// </remarks>
        [JsiiProperty(name: "allowedAuthenticators", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedAuthenticators
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the duration of an MFA session.</summary>
        /// <remarks>
        /// Must be in minutes (m) or hours (h). Minimum: 0m. Maximum: 720h (30 days). Examples:<c>5m</c> or <c>24h</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#session_duration ZeroTrustOrganization#session_duration}
        /// </remarks>
        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustOrganizationMfaConfig), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationMfaConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationMfaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Lists the MFA methods that users can authenticate with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#allowed_authenticators ZeroTrustOrganization#allowed_authenticators}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedAuthenticators", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAuthenticators
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Defines the duration of an MFA session.</summary>
            /// <remarks>
            /// Must be in minutes (m) or hours (h). Minimum: 0m. Maximum: 720h (30 days). Examples:<c>5m</c> or <c>24h</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#session_duration ZeroTrustOrganization#session_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionDuration
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
