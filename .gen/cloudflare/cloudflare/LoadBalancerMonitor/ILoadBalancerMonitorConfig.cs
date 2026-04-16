using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerMonitor
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerMonitorConfig), fullyQualifiedName: "cloudflare.loadBalancerMonitor.LoadBalancerMonitorConfig")]
    public interface ILoadBalancerMonitorConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#account_id LoadBalancerMonitor#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Do not validate the certificate when monitor use HTTPS.</summary>
        /// <remarks>
        /// This parameter is currently only valid for HTTP and HTTPS monitors.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#allow_insecure LoadBalancerMonitor#allow_insecure}
        /// </remarks>
        [JsiiProperty(name: "allowInsecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowInsecure
        {
            get
            {
                return null;
            }
        }

        /// <summary>To be marked unhealthy the monitored origin must fail this healthcheck N consecutive times.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#consecutive_down LoadBalancerMonitor#consecutive_down}
        /// </remarks>
        [JsiiProperty(name: "consecutiveDown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConsecutiveDown
        {
            get
            {
                return null;
            }
        }

        /// <summary>To be marked healthy the monitored origin must pass this healthcheck N consecutive times.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#consecutive_up LoadBalancerMonitor#consecutive_up}
        /// </remarks>
        [JsiiProperty(name: "consecutiveUp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConsecutiveUp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Object description.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#description LoadBalancerMonitor#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>A case-insensitive sub-string to look for in the response body.</summary>
        /// <remarks>
        /// If this string is not found, the origin will be marked as unhealthy. This parameter is only valid for HTTP and HTTPS monitors.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#expected_body LoadBalancerMonitor#expected_body}
        /// </remarks>
        [JsiiProperty(name: "expectedBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpectedBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>The expected HTTP response code or code range of the health check.</summary>
        /// <remarks>
        /// This parameter is only valid for HTTP and HTTPS monitors.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#expected_codes LoadBalancerMonitor#expected_codes}
        /// </remarks>
        [JsiiProperty(name: "expectedCodes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpectedCodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Follow redirects if returned by the origin. This parameter is only valid for HTTP and HTTPS monitors.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#follow_redirects LoadBalancerMonitor#follow_redirects}
        /// </remarks>
        [JsiiProperty(name: "followRedirects", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FollowRedirects
        {
            get
            {
                return null;
            }
        }

        /// <summary>The HTTP request headers to send in the health check.</summary>
        /// <remarks>
        /// It is recommended you set a Host header by default. The User-Agent header cannot be overridden. This parameter is only valid for HTTP and HTTPS monitors.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#header LoadBalancerMonitor#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>The interval between each health check.</summary>
        /// <remarks>
        /// Shorter intervals may improve failover time, but will increase load on the origins as we check from multiple locations.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#interval LoadBalancerMonitor#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Interval
        {
            get
            {
                return null;
            }
        }

        /// <summary>The method to use for the health check.</summary>
        /// <remarks>
        /// This defaults to 'GET' for HTTP/HTTPS based checks and 'connection_established' for TCP based health checks.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#method LoadBalancerMonitor#method}
        /// </remarks>
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>The endpoint path you want to conduct a health check against.</summary>
        /// <remarks>
        /// This parameter is only valid for HTTP and HTTPS monitors.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#path LoadBalancerMonitor#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>The port number to connect to for the health check.</summary>
        /// <remarks>
        /// Required for TCP, UDP, and SMTP checks. HTTP and HTTPS checks should only define the port when using a non-standard port (HTTP: default 80, HTTPS: default 443).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#port LoadBalancerMonitor#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Assign this monitor to emulate the specified zone while probing.</summary>
        /// <remarks>
        /// This parameter is only valid for HTTP and HTTPS monitors.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#probe_zone LoadBalancerMonitor#probe_zone}
        /// </remarks>
        [JsiiProperty(name: "probeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProbeZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of retries to attempt in case of a timeout before marking the origin as unhealthy.</summary>
        /// <remarks>
        /// Retries are attempted immediately.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#retries LoadBalancerMonitor#retries}
        /// </remarks>
        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Retries
        {
            get
            {
                return null;
            }
        }

        /// <summary>The timeout (in seconds) before marking the health check as failed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#timeout LoadBalancerMonitor#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>The protocol to use for the health check.</summary>
        /// <remarks>
        /// Currently supported protocols are 'HTTP','HTTPS', 'TCP', 'ICMP-PING', 'UDP-ICMP', and 'SMTP'.
        /// Available values: "http", "https", "tcp", "udp_icmp", "icmp_ping", "smtp".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#type LoadBalancerMonitor#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerMonitorConfig), fullyQualifiedName: "cloudflare.loadBalancerMonitor.LoadBalancerMonitorConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancerMonitor.ILoadBalancerMonitorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#account_id LoadBalancerMonitor#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Do not validate the certificate when monitor use HTTPS.</summary>
            /// <remarks>
            /// This parameter is currently only valid for HTTP and HTTPS monitors.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#allow_insecure LoadBalancerMonitor#allow_insecure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowInsecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowInsecure
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>To be marked unhealthy the monitored origin must fail this healthcheck N consecutive times.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#consecutive_down LoadBalancerMonitor#consecutive_down}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consecutiveDown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConsecutiveDown
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>To be marked healthy the monitored origin must pass this healthcheck N consecutive times.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#consecutive_up LoadBalancerMonitor#consecutive_up}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consecutiveUp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConsecutiveUp
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Object description.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#description LoadBalancerMonitor#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A case-insensitive sub-string to look for in the response body.</summary>
            /// <remarks>
            /// If this string is not found, the origin will be marked as unhealthy. This parameter is only valid for HTTP and HTTPS monitors.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#expected_body LoadBalancerMonitor#expected_body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expectedBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpectedBody
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The expected HTTP response code or code range of the health check.</summary>
            /// <remarks>
            /// This parameter is only valid for HTTP and HTTPS monitors.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#expected_codes LoadBalancerMonitor#expected_codes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expectedCodes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpectedCodes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Follow redirects if returned by the origin. This parameter is only valid for HTTP and HTTPS monitors.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#follow_redirects LoadBalancerMonitor#follow_redirects}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "followRedirects", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FollowRedirects
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The HTTP request headers to send in the health check.</summary>
            /// <remarks>
            /// It is recommended you set a Host header by default. The User-Agent header cannot be overridden. This parameter is only valid for HTTP and HTTPS monitors.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#header LoadBalancerMonitor#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Header
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The interval between each health check.</summary>
            /// <remarks>
            /// Shorter intervals may improve failover time, but will increase load on the origins as we check from multiple locations.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#interval LoadBalancerMonitor#interval}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Interval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The method to use for the health check.</summary>
            /// <remarks>
            /// This defaults to 'GET' for HTTP/HTTPS based checks and 'connection_established' for TCP based health checks.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#method LoadBalancerMonitor#method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Method
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The endpoint path you want to conduct a health check against.</summary>
            /// <remarks>
            /// This parameter is only valid for HTTP and HTTPS monitors.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#path LoadBalancerMonitor#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The port number to connect to for the health check.</summary>
            /// <remarks>
            /// Required for TCP, UDP, and SMTP checks. HTTP and HTTPS checks should only define the port when using a non-standard port (HTTP: default 80, HTTPS: default 443).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#port LoadBalancerMonitor#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Assign this monitor to emulate the specified zone while probing.</summary>
            /// <remarks>
            /// This parameter is only valid for HTTP and HTTPS monitors.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#probe_zone LoadBalancerMonitor#probe_zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "probeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProbeZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of retries to attempt in case of a timeout before marking the origin as unhealthy.</summary>
            /// <remarks>
            /// Retries are attempted immediately.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#retries LoadBalancerMonitor#retries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Retries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The timeout (in seconds) before marking the health check as failed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#timeout LoadBalancerMonitor#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The protocol to use for the health check.</summary>
            /// <remarks>
            /// Currently supported protocols are 'HTTP','HTTPS', 'TCP', 'ICMP-PING', 'UDP-ICMP', and 'SMTP'.
            /// Available values: "http", "https", "tcp", "udp_icmp", "icmp_ping", "smtp".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_monitor#type LoadBalancerMonitor#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
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
