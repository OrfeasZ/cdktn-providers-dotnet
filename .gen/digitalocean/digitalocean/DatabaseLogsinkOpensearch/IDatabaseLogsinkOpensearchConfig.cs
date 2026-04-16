using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseLogsinkOpensearch
{
    [JsiiInterface(nativeType: typeof(IDatabaseLogsinkOpensearchConfig), fullyQualifiedName: "digitalocean.databaseLogsinkOpensearch.DatabaseLogsinkOpensearchConfig")]
    public interface IDatabaseLogsinkOpensearchConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>UUID of the source database cluster that will forward logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#cluster_id DatabaseLogsinkOpensearch#cluster_id}
        /// </remarks>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterId
        {
            get;
        }

        /// <summary>HTTPS URL to OpenSearch (https://host:port).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#endpoint DatabaseLogsinkOpensearch#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoint
        {
            get;
        }

        /// <summary>Prefix for OpenSearch indices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#index_prefix DatabaseLogsinkOpensearch#index_prefix}
        /// </remarks>
        [JsiiProperty(name: "indexPrefix", typeJson: "{\"primitive\":\"string\"}")]
        string IndexPrefix
        {
            get;
        }

        /// <summary>Display name for the logsink.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#name DatabaseLogsinkOpensearch#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>CA certificate for TLS verification (PEM format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#ca_cert DatabaseLogsinkOpensearch#ca_cert}
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

        /// <summary>Maximum number of days to retain indices (&gt;= 1).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#index_days_max DatabaseLogsinkOpensearch#index_days_max}
        /// </remarks>
        [JsiiProperty(name: "indexDaysMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IndexDaysMax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Request timeout for log deliveries in seconds (&gt;= 1).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#timeout_seconds DatabaseLogsinkOpensearch#timeout_seconds}
        /// </remarks>
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseLogsinkOpensearchConfig), fullyQualifiedName: "digitalocean.databaseLogsinkOpensearch.DatabaseLogsinkOpensearchConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseLogsinkOpensearch.IDatabaseLogsinkOpensearchConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UUID of the source database cluster that will forward logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#cluster_id DatabaseLogsinkOpensearch#cluster_id}
            /// </remarks>
            [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>HTTPS URL to OpenSearch (https://host:port).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#endpoint DatabaseLogsinkOpensearch#endpoint}
            /// </remarks>
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Prefix for OpenSearch indices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#index_prefix DatabaseLogsinkOpensearch#index_prefix}
            /// </remarks>
            [JsiiProperty(name: "indexPrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string IndexPrefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Display name for the logsink.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#name DatabaseLogsinkOpensearch#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>CA certificate for TLS verification (PEM format).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#ca_cert DatabaseLogsinkOpensearch#ca_cert}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "caCert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaCert
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Maximum number of days to retain indices (&gt;= 1).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#index_days_max DatabaseLogsinkOpensearch#index_days_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "indexDaysMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IndexDaysMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Request timeout for log deliveries in seconds (&gt;= 1).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_logsink_opensearch#timeout_seconds DatabaseLogsinkOpensearch#timeout_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutSeconds
            {
                get => GetInstanceProperty<double?>();
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
