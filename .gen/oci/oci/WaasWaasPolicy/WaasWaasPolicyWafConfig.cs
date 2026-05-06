using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiByValue(fqn: "oci.waasWaasPolicy.WaasWaasPolicyWafConfig")]
    public class WaasWaasPolicyWafConfig : oci.WaasWaasPolicy.IWaasWaasPolicyWafConfig
    {
        private object? _accessRules;

        /// <summary>access_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#access_rules WaasWaasPolicy#access_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAccessRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AccessRules
        {
            get => _accessRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAccessRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAccessRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _accessRules = value;
            }
        }

        /// <summary>address_rate_limiting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#address_rate_limiting WaasWaasPolicy#address_rate_limiting}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressRateLimiting", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAddressRateLimiting\"}", isOptional: true)]
        public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAddressRateLimiting? AddressRateLimiting
        {
            get;
            set;
        }

        private object? _cachingRules;

        /// <summary>caching_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#caching_rules WaasWaasPolicy#caching_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cachingRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CachingRules
        {
            get => _cachingRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCachingRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCachingRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cachingRules = value;
            }
        }

        private object? _captchas;

        /// <summary>captchas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captchas WaasWaasPolicy#captchas}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captchas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCaptchas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Captchas
        {
            get => _captchas;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCaptchas[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCaptchas).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _captchas = value;
            }
        }

        private object? _customProtectionRules;

        /// <summary>custom_protection_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#custom_protection_rules WaasWaasPolicy#custom_protection_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customProtectionRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCustomProtectionRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomProtectionRules
        {
            get => _customProtectionRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCustomProtectionRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCustomProtectionRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customProtectionRules = value;
            }
        }

        /// <summary>device_fingerprint_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#device_fingerprint_challenge WaasWaasPolicy#device_fingerprint_challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deviceFingerprintChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallenge\"}", isOptional: true)]
        public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallenge? DeviceFingerprintChallenge
        {
            get;
            set;
        }

        /// <summary>human_interaction_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#human_interaction_challenge WaasWaasPolicy#human_interaction_challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "humanInteractionChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallenge\"}", isOptional: true)]
        public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallenge? HumanInteractionChallenge
        {
            get;
            set;
        }

        /// <summary>js_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#js_challenge WaasWaasPolicy#js_challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jsChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallenge\"}", isOptional: true)]
        public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallenge? JsChallenge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#origin WaasWaasPolicy#origin}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Origin
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#origin_groups WaasWaasPolicy#origin_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OriginGroups
        {
            get;
            set;
        }

        /// <summary>protection_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#protection_settings WaasWaasPolicy#protection_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protectionSettings", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettings\"}", isOptional: true)]
        public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigProtectionSettings? ProtectionSettings
        {
            get;
            set;
        }

        private object? _whitelists;

        /// <summary>whitelists block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#whitelists WaasWaasPolicy#whitelists}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "whitelists", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigWhitelists\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Whitelists
        {
            get => _whitelists;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigWhitelists[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigWhitelists).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _whitelists = value;
            }
        }
    }
}
