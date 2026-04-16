using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessPolicyMfaConfig), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyMfaConfig")]
    public interface IZeroTrustAccessPolicyMfaConfig
    {
        /// <summary>Lists the MFA methods that users can authenticate with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#allowed_authenticators ZeroTrustAccessPolicy#allowed_authenticators}
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

        /// <summary>Indicates whether to bypass MFA for this resource. This option is available at the application and policy level.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#mfa_bypass ZeroTrustAccessPolicy#mfa_bypass}
        /// </remarks>
        [JsiiProperty(name: "mfaBypass", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MfaBypass
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#session_duration ZeroTrustAccessPolicy#session_duration}
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

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessPolicyMfaConfig), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyMfaConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyMfaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Lists the MFA methods that users can authenticate with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#allowed_authenticators ZeroTrustAccessPolicy#allowed_authenticators}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedAuthenticators", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAuthenticators
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Indicates whether to bypass MFA for this resource. This option is available at the application and policy level.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#mfa_bypass ZeroTrustAccessPolicy#mfa_bypass}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mfaBypass", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MfaBypass
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines the duration of an MFA session.</summary>
            /// <remarks>
            /// Must be in minutes (m) or hours (h). Minimum: 0m. Maximum: 720h (30 days). Examples:<c>5m</c> or <c>24h</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#session_duration ZeroTrustAccessPolicy#session_duration}
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
