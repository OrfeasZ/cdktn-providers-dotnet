using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyNatRule
{
    [JsiiByValue(fqn: "oci.networkFirewallNetworkFirewallPolicyNatRule.NetworkFirewallNetworkFirewallPolicyNatRuleCondition")]
    public class NetworkFirewallNetworkFirewallPolicyNatRuleCondition : oci.NetworkFirewallNetworkFirewallPolicyNatRule.INetworkFirewallNetworkFirewallPolicyNatRuleCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_nat_rule#destination_address NetworkFirewallNetworkFirewallPolicyNatRule#destination_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DestinationAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_nat_rule#service NetworkFirewallNetworkFirewallPolicyNatRule#service}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Service
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_nat_rule#source_address NetworkFirewallNetworkFirewallPolicyNatRule#source_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SourceAddress
        {
            get;
            set;
        }
    }
}
