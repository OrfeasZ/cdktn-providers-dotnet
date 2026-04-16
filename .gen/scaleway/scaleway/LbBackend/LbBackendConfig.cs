using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbBackend
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.lbBackend.LbBackendConfig")]
    public class LbBackendConfig : scaleway.LbBackend.ILbBackendConfig
    {
        /// <summary>User sessions will be forwarded to this port of backend servers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#forward_port LbBackend#forward_port}
        /// </remarks>
        [JsiiProperty(name: "forwardPort", typeJson: "{\"primitive\":\"number\"}")]
        public double ForwardPort
        {
            get;
            set;
        }

        /// <summary>Backend protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#forward_protocol LbBackend#forward_protocol}
        /// </remarks>
        [JsiiProperty(name: "forwardProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public string ForwardProtocol
        {
            get;
            set;
        }

        /// <summary>The load-balancer ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#lb_id LbBackend#lb_id}
        /// </remarks>
        [JsiiProperty(name: "lbId", typeJson: "{\"primitive\":\"string\"}")]
        public string LbId
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Load balancing algorithm.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#forward_port_algorithm LbBackend#forward_port_algorithm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forwardPortAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ForwardPortAlgorithm
        {
            get;
            set;
        }

        /// <summary>Interval between two HC requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_delay LbBackend#health_check_delay}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckDelay
        {
            get;
            set;
        }

        /// <summary>health_check_http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_http LbBackend#health_check_http}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckHttp", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttp\"}", isOptional: true)]
        public scaleway.LbBackend.ILbBackendHealthCheckHttp? HealthCheckHttp
        {
            get;
            set;
        }

        /// <summary>health_check_https block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_https LbBackend#health_check_https}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckHttps", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttps\"}", isOptional: true)]
        public scaleway.LbBackend.ILbBackendHealthCheckHttps? HealthCheckHttps
        {
            get;
            set;
        }

        /// <summary>Number of allowed failed HC requests before the backend server is marked down.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_max_retries LbBackend#health_check_max_retries}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckMaxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthCheckMaxRetries
        {
            get;
            set;
        }

        /// <summary>Port the HC requests will be send to. Default to `forward_port`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_port LbBackend#health_check_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthCheckPort
        {
            get;
            set;
        }

        private object? _healthCheckSendProxy;

        /// <summary>Defines whether proxy protocol should be activated for the health check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_send_proxy LbBackend#health_check_send_proxy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckSendProxy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? HealthCheckSendProxy
        {
            get => _healthCheckSendProxy;
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
                _healthCheckSendProxy = value;
            }
        }

        /// <summary>health_check_tcp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_tcp LbBackend#health_check_tcp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckTcp", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckTcp\"}", isOptional: true)]
        public scaleway.LbBackend.ILbBackendHealthCheckTcp? HealthCheckTcp
        {
            get;
            set;
        }

        /// <summary>Timeout before we consider a HC request failed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_timeout LbBackend#health_check_timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckTimeout
        {
            get;
            set;
        }

        /// <summary>Time to wait between two consecutive health checks when a backend server is in a transient state (going UP or DOWN).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#health_check_transient_delay LbBackend#health_check_transient_delay}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckTransientDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckTransientDelay
        {
            get;
            set;
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
            get;
            set;
        }

        private object? _ignoreSslServerVerify;

        /// <summary>Specifies whether the Load Balancer should check the backend server’s certificate before initiating a connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#ignore_ssl_server_verify LbBackend#ignore_ssl_server_verify}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreSslServerVerify", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IgnoreSslServerVerify
        {
            get => _ignoreSslServerVerify;
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
                _ignoreSslServerVerify = value;
            }
        }

        /// <summary>Maximum number of connections allowed per backend server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#max_connections LbBackend#max_connections}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConnections
        {
            get;
            set;
        }

        /// <summary>Number of retries when a backend server connection failed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#max_retries LbBackend#max_retries}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRetries
        {
            get;
            set;
        }

        /// <summary>The name of the backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#name LbBackend#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Modify what occurs when a backend server is marked down.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#on_marked_down_action LbBackend#on_marked_down_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onMarkedDownAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnMarkedDownAction
        {
            get;
            set;
        }

        /// <summary>Type of PROXY protocol to enable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#proxy_protocol LbBackend#proxy_protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "proxyProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProxyProtocol
        {
            get;
            set;
        }

        /// <summary>Whether to use another backend server on each attempt.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#redispatch_attempt_count LbBackend#redispatch_attempt_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redispatchAttemptCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RedispatchAttemptCount
        {
            get;
            set;
        }

        private object? _sendProxyV2;

        /// <summary>Enables PROXY protocol version 2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#send_proxy_v2 LbBackend#send_proxy_v2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sendProxyV2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SendProxyV2
        {
            get => _sendProxyV2;
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
                _sendProxyV2 = value;
            }
        }

        /// <summary>Backend server IP addresses list (IPv4 or IPv6).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#server_ips LbBackend#server_ips}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ServerIps
        {
            get;
            set;
        }

        private object? _sslBridging;

        /// <summary>Enables SSL between load balancer and backend servers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#ssl_bridging LbBackend#ssl_bridging}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslBridging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SslBridging
        {
            get => _sslBridging;
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
                _sslBridging = value;
            }
        }

        /// <summary>The type of sticky sessions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#sticky_sessions LbBackend#sticky_sessions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stickySessions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StickySessions
        {
            get;
            set;
        }

        /// <summary>Cookie name for sticky sessions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#sticky_sessions_cookie_name LbBackend#sticky_sessions_cookie_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stickySessionsCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StickySessionsCookieName
        {
            get;
            set;
        }

        /// <summary>Maximum initial server connection establishment time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_connect LbBackend#timeout_connect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutConnect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeoutConnect
        {
            get;
            set;
        }

        /// <summary>Maximum time (in seconds) for a request to be left pending in queue when `max_connections` is reached.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_queue LbBackend#timeout_queue}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutQueue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeoutQueue
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeouts LbBackend#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendTimeouts\"}", isOptional: true)]
        public scaleway.LbBackend.ILbBackendTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Maximum server connection inactivity time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_server LbBackend#timeout_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeoutServer
        {
            get;
            set;
        }

        /// <summary>Maximum tunnel inactivity time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#timeout_tunnel LbBackend#timeout_tunnel}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutTunnel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeoutTunnel
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
