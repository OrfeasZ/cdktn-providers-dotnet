using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelCloudflaredConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess")]
    public class ZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess : cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess
    {
        /// <summary>Access applications that are allowed to reach this hostname for this Tunnel.</summary>
        /// <remarks>
        /// Audience tags can be identified in the dashboard or via the List Access policies API.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#aud_tag ZeroTrustTunnelCloudflaredConfigA#aud_tag}
        /// </remarks>
        [JsiiProperty(name: "audTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AudTag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#team_name ZeroTrustTunnelCloudflaredConfigA#team_name}.</summary>
        [JsiiProperty(name: "teamName", typeJson: "{\"primitive\":\"string\"}")]
        public string TeamName
        {
            get;
            set;
        }

        private object? _required;

        /// <summary>Deny traffic that has not fulfilled Access authorization.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#required ZeroTrustTunnelCloudflaredConfigA#required}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Required
        {
            get => _required;
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
                _required = value;
            }
        }
    }
}
