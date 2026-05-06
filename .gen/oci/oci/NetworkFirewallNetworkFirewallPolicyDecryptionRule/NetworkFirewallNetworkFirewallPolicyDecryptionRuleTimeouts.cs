using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule
{
    [JsiiByValue(fqn: "oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRuleTimeouts")]
    public class NetworkFirewallNetworkFirewallPolicyDecryptionRuleTimeouts : oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#create NetworkFirewallNetworkFirewallPolicyDecryptionRule#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#delete NetworkFirewallNetworkFirewallPolicyDecryptionRule#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#update NetworkFirewallNetworkFirewallPolicyDecryptionRule#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
