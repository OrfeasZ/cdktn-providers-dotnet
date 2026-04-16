using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelCloudflaredConfig
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOriginRequest")]
    public class ZeroTrustTunnelCloudflaredConfigConfigOriginRequest : cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigOriginRequest
    {
        /// <summary>For all L7 requests to this hostname, cloudflared will validate each request's Cf-Access-Jwt-Assertion request header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#access ZeroTrustTunnelCloudflaredConfigA#access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOriginRequestAccess\"}", isOptional: true)]
        public cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigOriginRequestAccess? Access
        {
            get;
            set;
        }

        /// <summary>Path to the certificate authority (CA) for the certificate of your origin.</summary>
        /// <remarks>
        /// This option should be used only if your certificate is not signed by Cloudflare.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#ca_pool ZeroTrustTunnelCloudflaredConfigA#ca_pool}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "caPool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaPool
        {
            get;
            set;
        }

        /// <summary>Timeout for establishing a new TCP connection to your origin server.</summary>
        /// <remarks>
        /// This excludes the time taken to establish TLS, which is controlled by tlsTimeout.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#connect_timeout ZeroTrustTunnelCloudflaredConfigA#connect_timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectTimeout
        {
            get;
            set;
        }

        private object? _disableChunkedEncoding;

        /// <summary>Disables chunked transfer encoding. Useful if you are running a WSGI server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#disable_chunked_encoding ZeroTrustTunnelCloudflaredConfigA#disable_chunked_encoding}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disableChunkedEncoding", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableChunkedEncoding
        {
            get => _disableChunkedEncoding;
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
                _disableChunkedEncoding = value;
            }
        }

        private object? _http2Origin;

        /// <summary>Attempt to connect to origin using HTTP2. Origin must be configured as https.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#http2_origin ZeroTrustTunnelCloudflaredConfigA#http2_origin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http2Origin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Http2Origin
        {
            get => _http2Origin;
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
                _http2Origin = value;
            }
        }

        /// <summary>Sets the HTTP Host header on requests sent to the local service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#http_host_header ZeroTrustTunnelCloudflaredConfigA#http_host_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpHostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpHostHeader
        {
            get;
            set;
        }

        /// <summary>Maximum number of idle keepalive connections between Tunnel and your origin.</summary>
        /// <remarks>
        /// This does not restrict the total number of concurrent connections.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#keep_alive_connections ZeroTrustTunnelCloudflaredConfigA#keep_alive_connections}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keepAliveConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KeepAliveConnections
        {
            get;
            set;
        }

        /// <summary>Timeout after which an idle keepalive connection can be discarded.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#keep_alive_timeout ZeroTrustTunnelCloudflaredConfigA#keep_alive_timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keepAliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KeepAliveTimeout
        {
            get;
            set;
        }

        private object? _matchSnItoHost;

        /// <summary>Auto configure the Hostname on the origin server certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#match_sn_ito_host ZeroTrustTunnelCloudflaredConfigA#match_sn_ito_host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchSnItoHost", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MatchSnItoHost
        {
            get => _matchSnItoHost;
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
                _matchSnItoHost = value;
            }
        }

        private object? _noHappyEyeballs;

        /// <summary>Disable the “happy eyeballs” algorithm for IPv4/IPv6 fallback if your local network has misconfigured one of the protocols.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#no_happy_eyeballs ZeroTrustTunnelCloudflaredConfigA#no_happy_eyeballs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noHappyEyeballs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? NoHappyEyeballs
        {
            get => _noHappyEyeballs;
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
                _noHappyEyeballs = value;
            }
        }

        private object? _noTlsVerify;

        /// <summary>Disables TLS verification of the certificate presented by your origin.</summary>
        /// <remarks>
        /// Will allow any certificate from the origin to be accepted.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#no_tls_verify ZeroTrustTunnelCloudflaredConfigA#no_tls_verify}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noTlsVerify", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? NoTlsVerify
        {
            get => _noTlsVerify;
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
                _noTlsVerify = value;
            }
        }

        /// <summary>Hostname that cloudflared should expect from your origin server certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#origin_server_name ZeroTrustTunnelCloudflaredConfigA#origin_server_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originServerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginServerName
        {
            get;
            set;
        }

        /// <summary>cloudflared starts a proxy server to translate HTTP traffic into TCP when proxying, for example, SSH or RDP.</summary>
        /// <remarks>
        /// This configures what type of proxy will be started. Valid options are: "" for the regular proxy and "socks" for a SOCKS5 proxy.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#proxy_type ZeroTrustTunnelCloudflaredConfigA#proxy_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "proxyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProxyType
        {
            get;
            set;
        }

        /// <summary>The timeout after which a TCP keepalive packet is sent on a connection between Tunnel and the origin server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#tcp_keep_alive ZeroTrustTunnelCloudflaredConfigA#tcp_keep_alive}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpKeepAlive", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TcpKeepAlive
        {
            get;
            set;
        }

        /// <summary>Timeout for completing a TLS handshake to your origin server, if you have chosen to connect Tunnel to an HTTPS server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#tls_timeout ZeroTrustTunnelCloudflaredConfigA#tls_timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tlsTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TlsTimeout
        {
            get;
            set;
        }
    }
}
