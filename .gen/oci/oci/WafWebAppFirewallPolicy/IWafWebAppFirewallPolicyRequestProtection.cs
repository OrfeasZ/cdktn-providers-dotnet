using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IWafWebAppFirewallPolicyRequestProtection), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtection")]
    public interface IWafWebAppFirewallPolicyRequestProtection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#body_inspection_size_limit_exceeded_action_name WafWebAppFirewallPolicy#body_inspection_size_limit_exceeded_action_name}.</summary>
        [JsiiProperty(name: "bodyInspectionSizeLimitExceededActionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BodyInspectionSizeLimitExceededActionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#body_inspection_size_limit_in_bytes WafWebAppFirewallPolicy#body_inspection_size_limit_in_bytes}.</summary>
        [JsiiProperty(name: "bodyInspectionSizeLimitInBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BodyInspectionSizeLimitInBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#rules WafWebAppFirewallPolicy#rules}
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAppFirewallPolicyRequestProtection), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtection")]
        internal sealed class _Proxy : DeputyBase, oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestProtection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#body_inspection_size_limit_exceeded_action_name WafWebAppFirewallPolicy#body_inspection_size_limit_exceeded_action_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bodyInspectionSizeLimitExceededActionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BodyInspectionSizeLimitExceededActionName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#body_inspection_size_limit_in_bytes WafWebAppFirewallPolicy#body_inspection_size_limit_in_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bodyInspectionSizeLimitInBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BodyInspectionSizeLimitInBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#rules WafWebAppFirewallPolicy#rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rules
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
