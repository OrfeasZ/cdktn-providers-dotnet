using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelCloudflaredConfig
{
    [JsiiInterface(nativeType: typeof(IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequest), fullyQualifiedName: "cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequest")]
    public interface IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequest
    {
        /// <summary>For all L7 requests to this hostname, cloudflared will validate each request's Cf-Access-Jwt-Assertion request header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#access ZeroTrustTunnelCloudflaredConfigA#access}
        /// </remarks>
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess? Access
        {
            get
            {
                return null;
            }
        }

        /// <summary>Path to the certificate authority (CA) for the certificate of your origin.</summary>
        /// <remarks>
        /// This option should be used only if your certificate is not signed by Cloudflare.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#ca_pool ZeroTrustTunnelCloudflaredConfigA#ca_pool}
        /// </remarks>
        [JsiiProperty(name: "caPool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaPool
        {
            get
            {
                return null;
            }
        }

        /// <summary>Timeout for establishing a new TCP connection to your origin server.</summary>
        /// <remarks>
        /// This excludes the time taken to establish TLS, which is controlled by tlsTimeout.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#connect_timeout ZeroTrustTunnelCloudflaredConfigA#connect_timeout}
        /// </remarks>
        [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Disables chunked transfer encoding. Useful if you are running a WSGI server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#disable_chunked_encoding ZeroTrustTunnelCloudflaredConfigA#disable_chunked_encoding}
        /// </remarks>
        [JsiiProperty(name: "disableChunkedEncoding", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableChunkedEncoding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Attempt to connect to origin using HTTP2. Origin must be configured as https.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#http2_origin ZeroTrustTunnelCloudflaredConfigA#http2_origin}
        /// </remarks>
        [JsiiProperty(name: "http2Origin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Http2Origin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the HTTP Host header on requests sent to the local service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#http_host_header ZeroTrustTunnelCloudflaredConfigA#http_host_header}
        /// </remarks>
        [JsiiProperty(name: "httpHostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpHostHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum number of idle keepalive connections between Tunnel and your origin.</summary>
        /// <remarks>
        /// This does not restrict the total number of concurrent connections.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#keep_alive_connections ZeroTrustTunnelCloudflaredConfigA#keep_alive_connections}
        /// </remarks>
        [JsiiProperty(name: "keepAliveConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KeepAliveConnections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Timeout after which an idle keepalive connection can be discarded.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#keep_alive_timeout ZeroTrustTunnelCloudflaredConfigA#keep_alive_timeout}
        /// </remarks>
        [JsiiProperty(name: "keepAliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KeepAliveTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Auto configure the Hostname on the origin server certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#match_sn_ito_host ZeroTrustTunnelCloudflaredConfigA#match_sn_ito_host}
        /// </remarks>
        [JsiiProperty(name: "matchSnItoHost", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchSnItoHost
        {
            get
            {
                return null;
            }
        }

        /// <summary>Disable the “happy eyeballs” algorithm for IPv4/IPv6 fallback if your local network has misconfigured one of the protocols.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#no_happy_eyeballs ZeroTrustTunnelCloudflaredConfigA#no_happy_eyeballs}
        /// </remarks>
        [JsiiProperty(name: "noHappyEyeballs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoHappyEyeballs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Disables TLS verification of the certificate presented by your origin.</summary>
        /// <remarks>
        /// Will allow any certificate from the origin to be accepted.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#no_tls_verify ZeroTrustTunnelCloudflaredConfigA#no_tls_verify}
        /// </remarks>
        [JsiiProperty(name: "noTlsVerify", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoTlsVerify
        {
            get
            {
                return null;
            }
        }

        /// <summary>Hostname that cloudflared should expect from your origin server certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#origin_server_name ZeroTrustTunnelCloudflaredConfigA#origin_server_name}
        /// </remarks>
        [JsiiProperty(name: "originServerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginServerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudflared starts a proxy server to translate HTTP traffic into TCP when proxying, for example, SSH or RDP.</summary>
        /// <remarks>
        /// This configures what type of proxy will be started. Valid options are: "" for the regular proxy and "socks" for a SOCKS5 proxy.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#proxy_type ZeroTrustTunnelCloudflaredConfigA#proxy_type}
        /// </remarks>
        [JsiiProperty(name: "proxyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProxyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>The timeout after which a TCP keepalive packet is sent on a connection between Tunnel and the origin server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#tcp_keep_alive ZeroTrustTunnelCloudflaredConfigA#tcp_keep_alive}
        /// </remarks>
        [JsiiProperty(name: "tcpKeepAlive", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TcpKeepAlive
        {
            get
            {
                return null;
            }
        }

        /// <summary>Timeout for completing a TLS handshake to your origin server, if you have chosen to connect Tunnel to an HTTPS server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#tls_timeout ZeroTrustTunnelCloudflaredConfigA#tls_timeout}
        /// </remarks>
        [JsiiProperty(name: "tlsTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TlsTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequest), fullyQualifiedName: "cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequest")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>For all L7 requests to this hostname, cloudflared will validate each request's Cf-Access-Jwt-Assertion request header.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#access ZeroTrustTunnelCloudflaredConfigA#access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess\"}", isOptional: true)]
            public cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess? Access
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccess?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Disables chunked transfer encoding. Useful if you are running a WSGI server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#disable_chunked_encoding ZeroTrustTunnelCloudflaredConfigA#disable_chunked_encoding}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableChunkedEncoding", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableChunkedEncoding
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Attempt to connect to origin using HTTP2. Origin must be configured as https.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#http2_origin ZeroTrustTunnelCloudflaredConfigA#http2_origin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2Origin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Http2Origin
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the HTTP Host header on requests sent to the local service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#http_host_header ZeroTrustTunnelCloudflaredConfigA#http_host_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpHostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpHostHeader
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Timeout after which an idle keepalive connection can be discarded.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#keep_alive_timeout ZeroTrustTunnelCloudflaredConfigA#keep_alive_timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keepAliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KeepAliveTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Auto configure the Hostname on the origin server certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#match_sn_ito_host ZeroTrustTunnelCloudflaredConfigA#match_sn_ito_host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchSnItoHost", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MatchSnItoHost
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Disable the “happy eyeballs” algorithm for IPv4/IPv6 fallback if your local network has misconfigured one of the protocols.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#no_happy_eyeballs ZeroTrustTunnelCloudflaredConfigA#no_happy_eyeballs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "noHappyEyeballs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? NoHappyEyeballs
            {
                get => GetInstanceProperty<object?>();
            }

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
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Hostname that cloudflared should expect from your origin server certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#origin_server_name ZeroTrustTunnelCloudflaredConfigA#origin_server_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originServerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginServerName
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The timeout after which a TCP keepalive packet is sent on a connection between Tunnel and the origin server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#tcp_keep_alive ZeroTrustTunnelCloudflaredConfigA#tcp_keep_alive}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpKeepAlive", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TcpKeepAlive
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Timeout for completing a TLS handshake to your origin server, if you have chosen to connect Tunnel to an HTTPS server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_tunnel_cloudflared_config#tls_timeout ZeroTrustTunnelCloudflaredConfigA#tls_timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tlsTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TlsTimeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
