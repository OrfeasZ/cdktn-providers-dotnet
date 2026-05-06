using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationMfaConfig), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationMfaConfig")]
    public interface IZeroTrustAccessApplicationMfaConfig
    {
        /// <summary>The authenticators allowed for MFA. Available values: "totp", "biometrics", "security_key".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.1/docs/resources/zero_trust_access_application#allowed_authenticators ZeroTrustAccessApplication#allowed_authenticators}
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

        /// <summary>Whether MFA is disabled for this application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.1/docs/resources/zero_trust_access_application#mfa_disabled ZeroTrustAccessApplication#mfa_disabled}
        /// </remarks>
        [JsiiProperty(name: "mfaDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MfaDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>How often a user will be forced to re-authenticate with MFA.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.1/docs/resources/zero_trust_access_application#session_duration ZeroTrustAccessApplication#session_duration}
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

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationMfaConfig), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationMfaConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationMfaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The authenticators allowed for MFA. Available values: "totp", "biometrics", "security_key".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.1/docs/resources/zero_trust_access_application#allowed_authenticators ZeroTrustAccessApplication#allowed_authenticators}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedAuthenticators", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAuthenticators
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Whether MFA is disabled for this application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.1/docs/resources/zero_trust_access_application#mfa_disabled ZeroTrustAccessApplication#mfa_disabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mfaDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MfaDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>How often a user will be forced to re-authenticate with MFA.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.1/docs/resources/zero_trust_access_application#session_duration ZeroTrustAccessApplication#session_duration}
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
