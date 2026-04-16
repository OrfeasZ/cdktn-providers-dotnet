using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelCloudflaredConfig
{
    [JsiiInterface(nativeType: typeof(IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess), fullyQualifiedName: "cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess")]
    public interface IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess
    {
        /// <summary>Access applications that are allowed to reach this hostname for this Tunnel.</summary>
        /// <remarks>
        /// Audience tags can be identified in the dashboard or via the List Access policies API.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#aud_tag ZeroTrustTunnelCloudflaredConfigA#aud_tag}
        /// </remarks>
        [JsiiProperty(name: "audTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AudTag
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#team_name ZeroTrustTunnelCloudflaredConfigA#team_name}.</summary>
        [JsiiProperty(name: "teamName", typeJson: "{\"primitive\":\"string\"}")]
        string TeamName
        {
            get;
        }

        /// <summary>Deny traffic that has not fulfilled Access authorization.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#required ZeroTrustTunnelCloudflaredConfigA#required}
        /// </remarks>
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Required
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess), fullyQualifiedName: "cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Access applications that are allowed to reach this hostname for this Tunnel.</summary>
            /// <remarks>
            /// Audience tags can be identified in the dashboard or via the List Access policies API.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#aud_tag ZeroTrustTunnelCloudflaredConfigA#aud_tag}
            /// </remarks>
            [JsiiProperty(name: "audTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AudTag
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#team_name ZeroTrustTunnelCloudflaredConfigA#team_name}.</summary>
            [JsiiProperty(name: "teamName", typeJson: "{\"primitive\":\"string\"}")]
            public string TeamName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Deny traffic that has not fulfilled Access authorization.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#required ZeroTrustTunnelCloudflaredConfigA#required}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Required
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
