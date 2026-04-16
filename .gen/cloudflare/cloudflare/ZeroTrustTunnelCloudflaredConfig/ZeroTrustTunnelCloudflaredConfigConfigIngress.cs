using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelCloudflaredConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngress")]
    public class ZeroTrustTunnelCloudflaredConfigConfigIngress : cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngress
    {
        /// <summary>Protocol and address of destination server.</summary>
        /// <remarks>
        /// Supported protocols: http://, https://, unix://, tcp://, ssh://, rdp://, unix+tls://, smb://. Alternatively can return a HTTP status code http_status:[code] e.g. 'http_status:404'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#service ZeroTrustTunnelCloudflaredConfigA#service}
        /// </remarks>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public string Service
        {
            get;
            set;
        }

        /// <summary>Public hostname for this service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#hostname ZeroTrustTunnelCloudflaredConfigA#hostname}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hostname
        {
            get;
            set;
        }

        /// <summary>Configuration parameters for the public hostname specific connection settings between cloudflared and origin server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#origin_request ZeroTrustTunnelCloudflaredConfigA#origin_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originRequest", typeJson: "{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequest\"}", isOptional: true)]
        public cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequest? OriginRequest
        {
            get;
            set;
        }

        /// <summary>Requests with this path route to this public hostname.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#path ZeroTrustTunnelCloudflaredConfigA#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
