using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelCloudflaredConfig
{
    [JsiiInterface(nativeType: typeof(IZeroTrustTunnelCloudflaredConfigConfig), fullyQualifiedName: "cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfig")]
    public interface IZeroTrustTunnelCloudflaredConfigConfig
    {
        /// <summary>List of public hostname definitions. At least one ingress rule needs to be defined for the tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#ingress ZeroTrustTunnelCloudflaredConfigA#ingress}
        /// </remarks>
        [JsiiProperty(name: "ingress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ingress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configuration parameters for the public hostname specific connection settings between cloudflared and origin server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#origin_request ZeroTrustTunnelCloudflaredConfigA#origin_request}
        /// </remarks>
        [JsiiProperty(name: "originRequest", typeJson: "{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOriginRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigOriginRequest? OriginRequest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustTunnelCloudflaredConfigConfig), fullyQualifiedName: "cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of public hostname definitions. At least one ingress rule needs to be defined for the tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#ingress ZeroTrustTunnelCloudflaredConfigA#ingress}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ingress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ingress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configuration parameters for the public hostname specific connection settings between cloudflared and origin server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#origin_request ZeroTrustTunnelCloudflaredConfigA#origin_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originRequest", typeJson: "{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOriginRequest\"}", isOptional: true)]
            public cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigOriginRequest? OriginRequest
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigOriginRequest?>();
            }
        }
    }
}
