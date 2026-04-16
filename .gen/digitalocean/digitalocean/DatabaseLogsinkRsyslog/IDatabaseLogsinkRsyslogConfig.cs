using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseLogsinkRsyslog
{
    [JsiiInterface(nativeType: typeof(IDatabaseLogsinkRsyslogConfig), fullyQualifiedName: "digitalocean.databaseLogsinkRsyslog.DatabaseLogsinkRsyslogConfig")]
    public interface IDatabaseLogsinkRsyslogConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>UUID of the source database cluster that will forward logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#cluster_id DatabaseLogsinkRsyslog#cluster_id}
        /// </remarks>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterId
        {
            get;
        }

        /// <summary>Display name for the logsink.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#name DatabaseLogsinkRsyslog#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Port number for the rsyslog server (1-65535).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#port DatabaseLogsinkRsyslog#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Hostname or IP address of the rsyslog server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#server DatabaseLogsinkRsyslog#server}
        /// </remarks>
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
        string Server
        {
            get;
        }

        /// <summary>CA certificate for TLS verification (PEM format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#ca_cert DatabaseLogsinkRsyslog#ca_cert}
        /// </remarks>
        [JsiiProperty(name: "caCert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaCert
        {
            get
            {
                return null;
            }
        }

        /// <summary>Client certificate for mTLS (PEM format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#client_cert DatabaseLogsinkRsyslog#client_cert}
        /// </remarks>
        [JsiiProperty(name: "clientCert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCert
        {
            get
            {
                return null;
            }
        }

        /// <summary>Client private key for mTLS (PEM format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#client_key DatabaseLogsinkRsyslog#client_key}
        /// </remarks>
        [JsiiProperty(name: "clientKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Log format: rfc5424, rfc3164, or custom.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#format DatabaseLogsinkRsyslog#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Format
        {
            get
            {
                return null;
            }
        }

        /// <summary>Custom logline template (required when format is 'custom').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#logline DatabaseLogsinkRsyslog#logline}
        /// </remarks>
        [JsiiProperty(name: "logline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Logline
        {
            get
            {
                return null;
            }
        }

        /// <summary>Structured data for rsyslog.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#structured_data DatabaseLogsinkRsyslog#structured_data}
        /// </remarks>
        [JsiiProperty(name: "structuredData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StructuredData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable TLS encryption for rsyslog connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#tls DatabaseLogsinkRsyslog#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseLogsinkRsyslogConfig), fullyQualifiedName: "digitalocean.databaseLogsinkRsyslog.DatabaseLogsinkRsyslogConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseLogsinkRsyslog.IDatabaseLogsinkRsyslogConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UUID of the source database cluster that will forward logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#cluster_id DatabaseLogsinkRsyslog#cluster_id}
            /// </remarks>
            [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Display name for the logsink.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#name DatabaseLogsinkRsyslog#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Port number for the rsyslog server (1-65535).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#port DatabaseLogsinkRsyslog#port}
            /// </remarks>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Hostname or IP address of the rsyslog server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#server DatabaseLogsinkRsyslog#server}
            /// </remarks>
            [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
            public string Server
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>CA certificate for TLS verification (PEM format).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#ca_cert DatabaseLogsinkRsyslog#ca_cert}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "caCert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaCert
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Client certificate for mTLS (PEM format).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#client_cert DatabaseLogsinkRsyslog#client_cert}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCert
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Client private key for mTLS (PEM format).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#client_key DatabaseLogsinkRsyslog#client_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Log format: rfc5424, rfc3164, or custom.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#format DatabaseLogsinkRsyslog#format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Format
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Custom logline template (required when format is 'custom').</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#logline DatabaseLogsinkRsyslog#logline}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Logline
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Structured data for rsyslog.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#structured_data DatabaseLogsinkRsyslog#structured_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "structuredData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StructuredData
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable TLS encryption for rsyslog connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_rsyslog#tls DatabaseLogsinkRsyslog#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Tls
            {
                get => GetInstanceProperty<object?>();
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
