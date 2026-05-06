using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyNatRule
{
    [JsiiByValue(fqn: "oci.networkFirewallNetworkFirewallPolicyNatRule.NetworkFirewallNetworkFirewallPolicyNatRulePosition")]
    public class NetworkFirewallNetworkFirewallPolicyNatRulePosition : oci.NetworkFirewallNetworkFirewallPolicyNatRule.INetworkFirewallNetworkFirewallPolicyNatRulePosition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_nat_rule#after_rule NetworkFirewallNetworkFirewallPolicyNatRule#after_rule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "afterRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AfterRule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_nat_rule#before_rule NetworkFirewallNetworkFirewallPolicyNatRule#before_rule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "beforeRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BeforeRule
        {
            get;
            set;
        }
    }
}
