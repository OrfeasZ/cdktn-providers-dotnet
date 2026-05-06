using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.networkFirewallNetworkFirewallPolicyService.NetworkFirewallNetworkFirewallPolicyServicePortRanges")]
    public class NetworkFirewallNetworkFirewallPolicyServicePortRanges : oci.NetworkFirewallNetworkFirewallPolicyService.INetworkFirewallNetworkFirewallPolicyServicePortRanges
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_service#minimum_port NetworkFirewallNetworkFirewallPolicyService#minimum_port}.</summary>
        [JsiiProperty(name: "minimumPort", typeJson: "{\"primitive\":\"number\"}")]
        public double MinimumPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_service#maximum_port NetworkFirewallNetworkFirewallPolicyService#maximum_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumPort
        {
            get;
            set;
        }
    }
}
