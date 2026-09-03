using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraDatacenter
{
    [JsiiInterface(nativeType: typeof(ICosmosdbCassandraDatacenterConfig), fullyQualifiedName: "azurerm.cosmosdbCassandraDatacenter.CosmosdbCassandraDatacenterConfig")]
    public interface ICosmosdbCassandraDatacenterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#cassandra_cluster_id CosmosdbCassandraDatacenter#cassandra_cluster_id}.</summary>
        [JsiiProperty(name: "cassandraClusterId", typeJson: "{\"primitive\":\"string\"}")]
        string CassandraClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#delegated_management_subnet_id CosmosdbCassandraDatacenter#delegated_management_subnet_id}.</summary>
        [JsiiProperty(name: "delegatedManagementSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        string DelegatedManagementSubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#location CosmosdbCassandraDatacenter#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#name CosmosdbCassandraDatacenter#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#availability_zones_enabled CosmosdbCassandraDatacenter#availability_zones_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "availabilityZonesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AvailabilityZonesEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#backup_storage_customer_key_uri CosmosdbCassandraDatacenter#backup_storage_customer_key_uri}.</summary>
        [JsiiProperty(name: "backupStorageCustomerKeyUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupStorageCustomerKeyUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#base64_encoded_yaml_fragment CosmosdbCassandraDatacenter#base64_encoded_yaml_fragment}.</summary>
        [JsiiProperty(name: "base64EncodedYamlFragment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Base64EncodedYamlFragment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#disk_count CosmosdbCassandraDatacenter#disk_count}.</summary>
        [JsiiProperty(name: "diskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#disk_sku CosmosdbCassandraDatacenter#disk_sku}.</summary>
        [JsiiProperty(name: "diskSku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DiskSku
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#id CosmosdbCassandraDatacenter#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#managed_disk_customer_key_uri CosmosdbCassandraDatacenter#managed_disk_customer_key_uri}.</summary>
        [JsiiProperty(name: "managedDiskCustomerKeyUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedDiskCustomerKeyUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#node_count CosmosdbCassandraDatacenter#node_count}.</summary>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NodeCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#sku_name CosmosdbCassandraDatacenter#sku_name}.</summary>
        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SkuName
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#timeouts CosmosdbCassandraDatacenter#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraDatacenter.CosmosdbCassandraDatacenterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CosmosdbCassandraDatacenter.ICosmosdbCassandraDatacenterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbCassandraDatacenterConfig), fullyQualifiedName: "azurerm.cosmosdbCassandraDatacenter.CosmosdbCassandraDatacenterConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbCassandraDatacenter.ICosmosdbCassandraDatacenterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#cassandra_cluster_id CosmosdbCassandraDatacenter#cassandra_cluster_id}.</summary>
            [JsiiProperty(name: "cassandraClusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string CassandraClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#delegated_management_subnet_id CosmosdbCassandraDatacenter#delegated_management_subnet_id}.</summary>
            [JsiiProperty(name: "delegatedManagementSubnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string DelegatedManagementSubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#location CosmosdbCassandraDatacenter#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#name CosmosdbCassandraDatacenter#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#availability_zones_enabled CosmosdbCassandraDatacenter#availability_zones_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZonesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AvailabilityZonesEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#backup_storage_customer_key_uri CosmosdbCassandraDatacenter#backup_storage_customer_key_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupStorageCustomerKeyUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupStorageCustomerKeyUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#base64_encoded_yaml_fragment CosmosdbCassandraDatacenter#base64_encoded_yaml_fragment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "base64EncodedYamlFragment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Base64EncodedYamlFragment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#disk_count CosmosdbCassandraDatacenter#disk_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#disk_sku CosmosdbCassandraDatacenter#disk_sku}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskSku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DiskSku
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#id CosmosdbCassandraDatacenter#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#managed_disk_customer_key_uri CosmosdbCassandraDatacenter#managed_disk_customer_key_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedDiskCustomerKeyUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedDiskCustomerKeyUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#node_count CosmosdbCassandraDatacenter#node_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NodeCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#sku_name CosmosdbCassandraDatacenter#sku_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SkuName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_cassandra_datacenter#timeouts CosmosdbCassandraDatacenter#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraDatacenter.CosmosdbCassandraDatacenterTimeouts\"}", isOptional: true)]
            public azurerm.CosmosdbCassandraDatacenter.ICosmosdbCassandraDatacenterTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.CosmosdbCassandraDatacenter.ICosmosdbCassandraDatacenterTimeouts?>();
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
