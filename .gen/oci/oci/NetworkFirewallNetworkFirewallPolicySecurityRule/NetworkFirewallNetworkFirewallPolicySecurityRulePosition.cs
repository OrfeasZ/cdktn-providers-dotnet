using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicySecurityRule
{
    [JsiiByValue(fqn: "oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRulePosition")]
    public class NetworkFirewallNetworkFirewallPolicySecurityRulePosition : oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRulePosition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#after_rule NetworkFirewallNetworkFirewallPolicySecurityRule#after_rule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "afterRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AfterRule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#before_rule NetworkFirewallNetworkFirewallPolicySecurityRule#before_rule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "beforeRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BeforeRule
        {
            get;
            set;
        }
    }
}
