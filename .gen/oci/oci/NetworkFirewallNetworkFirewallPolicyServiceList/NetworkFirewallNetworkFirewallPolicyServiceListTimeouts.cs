using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyServiceList
{
    [JsiiByValue(fqn: "oci.networkFirewallNetworkFirewallPolicyServiceList.NetworkFirewallNetworkFirewallPolicyServiceListTimeouts")]
    public class NetworkFirewallNetworkFirewallPolicyServiceListTimeouts : oci.NetworkFirewallNetworkFirewallPolicyServiceList.INetworkFirewallNetworkFirewallPolicyServiceListTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_service_list#create NetworkFirewallNetworkFirewallPolicyServiceList#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_service_list#delete NetworkFirewallNetworkFirewallPolicyServiceList#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_service_list#update NetworkFirewallNetworkFirewallPolicyServiceList#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
