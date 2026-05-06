using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilities), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilities")]
    public interface IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#key WafWebAppFirewallPolicy#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#version WafWebAppFirewallPolicy#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        double Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#action_name WafWebAppFirewallPolicy#action_name}.</summary>
        [JsiiProperty(name: "actionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#collaborative_action_threshold WafWebAppFirewallPolicy#collaborative_action_threshold}.</summary>
        [JsiiProperty(name: "collaborativeActionThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CollaborativeActionThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>collaborative_weights block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#collaborative_weights WafWebAppFirewallPolicy#collaborative_weights}
        /// </remarks>
        [JsiiProperty(name: "collaborativeWeights", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesCollaborativeWeights\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CollaborativeWeights
        {
            get
            {
                return null;
            }
        }

        /// <summary>exclusions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#exclusions WafWebAppFirewallPolicy#exclusions}
        /// </remarks>
        [JsiiProperty(name: "exclusions", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusions? Exclusions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilities), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilities")]
        internal sealed class _Proxy : DeputyBase, oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#key WafWebAppFirewallPolicy#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#version WafWebAppFirewallPolicy#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
            public double Version
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#action_name WafWebAppFirewallPolicy#action_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#collaborative_action_threshold WafWebAppFirewallPolicy#collaborative_action_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "collaborativeActionThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CollaborativeActionThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>collaborative_weights block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#collaborative_weights WafWebAppFirewallPolicy#collaborative_weights}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "collaborativeWeights", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesCollaborativeWeights\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CollaborativeWeights
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>exclusions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#exclusions WafWebAppFirewallPolicy#exclusions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclusions", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusions\"}", isOptional: true)]
            public oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusions? Exclusions
            {
                get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusions?>();
            }
        }
    }
}
