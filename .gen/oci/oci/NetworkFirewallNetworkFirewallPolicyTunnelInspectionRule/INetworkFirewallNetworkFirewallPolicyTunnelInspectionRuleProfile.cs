using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule
{
    [JsiiInterface(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile")]
    public interface INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#must_return_traffic_to_source NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#must_return_traffic_to_source}.</summary>
        [JsiiProperty(name: "mustReturnTrafficToSource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MustReturnTrafficToSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile")]
        internal sealed class _Proxy : DeputyBase, oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#must_return_traffic_to_source NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#must_return_traffic_to_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mustReturnTrafficToSource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MustReturnTrafficToSource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
