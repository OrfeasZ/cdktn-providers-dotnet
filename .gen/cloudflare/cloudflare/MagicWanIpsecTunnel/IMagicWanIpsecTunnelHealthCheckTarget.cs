using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanIpsecTunnel
{
    [JsiiInterface(nativeType: typeof(IMagicWanIpsecTunnelHealthCheckTarget), fullyQualifiedName: "cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheckTarget")]
    public interface IMagicWanIpsecTunnelHealthCheckTarget
    {
        /// <summary>The saved health check target.</summary>
        /// <remarks>
        /// Setting the value to the empty string indicates that the calculated default value will be used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#saved MagicWanIpsecTunnel#saved}
        /// </remarks>
        [JsiiProperty(name: "saved", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Saved
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicWanIpsecTunnelHealthCheckTarget), fullyQualifiedName: "cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheckTarget")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelHealthCheckTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The saved health check target.</summary>
            /// <remarks>
            /// Setting the value to the empty string indicates that the calculated default value will be used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#saved MagicWanIpsecTunnel#saved}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "saved", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Saved
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
