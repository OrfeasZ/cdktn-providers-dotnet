using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.S2SVpnConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.s2SVpnConnection.S2SVpnConnectionBgpConfigIpv4")]
    public class S2SVpnConnectionBgpConfigIpv4 : scaleway.S2SVpnConnection.IS2SVpnConnectionBgpConfigIpv4
    {
        /// <summary>The ID of the routing policy to use for BGP route filtering.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#routing_policy_id S2SVpnConnection#routing_policy_id}
        /// </remarks>
        [JsiiProperty(name: "routingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public string RoutingPolicyId
        {
            get;
            set;
        }

        /// <summary>The BGP peer IP on customer side.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#peer_private_ip S2SVpnConnection#peer_private_ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "peerPrivateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerPrivateIp
        {
            get;
            set;
        }

        /// <summary>The BGP peer IP on Scaleway side.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#private_ip S2SVpnConnection#private_ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIp
        {
            get;
            set;
        }
    }
}
