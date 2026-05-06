using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyUrlList
{
    [JsiiByValue(fqn: "oci.networkFirewallNetworkFirewallPolicyUrlList.NetworkFirewallNetworkFirewallPolicyUrlListTimeouts")]
    public class NetworkFirewallNetworkFirewallPolicyUrlListTimeouts : oci.NetworkFirewallNetworkFirewallPolicyUrlList.INetworkFirewallNetworkFirewallPolicyUrlListTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_url_list#create NetworkFirewallNetworkFirewallPolicyUrlList#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_url_list#delete NetworkFirewallNetworkFirewallPolicyUrlList#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_url_list#update NetworkFirewallNetworkFirewallPolicyUrlList#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
