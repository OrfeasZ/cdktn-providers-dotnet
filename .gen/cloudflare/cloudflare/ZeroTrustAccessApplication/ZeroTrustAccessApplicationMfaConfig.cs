using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationMfaConfig")]
    public class ZeroTrustAccessApplicationMfaConfig : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationMfaConfig
    {
        /// <summary>The authenticators allowed for MFA. Available values: "totp", "biometrics", "security_key".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.1/docs/resources/zero_trust_access_application#allowed_authenticators ZeroTrustAccessApplication#allowed_authenticators}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedAuthenticators", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedAuthenticators
        {
            get;
            set;
        }

        private object? _mfaDisabled;

        /// <summary>Whether MFA is disabled for this application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.1/docs/resources/zero_trust_access_application#mfa_disabled ZeroTrustAccessApplication#mfa_disabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mfaDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MfaDisabled
        {
            get => _mfaDisabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mfaDisabled = value;
            }
        }

        /// <summary>How often a user will be forced to re-authenticate with MFA.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.1/docs/resources/zero_trust_access_application#session_duration ZeroTrustAccessApplication#session_duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SessionDuration
        {
            get;
            set;
        }
    }
}
