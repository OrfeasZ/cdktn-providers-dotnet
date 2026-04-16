using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Healthcheck
{
    [JsiiInterface(nativeType: typeof(IHealthcheckConfig), fullyQualifiedName: "cloudflare.healthcheck.HealthcheckConfig")]
    public interface IHealthcheckConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The hostname or IP address of the origin server to run health checks on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#address Healthcheck#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>A short name to identify the health check. Only alphanumeric characters, hyphens and underscores are allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#name Healthcheck#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#zone_id Healthcheck#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>A list of regions from which to run health checks. Null means Cloudflare will pick a default region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#check_regions Healthcheck#check_regions}
        /// </remarks>
        [JsiiProperty(name: "checkRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CheckRegions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of consecutive fails required from a health check before changing the health to unhealthy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#consecutive_fails Healthcheck#consecutive_fails}
        /// </remarks>
        [JsiiProperty(name: "consecutiveFails", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConsecutiveFails
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of consecutive successes required from a health check before changing the health to healthy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#consecutive_successes Healthcheck#consecutive_successes}
        /// </remarks>
        [JsiiProperty(name: "consecutiveSuccesses", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConsecutiveSuccesses
        {
            get
            {
                return null;
            }
        }

        /// <summary>A human-readable description of the health check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#description Healthcheck#description}
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

        /// <summary>Parameters specific to an HTTP or HTTPS health check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#http_config Healthcheck#http_config}
        /// </remarks>
        [JsiiProperty(name: "httpConfig", typeJson: "{\"fqn\":\"cloudflare.healthcheck.HealthcheckHttpConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Healthcheck.IHealthcheckHttpConfig? HttpConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>The interval between each health check.</summary>
        /// <remarks>
        /// Shorter intervals may give quicker notifications if the origin status changes, but will increase load on the origin as we check from multiple locations.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#interval Healthcheck#interval}
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

        /// <summary>The number of retries to attempt in case of a timeout before marking the origin as unhealthy.</summary>
        /// <remarks>
        /// Retries are attempted immediately.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#retries Healthcheck#retries}
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

        /// <summary>If suspended, no health checks are sent to the origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#suspended Healthcheck#suspended}
        /// </remarks>
        [JsiiProperty(name: "suspended", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Suspended
        {
            get
            {
                return null;
            }
        }

        /// <summary>Parameters specific to TCP health check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#tcp_config Healthcheck#tcp_config}
        /// </remarks>
        [JsiiProperty(name: "tcpConfig", typeJson: "{\"fqn\":\"cloudflare.healthcheck.HealthcheckTcpConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Healthcheck.IHealthcheckTcpConfig? TcpConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>The timeout (in seconds) before marking the health check as failed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#timeout Healthcheck#timeout}
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

        /// <summary>The protocol to use for the health check. Currently supported protocols are 'HTTP', 'HTTPS' and 'TCP'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#type Healthcheck#type}
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

        [JsiiTypeProxy(nativeType: typeof(IHealthcheckConfig), fullyQualifiedName: "cloudflare.healthcheck.HealthcheckConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Healthcheck.IHealthcheckConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The hostname or IP address of the origin server to run health checks on.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#address Healthcheck#address}
            /// </remarks>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A short name to identify the health check. Only alphanumeric characters, hyphens and underscores are allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#name Healthcheck#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#zone_id Healthcheck#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A list of regions from which to run health checks. Null means Cloudflare will pick a default region.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#check_regions Healthcheck#check_regions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "checkRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CheckRegions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The number of consecutive fails required from a health check before changing the health to unhealthy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#consecutive_fails Healthcheck#consecutive_fails}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consecutiveFails", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConsecutiveFails
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The number of consecutive successes required from a health check before changing the health to healthy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#consecutive_successes Healthcheck#consecutive_successes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consecutiveSuccesses", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConsecutiveSuccesses
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A human-readable description of the health check.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#description Healthcheck#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Parameters specific to an HTTP or HTTPS health check.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#http_config Healthcheck#http_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpConfig", typeJson: "{\"fqn\":\"cloudflare.healthcheck.HealthcheckHttpConfig\"}", isOptional: true)]
            public cloudflare.Healthcheck.IHealthcheckHttpConfig? HttpConfig
            {
                get => GetInstanceProperty<cloudflare.Healthcheck.IHealthcheckHttpConfig?>();
            }

            /// <summary>The interval between each health check.</summary>
            /// <remarks>
            /// Shorter intervals may give quicker notifications if the origin status changes, but will increase load on the origin as we check from multiple locations.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#interval Healthcheck#interval}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Interval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The number of retries to attempt in case of a timeout before marking the origin as unhealthy.</summary>
            /// <remarks>
            /// Retries are attempted immediately.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#retries Healthcheck#retries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Retries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>If suspended, no health checks are sent to the origin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#suspended Healthcheck#suspended}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suspended", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Suspended
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Parameters specific to TCP health check.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#tcp_config Healthcheck#tcp_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpConfig", typeJson: "{\"fqn\":\"cloudflare.healthcheck.HealthcheckTcpConfig\"}", isOptional: true)]
            public cloudflare.Healthcheck.IHealthcheckTcpConfig? TcpConfig
            {
                get => GetInstanceProperty<cloudflare.Healthcheck.IHealthcheckTcpConfig?>();
            }

            /// <summary>The timeout (in seconds) before marking the health check as failed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#timeout Healthcheck#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The protocol to use for the health check. Currently supported protocols are 'HTTP', 'HTTPS' and 'TCP'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#type Healthcheck#type}
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
