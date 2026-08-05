using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelWarpConnectorConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious")]
    public class ZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious : cloudflare.ZeroTrustTunnelWarpConnectorConfig.IZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious
    {
        /// <summary>Virtual IP address (IPv4 or IPv6).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_tunnel_warp_connector_config#address ZeroTrustTunnelWarpConnectorConfigA#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }
    }
}
