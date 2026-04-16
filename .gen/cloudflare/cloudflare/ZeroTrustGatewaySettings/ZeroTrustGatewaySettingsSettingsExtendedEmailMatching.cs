using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsExtendedEmailMatching")]
    public class ZeroTrustGatewaySettingsSettingsExtendedEmailMatching : cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsExtendedEmailMatching
    {
        private object? _enabled;

        /// <summary>Specify whether to match all variants of user emails (with + or .</summary>
        /// <remarks>
        /// modifiers) used as criteria in Firewall policies.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_settings#enabled ZeroTrustGatewaySettings#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }

        private object? _readOnly;

        /// <summary>Indicate that this setting was shared via the Orgs API and read only for the current account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_settings#read_only ZeroTrustGatewaySettings#read_only}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ReadOnly
        {
            get => _readOnly;
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
                _readOnly = value;
            }
        }

        /// <summary>Indicate the account tag of the account that shared this setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_settings#source_account ZeroTrustGatewaySettings#source_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceAccount
        {
            get;
            set;
        }

        /// <summary>Indicate the version number of the setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_settings#version ZeroTrustGatewaySettings#version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Version
        {
            get;
            set;
        }
    }
}
