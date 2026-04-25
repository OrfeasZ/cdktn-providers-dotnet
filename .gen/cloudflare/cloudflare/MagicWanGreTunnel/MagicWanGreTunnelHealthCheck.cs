using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanGreTunnel
{
    [JsiiByValue(fqn: "cloudflare.magicWanGreTunnel.MagicWanGreTunnelHealthCheck")]
    public class MagicWanGreTunnelHealthCheck : cloudflare.MagicWanGreTunnel.IMagicWanGreTunnelHealthCheck
    {
        /// <summary>The direction of the flow of the healthcheck.</summary>
        /// <remarks>
        /// Either unidirectional, where the probe comes to you via the tunnel and the result comes back to Cloudflare via the open Internet, or bidirectional where both the probe and result come and go via the tunnel.
        /// Available values: "unidirectional", "bidirectional".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_gre_tunnel#direction MagicWanGreTunnel#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Determines whether to run healthchecks for a tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_gre_tunnel#enabled MagicWanGreTunnel#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>How frequent the health check is run. The default value is `mid`. Available values: "low", "mid", "high".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_gre_tunnel#rate MagicWanGreTunnel#rate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Rate
        {
            get;
            set;
        }

        /// <summary>The destination address in a request type health check.</summary>
        /// <remarks>
        /// After the healthcheck is decapsulated at the customer end of the tunnel, the ICMP echo will be forwarded to this address. This field defaults to <c>customer_gre_endpoint address</c>. This field is ignored for bidirectional healthchecks as the interface_address (not assigned to the Cloudflare side of the tunnel) is used as the target. Must be in object form if the x-magic-new-hc-target header is set to true and string form if x-magic-new-hc-target is absent or set to false.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_gre_tunnel#target MagicWanGreTunnel#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"cloudflare.magicWanGreTunnel.MagicWanGreTunnelHealthCheckTarget\"}", isOptional: true)]
        public cloudflare.MagicWanGreTunnel.IMagicWanGreTunnelHealthCheckTarget? Target
        {
            get;
            set;
        }

        /// <summary>The type of healthcheck to run, reply or request. The default value is `reply`. Available values: "reply", "request".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_gre_tunnel#type MagicWanGreTunnel#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
