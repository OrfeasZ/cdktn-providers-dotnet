using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IWafWebAppFirewallPolicyRequestProtectionRules), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionRules")]
    public interface IWafWebAppFirewallPolicyRequestProtectionRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#action_name WafWebAppFirewallPolicy#action_name}.</summary>
        [JsiiProperty(name: "actionName", typeJson: "{\"primitive\":\"string\"}")]
        string ActionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#name WafWebAppFirewallPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>protection_capabilities block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#protection_capabilities WafWebAppFirewallPolicy#protection_capabilities}
        /// </remarks>
        [JsiiProperty(name: "protectionCapabilities", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionRulesProtectionCapabilities\"},\"kind\":\"array\"}}]}}")]
        object ProtectionCapabilities
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#type WafWebAppFirewallPolicy#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#condition WafWebAppFirewallPolicy#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#condition_language WafWebAppFirewallPolicy#condition_language}.</summary>
        [JsiiProperty(name: "conditionLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConditionLanguage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#is_body_inspection_enabled WafWebAppFirewallPolicy#is_body_inspection_enabled}.</summary>
        [JsiiProperty(name: "isBodyInspectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsBodyInspectionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>protection_capability_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#protection_capability_settings WafWebAppFirewallPolicy#protection_capability_settings}
        /// </remarks>
        [JsiiProperty(name: "protectionCapabilitySettings", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionRulesProtectionCapabilitySettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestProtectionRulesProtectionCapabilitySettings? ProtectionCapabilitySettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAppFirewallPolicyRequestProtectionRules), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionRules")]
        internal sealed class _Proxy : DeputyBase, oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestProtectionRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#action_name WafWebAppFirewallPolicy#action_name}.</summary>
            [JsiiProperty(name: "actionName", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#name WafWebAppFirewallPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>protection_capabilities block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#protection_capabilities WafWebAppFirewallPolicy#protection_capabilities}
            /// </remarks>
            [JsiiProperty(name: "protectionCapabilities", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionRulesProtectionCapabilities\"},\"kind\":\"array\"}}]}}")]
            public object ProtectionCapabilities
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#type WafWebAppFirewallPolicy#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#condition WafWebAppFirewallPolicy#condition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Condition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#condition_language WafWebAppFirewallPolicy#condition_language}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conditionLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConditionLanguage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#is_body_inspection_enabled WafWebAppFirewallPolicy#is_body_inspection_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isBodyInspectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsBodyInspectionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>protection_capability_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#protection_capability_settings WafWebAppFirewallPolicy#protection_capability_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protectionCapabilitySettings", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionRulesProtectionCapabilitySettings\"}", isOptional: true)]
            public oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestProtectionRulesProtectionCapabilitySettings? ProtectionCapabilitySettings
            {
                get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestProtectionRulesProtectionCapabilitySettings?>();
            }
        }
    }
}
