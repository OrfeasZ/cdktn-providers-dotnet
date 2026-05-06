using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyWafConfig), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfig")]
    public interface IWaasWaasPolicyWafConfig
    {
        /// <summary>access_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#access_rules WaasWaasPolicy#access_rules}
        /// </remarks>
        [JsiiProperty(name: "accessRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAccessRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AccessRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>address_rate_limiting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#address_rate_limiting WaasWaasPolicy#address_rate_limiting}
        /// </remarks>
        [JsiiProperty(name: "addressRateLimiting", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAddressRateLimiting\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAddressRateLimiting? AddressRateLimiting
        {
            get
            {
                return null;
            }
        }

        /// <summary>caching_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#caching_rules WaasWaasPolicy#caching_rules}
        /// </remarks>
        [JsiiProperty(name: "cachingRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CachingRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>captchas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captchas WaasWaasPolicy#captchas}
        /// </remarks>
        [JsiiProperty(name: "captchas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCaptchas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Captchas
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_protection_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#custom_protection_rules WaasWaasPolicy#custom_protection_rules}
        /// </remarks>
        [JsiiProperty(name: "customProtectionRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCustomProtectionRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomProtectionRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>device_fingerprint_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#device_fingerprint_challenge WaasWaasPolicy#device_fingerprint_challenge}
        /// </remarks>
        [JsiiProperty(name: "deviceFingerprintChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallenge\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallenge? DeviceFingerprintChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>human_interaction_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#human_interaction_challenge WaasWaasPolicy#human_interaction_challenge}
        /// </remarks>
        [JsiiProperty(name: "humanInteractionChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallenge\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallenge? HumanInteractionChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>js_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#js_challenge WaasWaasPolicy#js_challenge}
        /// </remarks>
        [JsiiProperty(name: "jsChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallenge\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallenge? JsChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#origin WaasWaasPolicy#origin}.</summary>
        [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Origin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#origin_groups WaasWaasPolicy#origin_groups}.</summary>
        [JsiiProperty(name: "originGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OriginGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>protection_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#protection_settings WaasWaasPolicy#protection_settings}
        /// </remarks>
        [JsiiProperty(name: "protectionSettings", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigProtectionSettings? ProtectionSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>whitelists block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#whitelists WaasWaasPolicy#whitelists}
        /// </remarks>
        [JsiiProperty(name: "whitelists", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigWhitelists\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Whitelists
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyWafConfig), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfig")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyWafConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#access_rules WaasWaasPolicy#access_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAccessRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AccessRules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>address_rate_limiting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#address_rate_limiting WaasWaasPolicy#address_rate_limiting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addressRateLimiting", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAddressRateLimiting\"}", isOptional: true)]
            public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAddressRateLimiting? AddressRateLimiting
            {
                get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAddressRateLimiting?>();
            }

            /// <summary>caching_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#caching_rules WaasWaasPolicy#caching_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cachingRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CachingRules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>captchas block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captchas WaasWaasPolicy#captchas}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "captchas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCaptchas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Captchas
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_protection_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#custom_protection_rules WaasWaasPolicy#custom_protection_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customProtectionRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCustomProtectionRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomProtectionRules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>device_fingerprint_challenge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#device_fingerprint_challenge WaasWaasPolicy#device_fingerprint_challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deviceFingerprintChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallenge\"}", isOptional: true)]
            public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallenge? DeviceFingerprintChallenge
            {
                get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallenge?>();
            }

            /// <summary>human_interaction_challenge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#human_interaction_challenge WaasWaasPolicy#human_interaction_challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "humanInteractionChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallenge\"}", isOptional: true)]
            public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallenge? HumanInteractionChallenge
            {
                get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallenge?>();
            }

            /// <summary>js_challenge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#js_challenge WaasWaasPolicy#js_challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jsChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallenge\"}", isOptional: true)]
            public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallenge? JsChallenge
            {
                get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallenge?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#origin WaasWaasPolicy#origin}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Origin
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#origin_groups WaasWaasPolicy#origin_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OriginGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>protection_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#protection_settings WaasWaasPolicy#protection_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protectionSettings", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettings\"}", isOptional: true)]
            public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigProtectionSettings? ProtectionSettings
            {
                get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigProtectionSettings?>();
            }

            /// <summary>whitelists block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#whitelists WaasWaasPolicy#whitelists}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "whitelists", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigWhitelists\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Whitelists
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
