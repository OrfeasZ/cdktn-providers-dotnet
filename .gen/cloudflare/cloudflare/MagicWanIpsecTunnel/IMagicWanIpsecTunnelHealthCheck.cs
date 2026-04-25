using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanIpsecTunnel
{
    [JsiiInterface(nativeType: typeof(IMagicWanIpsecTunnelHealthCheck), fullyQualifiedName: "cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheck")]
    public interface IMagicWanIpsecTunnelHealthCheck
    {
        /// <summary>The direction of the flow of the healthcheck.</summary>
        /// <remarks>
        /// Either unidirectional, where the probe comes to you via the tunnel and the result comes back to Cloudflare via the open Internet, or bidirectional where both the probe and result come and go via the tunnel.
        /// Available values: "unidirectional", "bidirectional".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#direction MagicWanIpsecTunnel#direction}
        /// </remarks>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines whether to run healthchecks for a tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#enabled MagicWanIpsecTunnel#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>How frequent the health check is run. The default value is `mid`. Available values: "low", "mid", "high".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#rate MagicWanIpsecTunnel#rate}
        /// </remarks>
        [JsiiProperty(name: "rate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Rate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The destination address in a request type health check.</summary>
        /// <remarks>
        /// After the healthcheck is decapsulated at the customer end of the tunnel, the ICMP echo will be forwarded to this address. This field defaults to <c>customer_gre_endpoint address</c>. This field is ignored for bidirectional healthchecks as the interface_address (not assigned to the Cloudflare side of the tunnel) is used as the target. Must be in object form if the x-magic-new-hc-target header is set to true and string form if x-magic-new-hc-target is absent or set to false.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#target MagicWanIpsecTunnel#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheckTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelHealthCheckTarget? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of healthcheck to run, reply or request. The default value is `reply`. Available values: "reply", "request".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#type MagicWanIpsecTunnel#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicWanIpsecTunnelHealthCheck), fullyQualifiedName: "cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheck")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelHealthCheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The direction of the flow of the healthcheck.</summary>
            /// <remarks>
            /// Either unidirectional, where the probe comes to you via the tunnel and the result comes back to Cloudflare via the open Internet, or bidirectional where both the probe and result come and go via the tunnel.
            /// Available values: "unidirectional", "bidirectional".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#direction MagicWanIpsecTunnel#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Determines whether to run healthchecks for a tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#enabled MagicWanIpsecTunnel#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>How frequent the health check is run. The default value is `mid`. Available values: "low", "mid", "high".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#rate MagicWanIpsecTunnel#rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Rate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The destination address in a request type health check.</summary>
            /// <remarks>
            /// After the healthcheck is decapsulated at the customer end of the tunnel, the ICMP echo will be forwarded to this address. This field defaults to <c>customer_gre_endpoint address</c>. This field is ignored for bidirectional healthchecks as the interface_address (not assigned to the Cloudflare side of the tunnel) is used as the target. Must be in object form if the x-magic-new-hc-target header is set to true and string form if x-magic-new-hc-target is absent or set to false.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#target MagicWanIpsecTunnel#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheckTarget\"}", isOptional: true)]
            public cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelHealthCheckTarget? Target
            {
                get => GetInstanceProperty<cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelHealthCheckTarget?>();
            }

            /// <summary>The type of healthcheck to run, reply or request. The default value is `reply`. Available values: "reply", "request".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#type MagicWanIpsecTunnel#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
