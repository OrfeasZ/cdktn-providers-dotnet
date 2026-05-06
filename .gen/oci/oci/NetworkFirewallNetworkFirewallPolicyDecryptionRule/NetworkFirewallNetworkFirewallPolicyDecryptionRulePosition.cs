using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule
{
    [JsiiByValue(fqn: "oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRulePosition")]
    public class NetworkFirewallNetworkFirewallPolicyDecryptionRulePosition : oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRulePosition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#after_rule NetworkFirewallNetworkFirewallPolicyDecryptionRule#after_rule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "afterRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AfterRule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#before_rule NetworkFirewallNetworkFirewallPolicyDecryptionRule#before_rule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "beforeRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BeforeRule
        {
            get;
            set;
        }
    }
}
