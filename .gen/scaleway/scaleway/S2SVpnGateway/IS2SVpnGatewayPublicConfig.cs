using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.S2SVpnGateway
{
    [JsiiInterface(nativeType: typeof(IS2SVpnGatewayPublicConfig), fullyQualifiedName: "scaleway.s2SVpnGateway.S2SVpnGatewayPublicConfig")]
    public interface IS2SVpnGatewayPublicConfig
    {
        /// <summary>The ID of the IPAM IPv4 address to use as the public IP for the VPN gateway.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/s2s_vpn_gateway#ipam_ipv4_id S2SVpnGateway#ipam_ipv4_id}
        /// </remarks>
        [JsiiProperty(name: "ipamIpv4Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpamIpv4Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the IPAM IPv6 address to use as the public IP for the VPN gateway.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/s2s_vpn_gateway#ipam_ipv6_id S2SVpnGateway#ipam_ipv6_id}
        /// </remarks>
        [JsiiProperty(name: "ipamIpv6Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpamIpv6Id
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS2SVpnGatewayPublicConfig), fullyQualifiedName: "scaleway.s2SVpnGateway.S2SVpnGatewayPublicConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.S2SVpnGateway.IS2SVpnGatewayPublicConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the IPAM IPv4 address to use as the public IP for the VPN gateway.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/s2s_vpn_gateway#ipam_ipv4_id S2SVpnGateway#ipam_ipv4_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipamIpv4Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpamIpv4Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the IPAM IPv6 address to use as the public IP for the VPN gateway.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/s2s_vpn_gateway#ipam_ipv6_id S2SVpnGateway#ipam_ipv6_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipamIpv6Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpamIpv6Id
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
