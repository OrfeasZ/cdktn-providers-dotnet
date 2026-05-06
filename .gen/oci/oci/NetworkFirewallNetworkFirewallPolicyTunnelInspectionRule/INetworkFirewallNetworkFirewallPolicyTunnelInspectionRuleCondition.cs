using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule
{
    [JsiiInterface(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition")]
    public interface INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#destination_address NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#destination_address}.</summary>
        [JsiiProperty(name: "destinationAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DestinationAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#source_address NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#source_address}.</summary>
        [JsiiProperty(name: "sourceAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourceAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition")]
        internal sealed class _Proxy : DeputyBase, oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#destination_address NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#destination_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DestinationAddress
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#source_address NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#source_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourceAddress
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
