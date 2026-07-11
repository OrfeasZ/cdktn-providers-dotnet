using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraTable
{
    [JsiiInterface(nativeType: typeof(ICosmosdbCassandraTableConfig), fullyQualifiedName: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableConfig")]
    public interface ICosmosdbCassandraTableConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#cassandra_keyspace_id CosmosdbCassandraTable#cassandra_keyspace_id}.</summary>
        [JsiiProperty(name: "cassandraKeyspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string CassandraKeyspaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#name CosmosdbCassandraTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#schema CosmosdbCassandraTable#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchema\"}")]
        azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchema Schema
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#analytical_storage_ttl CosmosdbCassandraTable#analytical_storage_ttl}.</summary>
        [JsiiProperty(name: "analyticalStorageTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AnalyticalStorageTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>autoscale_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#autoscale_settings CosmosdbCassandraTable#autoscale_settings}
        /// </remarks>
        [JsiiProperty(name: "autoscaleSettings", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableAutoscaleSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableAutoscaleSettings? AutoscaleSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#default_ttl CosmosdbCassandraTable#default_ttl}.</summary>
        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#id CosmosdbCassandraTable#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#throughput CosmosdbCassandraTable#throughput}.</summary>
        [JsiiProperty(name: "throughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Throughput
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#timeouts CosmosdbCassandraTable#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbCassandraTableConfig), fullyQualifiedName: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#cassandra_keyspace_id CosmosdbCassandraTable#cassandra_keyspace_id}.</summary>
            [JsiiProperty(name: "cassandraKeyspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string CassandraKeyspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#name CosmosdbCassandraTable#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#schema CosmosdbCassandraTable#schema}
            /// </remarks>
            [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchema\"}")]
            public azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchema Schema
            {
                get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchema>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#analytical_storage_ttl CosmosdbCassandraTable#analytical_storage_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "analyticalStorageTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AnalyticalStorageTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>autoscale_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#autoscale_settings CosmosdbCassandraTable#autoscale_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoscaleSettings", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableAutoscaleSettings\"}", isOptional: true)]
            public azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableAutoscaleSettings? AutoscaleSettings
            {
                get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableAutoscaleSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#default_ttl CosmosdbCassandraTable#default_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#id CosmosdbCassandraTable#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#throughput CosmosdbCassandraTable#throughput}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "throughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Throughput
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cosmosdb_cassandra_table#timeouts CosmosdbCassandraTable#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableTimeouts\"}", isOptional: true)]
            public azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
