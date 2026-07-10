using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelWarpConnectorConfig
{
    [JsiiInterface(nativeType: typeof(IZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious), fullyQualifiedName: "cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious")]
    public interface IZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious
    {
        /// <summary>Virtual IP address (IPv4 or IPv6).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/zero_trust_tunnel_warp_connector_config#address ZeroTrustTunnelWarpConnectorConfigA#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious), fullyQualifiedName: "cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustTunnelWarpConnectorConfig.IZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Virtual IP address (IPv4 or IPv6).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/zero_trust_tunnel_warp_connector_config#address ZeroTrustTunnelWarpConnectorConfigA#address}
            /// </remarks>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
