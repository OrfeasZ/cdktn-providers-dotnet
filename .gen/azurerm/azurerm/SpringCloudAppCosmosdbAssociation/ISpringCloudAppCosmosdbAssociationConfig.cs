using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudAppCosmosdbAssociation
{
    [JsiiInterface(nativeType: typeof(ISpringCloudAppCosmosdbAssociationConfig), fullyQualifiedName: "azurerm.springCloudAppCosmosdbAssociation.SpringCloudAppCosmosdbAssociationConfig")]
    public interface ISpringCloudAppCosmosdbAssociationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#api_type SpringCloudAppCosmosdbAssociation#api_type}.</summary>
        [JsiiProperty(name: "apiType", typeJson: "{\"primitive\":\"string\"}")]
        string ApiType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_access_key SpringCloudAppCosmosdbAssociation#cosmosdb_access_key}.</summary>
        [JsiiProperty(name: "cosmosdbAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        string CosmosdbAccessKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_account_id SpringCloudAppCosmosdbAssociation#cosmosdb_account_id}.</summary>
        [JsiiProperty(name: "cosmosdbAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string CosmosdbAccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#name SpringCloudAppCosmosdbAssociation#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#spring_cloud_app_id SpringCloudAppCosmosdbAssociation#spring_cloud_app_id}.</summary>
        [JsiiProperty(name: "springCloudAppId", typeJson: "{\"primitive\":\"string\"}")]
        string SpringCloudAppId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_cassandra_keyspace_name SpringCloudAppCosmosdbAssociation#cosmosdb_cassandra_keyspace_name}.</summary>
        [JsiiProperty(name: "cosmosdbCassandraKeyspaceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CosmosdbCassandraKeyspaceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_gremlin_database_name SpringCloudAppCosmosdbAssociation#cosmosdb_gremlin_database_name}.</summary>
        [JsiiProperty(name: "cosmosdbGremlinDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CosmosdbGremlinDatabaseName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_gremlin_graph_name SpringCloudAppCosmosdbAssociation#cosmosdb_gremlin_graph_name}.</summary>
        [JsiiProperty(name: "cosmosdbGremlinGraphName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CosmosdbGremlinGraphName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_mongo_database_name SpringCloudAppCosmosdbAssociation#cosmosdb_mongo_database_name}.</summary>
        [JsiiProperty(name: "cosmosdbMongoDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CosmosdbMongoDatabaseName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_sql_database_name SpringCloudAppCosmosdbAssociation#cosmosdb_sql_database_name}.</summary>
        [JsiiProperty(name: "cosmosdbSqlDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CosmosdbSqlDatabaseName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#id SpringCloudAppCosmosdbAssociation#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#timeouts SpringCloudAppCosmosdbAssociation#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudAppCosmosdbAssociation.SpringCloudAppCosmosdbAssociationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudAppCosmosdbAssociation.ISpringCloudAppCosmosdbAssociationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudAppCosmosdbAssociationConfig), fullyQualifiedName: "azurerm.springCloudAppCosmosdbAssociation.SpringCloudAppCosmosdbAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudAppCosmosdbAssociation.ISpringCloudAppCosmosdbAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#api_type SpringCloudAppCosmosdbAssociation#api_type}.</summary>
            [JsiiProperty(name: "apiType", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_access_key SpringCloudAppCosmosdbAssociation#cosmosdb_access_key}.</summary>
            [JsiiProperty(name: "cosmosdbAccessKey", typeJson: "{\"primitive\":\"string\"}")]
            public string CosmosdbAccessKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_account_id SpringCloudAppCosmosdbAssociation#cosmosdb_account_id}.</summary>
            [JsiiProperty(name: "cosmosdbAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string CosmosdbAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#name SpringCloudAppCosmosdbAssociation#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#spring_cloud_app_id SpringCloudAppCosmosdbAssociation#spring_cloud_app_id}.</summary>
            [JsiiProperty(name: "springCloudAppId", typeJson: "{\"primitive\":\"string\"}")]
            public string SpringCloudAppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_cassandra_keyspace_name SpringCloudAppCosmosdbAssociation#cosmosdb_cassandra_keyspace_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cosmosdbCassandraKeyspaceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CosmosdbCassandraKeyspaceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_gremlin_database_name SpringCloudAppCosmosdbAssociation#cosmosdb_gremlin_database_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cosmosdbGremlinDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CosmosdbGremlinDatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_gremlin_graph_name SpringCloudAppCosmosdbAssociation#cosmosdb_gremlin_graph_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cosmosdbGremlinGraphName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CosmosdbGremlinGraphName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_mongo_database_name SpringCloudAppCosmosdbAssociation#cosmosdb_mongo_database_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cosmosdbMongoDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CosmosdbMongoDatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_sql_database_name SpringCloudAppCosmosdbAssociation#cosmosdb_sql_database_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cosmosdbSqlDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CosmosdbSqlDatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#id SpringCloudAppCosmosdbAssociation#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_app_cosmosdb_association#timeouts SpringCloudAppCosmosdbAssociation#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudAppCosmosdbAssociation.SpringCloudAppCosmosdbAssociationTimeouts\"}", isOptional: true)]
            public azurerm.SpringCloudAppCosmosdbAssociation.ISpringCloudAppCosmosdbAssociationTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SpringCloudAppCosmosdbAssociation.ISpringCloudAppCosmosdbAssociationTimeouts?>();
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
