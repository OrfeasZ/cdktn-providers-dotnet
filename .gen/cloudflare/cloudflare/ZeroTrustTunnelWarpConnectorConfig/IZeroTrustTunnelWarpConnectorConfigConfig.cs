using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelWarpConnectorConfig
{
    [JsiiInterface(nativeType: typeof(IZeroTrustTunnelWarpConnectorConfigConfig), fullyQualifiedName: "cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigConfig")]
    public interface IZeroTrustTunnelWarpConnectorConfigConfig
    {
        /// <summary>Floating Network Resource ID — the secondary ENI that is moved between nodes on failover.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/zero_trust_tunnel_warp_connector_config#fnr_id ZeroTrustTunnelWarpConnectorConfigA#fnr_id}
        /// </remarks>
        [JsiiProperty(name: "fnrId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FnrId
        {
            get
            {
                return null;
            }
        }

        /// <summary>VIPs to assign on the CloudflareWARP interface.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/zero_trust_tunnel_warp_connector_config#vips ZeroTrustTunnelWarpConnectorConfigA#vips}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.ZeroTrustTunnelWarpConnectorConfig.IZeroTrustTunnelWarpConnectorConfigConfigVips" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "vips", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigConfigVips\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Vips
        {
            get
            {
                return null;
            }
        }

        /// <summary>VIPs to clean up on demotion or version drift.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/zero_trust_tunnel_warp_connector_config#vips_previous ZeroTrustTunnelWarpConnectorConfigA#vips_previous}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.ZeroTrustTunnelWarpConnectorConfig.IZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "vipsPrevious", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VipsPrevious
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustTunnelWarpConnectorConfigConfig), fullyQualifiedName: "cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustTunnelWarpConnectorConfig.IZeroTrustTunnelWarpConnectorConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Floating Network Resource ID — the secondary ENI that is moved between nodes on failover.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/zero_trust_tunnel_warp_connector_config#fnr_id ZeroTrustTunnelWarpConnectorConfigA#fnr_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fnrId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FnrId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>VIPs to assign on the CloudflareWARP interface.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/zero_trust_tunnel_warp_connector_config#vips ZeroTrustTunnelWarpConnectorConfigA#vips}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.ZeroTrustTunnelWarpConnectorConfig.IZeroTrustTunnelWarpConnectorConfigConfigVips" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vips", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigConfigVips\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Vips
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>VIPs to clean up on demotion or version drift.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/zero_trust_tunnel_warp_connector_config#vips_previous ZeroTrustTunnelWarpConnectorConfigA#vips_previous}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.ZeroTrustTunnelWarpConnectorConfig.IZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vipsPrevious", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigConfigVipsPrevious\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VipsPrevious
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
