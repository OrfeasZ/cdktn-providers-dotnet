using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanGreTunnel
{
    [JsiiInterface(nativeType: typeof(IMagicWanGreTunnelHealthCheckTarget), fullyQualifiedName: "cloudflare.magicWanGreTunnel.MagicWanGreTunnelHealthCheckTarget")]
    public interface IMagicWanGreTunnelHealthCheckTarget
    {
        /// <summary>The saved health check target.</summary>
        /// <remarks>
        /// Setting the value to the empty string indicates that the calculated default value will be used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_gre_tunnel#saved MagicWanGreTunnel#saved}
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

        [JsiiTypeProxy(nativeType: typeof(IMagicWanGreTunnelHealthCheckTarget), fullyQualifiedName: "cloudflare.magicWanGreTunnel.MagicWanGreTunnelHealthCheckTarget")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicWanGreTunnel.IMagicWanGreTunnelHealthCheckTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The saved health check target.</summary>
            /// <remarks>
            /// Setting the value to the empty string indicates that the calculated default value will be used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_gre_tunnel#saved MagicWanGreTunnel#saved}
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
