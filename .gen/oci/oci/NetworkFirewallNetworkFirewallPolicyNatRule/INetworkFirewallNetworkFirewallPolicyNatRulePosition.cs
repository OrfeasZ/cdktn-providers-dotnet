using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyNatRule
{
    [JsiiInterface(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyNatRulePosition), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyNatRule.NetworkFirewallNetworkFirewallPolicyNatRulePosition")]
    public interface INetworkFirewallNetworkFirewallPolicyNatRulePosition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_nat_rule#after_rule NetworkFirewallNetworkFirewallPolicyNatRule#after_rule}.</summary>
        [JsiiProperty(name: "afterRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AfterRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_nat_rule#before_rule NetworkFirewallNetworkFirewallPolicyNatRule#before_rule}.</summary>
        [JsiiProperty(name: "beforeRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BeforeRule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyNatRulePosition), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyNatRule.NetworkFirewallNetworkFirewallPolicyNatRulePosition")]
        internal sealed class _Proxy : DeputyBase, oci.NetworkFirewallNetworkFirewallPolicyNatRule.INetworkFirewallNetworkFirewallPolicyNatRulePosition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_nat_rule#after_rule NetworkFirewallNetworkFirewallPolicyNatRule#after_rule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "afterRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AfterRule
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_nat_rule#before_rule NetworkFirewallNetworkFirewallPolicyNatRule#before_rule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "beforeRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BeforeRule
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
