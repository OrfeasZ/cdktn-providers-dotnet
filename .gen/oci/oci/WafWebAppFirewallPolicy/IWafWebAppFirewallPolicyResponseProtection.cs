using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IWafWebAppFirewallPolicyResponseProtection), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtection")]
    public interface IWafWebAppFirewallPolicyResponseProtection
    {
        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#rules WafWebAppFirewallPolicy#rules}
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAppFirewallPolicyResponseProtection), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtection")]
        internal sealed class _Proxy : DeputyBase, oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#rules WafWebAppFirewallPolicy#rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rules
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
