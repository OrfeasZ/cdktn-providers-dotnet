using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.S2SVpnConnection
{
    [JsiiInterface(nativeType: typeof(IS2SVpnConnectionBgpConfigIpv6), fullyQualifiedName: "scaleway.s2SVpnConnection.S2SVpnConnectionBgpConfigIpv6")]
    public interface IS2SVpnConnectionBgpConfigIpv6
    {
        /// <summary>The ID of the routing policy to use for BGP route filtering.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#routing_policy_id S2SVpnConnection#routing_policy_id}
        /// </remarks>
        [JsiiProperty(name: "routingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string RoutingPolicyId
        {
            get;
        }

        /// <summary>The BGP peer IP on customer side.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#peer_private_ip S2SVpnConnection#peer_private_ip}
        /// </remarks>
        [JsiiProperty(name: "peerPrivateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerPrivateIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>The BGP peer IP on Scaleway side.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#private_ip S2SVpnConnection#private_ip}
        /// </remarks>
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS2SVpnConnectionBgpConfigIpv6), fullyQualifiedName: "scaleway.s2SVpnConnection.S2SVpnConnectionBgpConfigIpv6")]
        internal sealed class _Proxy : DeputyBase, scaleway.S2SVpnConnection.IS2SVpnConnectionBgpConfigIpv6
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the routing policy to use for BGP route filtering.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#routing_policy_id S2SVpnConnection#routing_policy_id}
            /// </remarks>
            [JsiiProperty(name: "routingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string RoutingPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The BGP peer IP on customer side.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#peer_private_ip S2SVpnConnection#peer_private_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "peerPrivateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerPrivateIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The BGP peer IP on Scaleway side.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#private_ip S2SVpnConnection#private_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateIp
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
