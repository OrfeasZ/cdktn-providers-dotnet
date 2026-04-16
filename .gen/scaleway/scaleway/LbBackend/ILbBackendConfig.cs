using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbBackend
{
    [JsiiInterface(nativeType: typeof(ILbBackendConfig), fullyQualifiedName: "scaleway.lbBackend.LbBackendConfig")]
    public interface ILbBackendConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>User sessions will be forwarded to this port of backend servers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#forward_port LbBackend#forward_port}
        /// </remarks>
        [JsiiProperty(name: "forwardPort", typeJson: "{\"primitive\":\"number\"}")]
        double ForwardPort
        {
            get;
        }

        /// <summary>Backend protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#forward_protocol LbBackend#forward_protocol}
        /// </remarks>
        [JsiiProperty(name: "forwardProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string ForwardProtocol
        {
            get;
        }

        /// <summary>The load-balancer ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#lb_id LbBackend#lb_id}
        /// </remarks>
        [JsiiProperty(name: "lbId", typeJson: "{\"primitive\":\"string\"}")]
        string LbId
        {
            get;
        }

        /// <summary>Scaleway S3 bucket website to be served in case all backend servers are down.</summary>
        /// <remarks>
        /// <strong>NOTE</strong> : Only the host part of the Scaleway S3 bucket website is expected.
        /// E.g. 'failover-website.s3-website.fr-par.scw.cloud' if your bucket website URL is 'https://failover-website.s3-website.fr-par.scw.cloud/'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#failover_host LbBackend#failover_host}
        /// </remarks>
        [JsiiProperty(name: "failoverHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FailoverHost
        {
            get
            {
                return null;
            }
        }

        /// <summary>Load balancing algorithm.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#forward_port_algorithm LbBackend#forward_port_algorithm}
        /// </remarks>
        [JsiiProperty(name: "forwardPortAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ForwardPortAlgorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Interval between two HC requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_delay LbBackend#health_check_delay}
        /// </remarks>
        [JsiiProperty(name: "healthCheckDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckDelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check_http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_http LbBackend#health_check_http}
        /// </remarks>
        [JsiiProperty(name: "healthCheckHttp", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.LbBackend.ILbBackendHealthCheckHttp? HealthCheckHttp
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check_https block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_https LbBackend#health_check_https}
        /// </remarks>
        [JsiiProperty(name: "healthCheckHttps", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.LbBackend.ILbBackendHealthCheckHttps? HealthCheckHttps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of allowed failed HC requests before the backend server is marked down.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_max_retries LbBackend#health_check_max_retries}
        /// </remarks>
        [JsiiProperty(name: "healthCheckMaxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthCheckMaxRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Port the HC requests will be send to. Default to `forward_port`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_port LbBackend#health_check_port}
        /// </remarks>
        [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthCheckPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines whether proxy protocol should be activated for the health check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_send_proxy LbBackend#health_check_send_proxy}
        /// </remarks>
        [JsiiProperty(name: "healthCheckSendProxy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HealthCheckSendProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check_tcp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_tcp LbBackend#health_check_tcp}
        /// </remarks>
        [JsiiProperty(name: "healthCheckTcp", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckTcp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.LbBackend.ILbBackendHealthCheckTcp? HealthCheckTcp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Timeout before we consider a HC request failed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_timeout LbBackend#health_check_timeout}
        /// </remarks>
        [JsiiProperty(name: "healthCheckTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Time to wait between two consecutive health checks when a backend server is in a transient state (going UP or DOWN).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_transient_delay LbBackend#health_check_transient_delay}
        /// </remarks>
        [JsiiProperty(name: "healthCheckTransientDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckTransientDelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#id LbBackend#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether the Load Balancer should check the backend server’s certificate before initiating a connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#ignore_ssl_server_verify LbBackend#ignore_ssl_server_verify}
        /// </remarks>
        [JsiiProperty(name: "ignoreSslServerVerify", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreSslServerVerify
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum number of connections allowed per backend server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#max_connections LbBackend#max_connections}
        /// </remarks>
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConnections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of retries when a backend server connection failed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#max_retries LbBackend#max_retries}
        /// </remarks>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#name LbBackend#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Modify what occurs when a backend server is marked down.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#on_marked_down_action LbBackend#on_marked_down_action}
        /// </remarks>
        [JsiiProperty(name: "onMarkedDownAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnMarkedDownAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of PROXY protocol to enable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#proxy_protocol LbBackend#proxy_protocol}
        /// </remarks>
        [JsiiProperty(name: "proxyProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProxyProtocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to use another backend server on each attempt.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#redispatch_attempt_count LbBackend#redispatch_attempt_count}
        /// </remarks>
        [JsiiProperty(name: "redispatchAttemptCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RedispatchAttemptCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables PROXY protocol version 2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#send_proxy_v2 LbBackend#send_proxy_v2}
        /// </remarks>
        [JsiiProperty(name: "sendProxyV2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SendProxyV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>Backend server IP addresses list (IPv4 or IPv6).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#server_ips LbBackend#server_ips}
        /// </remarks>
        [JsiiProperty(name: "serverIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ServerIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables SSL between load balancer and backend servers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#ssl_bridging LbBackend#ssl_bridging}
        /// </remarks>
        [JsiiProperty(name: "sslBridging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SslBridging
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of sticky sessions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#sticky_sessions LbBackend#sticky_sessions}
        /// </remarks>
        [JsiiProperty(name: "stickySessions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StickySessions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Cookie name for sticky sessions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#sticky_sessions_cookie_name LbBackend#sticky_sessions_cookie_name}
        /// </remarks>
        [JsiiProperty(name: "stickySessionsCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StickySessionsCookieName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum initial server connection establishment time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_connect LbBackend#timeout_connect}
        /// </remarks>
        [JsiiProperty(name: "timeoutConnect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeoutConnect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum time (in seconds) for a request to be left pending in queue when `max_connections` is reached.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_queue LbBackend#timeout_queue}
        /// </remarks>
        [JsiiProperty(name: "timeoutQueue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeoutQueue
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeouts LbBackend#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.LbBackend.ILbBackendTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum server connection inactivity time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_server LbBackend#timeout_server}
        /// </remarks>
        [JsiiProperty(name: "timeoutServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeoutServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum tunnel inactivity time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_tunnel LbBackend#timeout_tunnel}
        /// </remarks>
        [JsiiProperty(name: "timeoutTunnel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeoutTunnel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbBackendConfig), fullyQualifiedName: "scaleway.lbBackend.LbBackendConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbBackend.ILbBackendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>User sessions will be forwarded to this port of backend servers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#forward_port LbBackend#forward_port}
            /// </remarks>
            [JsiiProperty(name: "forwardPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ForwardPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Backend protocol.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#forward_protocol LbBackend#forward_protocol}
            /// </remarks>
            [JsiiProperty(name: "forwardProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string ForwardProtocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The load-balancer ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#lb_id LbBackend#lb_id}
            /// </remarks>
            [JsiiProperty(name: "lbId", typeJson: "{\"primitive\":\"string\"}")]
            public string LbId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Scaleway S3 bucket website to be served in case all backend servers are down.</summary>
            /// <remarks>
            /// <strong>NOTE</strong> : Only the host part of the Scaleway S3 bucket website is expected.
            /// E.g. 'failover-website.s3-website.fr-par.scw.cloud' if your bucket website URL is 'https://failover-website.s3-website.fr-par.scw.cloud/'.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#failover_host LbBackend#failover_host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failoverHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FailoverHost
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Load balancing algorithm.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#forward_port_algorithm LbBackend#forward_port_algorithm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardPortAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ForwardPortAlgorithm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Interval between two HC requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_delay LbBackend#health_check_delay}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckDelay
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>health_check_http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_http LbBackend#health_check_http}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckHttp", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttp\"}", isOptional: true)]
            public scaleway.LbBackend.ILbBackendHealthCheckHttp? HealthCheckHttp
            {
                get => GetInstanceProperty<scaleway.LbBackend.ILbBackendHealthCheckHttp?>();
            }

            /// <summary>health_check_https block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_https LbBackend#health_check_https}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckHttps", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttps\"}", isOptional: true)]
            public scaleway.LbBackend.ILbBackendHealthCheckHttps? HealthCheckHttps
            {
                get => GetInstanceProperty<scaleway.LbBackend.ILbBackendHealthCheckHttps?>();
            }

            /// <summary>Number of allowed failed HC requests before the backend server is marked down.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_max_retries LbBackend#health_check_max_retries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckMaxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthCheckMaxRetries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Port the HC requests will be send to. Default to `forward_port`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_port LbBackend#health_check_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthCheckPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Defines whether proxy protocol should be activated for the health check.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_send_proxy LbBackend#health_check_send_proxy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckSendProxy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HealthCheckSendProxy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>health_check_tcp block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_tcp LbBackend#health_check_tcp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckTcp", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckTcp\"}", isOptional: true)]
            public scaleway.LbBackend.ILbBackendHealthCheckTcp? HealthCheckTcp
            {
                get => GetInstanceProperty<scaleway.LbBackend.ILbBackendHealthCheckTcp?>();
            }

            /// <summary>Timeout before we consider a HC request failed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_timeout LbBackend#health_check_timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckTimeout
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Time to wait between two consecutive health checks when a backend server is in a transient state (going UP or DOWN).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_transient_delay LbBackend#health_check_transient_delay}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckTransientDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckTransientDelay
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#id LbBackend#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies whether the Load Balancer should check the backend server’s certificate before initiating a connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#ignore_ssl_server_verify LbBackend#ignore_ssl_server_verify}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreSslServerVerify", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IgnoreSslServerVerify
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Maximum number of connections allowed per backend server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#max_connections LbBackend#max_connections}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConnections
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Number of retries when a backend server connection failed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#max_retries LbBackend#max_retries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRetries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The name of the backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#name LbBackend#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Modify what occurs when a backend server is marked down.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#on_marked_down_action LbBackend#on_marked_down_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onMarkedDownAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnMarkedDownAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Type of PROXY protocol to enable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#proxy_protocol LbBackend#proxy_protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "proxyProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProxyProtocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to use another backend server on each attempt.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#redispatch_attempt_count LbBackend#redispatch_attempt_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redispatchAttemptCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RedispatchAttemptCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Enables PROXY protocol version 2.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#send_proxy_v2 LbBackend#send_proxy_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sendProxyV2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SendProxyV2
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Backend server IP addresses list (IPv4 or IPv6).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#server_ips LbBackend#server_ips}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ServerIps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Enables SSL between load balancer and backend servers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#ssl_bridging LbBackend#ssl_bridging}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslBridging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SslBridging
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The type of sticky sessions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#sticky_sessions LbBackend#sticky_sessions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stickySessions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StickySessions
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Cookie name for sticky sessions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#sticky_sessions_cookie_name LbBackend#sticky_sessions_cookie_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stickySessionsCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StickySessionsCookieName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Maximum initial server connection establishment time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_connect LbBackend#timeout_connect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutConnect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeoutConnect
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Maximum time (in seconds) for a request to be left pending in queue when `max_connections` is reached.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_queue LbBackend#timeout_queue}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutQueue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeoutQueue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeouts LbBackend#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendTimeouts\"}", isOptional: true)]
            public scaleway.LbBackend.ILbBackendTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.LbBackend.ILbBackendTimeouts?>();
            }

            /// <summary>Maximum server connection inactivity time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_server LbBackend#timeout_server}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeoutServer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Maximum tunnel inactivity time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_tunnel LbBackend#timeout_tunnel}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutTunnel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeoutTunnel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
