using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.S2SVpnGateway
{
    [JsiiByValue(fqn: "scaleway.s2SVpnGateway.S2SVpnGatewayPublicConfig")]
    public class S2SVpnGatewayPublicConfig : scaleway.S2SVpnGateway.IS2SVpnGatewayPublicConfig
    {
        /// <summary>The ID of the IPAM IPv4 address to use as the public IP for the VPN gateway.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_gateway#ipam_ipv4_id S2SVpnGateway#ipam_ipv4_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipamIpv4Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpamIpv4Id
        {
            get;
            set;
        }

        /// <summary>The ID of the IPAM IPv6 address to use as the public IP for the VPN gateway.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_gateway#ipam_ipv6_id S2SVpnGateway#ipam_ipv6_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipamIpv6Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpamIpv6Id
        {
            get;
            set;
        }
    }
}
