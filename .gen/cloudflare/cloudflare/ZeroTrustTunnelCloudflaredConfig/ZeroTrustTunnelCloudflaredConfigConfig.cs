using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelCloudflaredConfig
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfig")]
    public class ZeroTrustTunnelCloudflaredConfigConfig : cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfig
    {
        private object? _ingress;

        /// <summary>List of public hostname definitions. At least one ingress rule needs to be defined for the tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#ingress ZeroTrustTunnelCloudflaredConfigA#ingress}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ingress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ingress
        {
            get => _ingress;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngress[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngress).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ingress = value;
            }
        }

        /// <summary>Configuration parameters for the public hostname specific connection settings between cloudflared and origin server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#origin_request ZeroTrustTunnelCloudflaredConfigA#origin_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originRequest", typeJson: "{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOriginRequest\"}", isOptional: true)]
        public cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigOriginRequest? OriginRequest
        {
            get;
            set;
        }
    }
}
