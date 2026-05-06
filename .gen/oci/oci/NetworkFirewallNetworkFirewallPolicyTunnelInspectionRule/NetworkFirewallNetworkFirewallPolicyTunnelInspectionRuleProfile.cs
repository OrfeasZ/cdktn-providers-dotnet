using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule
{
    [JsiiByValue(fqn: "oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile")]
    public class NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile : oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile
    {
        private object? _mustReturnTrafficToSource;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#must_return_traffic_to_source NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#must_return_traffic_to_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mustReturnTrafficToSource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MustReturnTrafficToSource
        {
            get => _mustReturnTrafficToSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mustReturnTrafficToSource = value;
            }
        }
    }
}
