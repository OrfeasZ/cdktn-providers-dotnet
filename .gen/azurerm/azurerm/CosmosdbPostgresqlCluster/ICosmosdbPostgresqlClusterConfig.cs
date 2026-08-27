using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbPostgresqlCluster
{
    [JsiiInterface(nativeType: typeof(ICosmosdbPostgresqlClusterConfig), fullyQualifiedName: "azurerm.cosmosdbPostgresqlCluster.CosmosdbPostgresqlClusterConfig")]
    public interface ICosmosdbPostgresqlClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#location CosmosdbPostgresqlCluster#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#name CosmosdbPostgresqlCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#node_count CosmosdbPostgresqlCluster#node_count}.</summary>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double NodeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#resource_group_name CosmosdbPostgresqlCluster#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#administrator_login_password CosmosdbPostgresqlCluster#administrator_login_password}.</summary>
        [JsiiProperty(name: "administratorLoginPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdministratorLoginPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#citus_version CosmosdbPostgresqlCluster#citus_version}.</summary>
        [JsiiProperty(name: "citusVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CitusVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_public_ip_access_enabled CosmosdbPostgresqlCluster#coordinator_public_ip_access_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "coordinatorPublicIpAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CoordinatorPublicIpAccessEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_server_edition CosmosdbPostgresqlCluster#coordinator_server_edition}.</summary>
        [JsiiProperty(name: "coordinatorServerEdition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CoordinatorServerEdition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_storage_quota_in_mb CosmosdbPostgresqlCluster#coordinator_storage_quota_in_mb}.</summary>
        [JsiiProperty(name: "coordinatorStorageQuotaInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoordinatorStorageQuotaInMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_vcore_count CosmosdbPostgresqlCluster#coordinator_vcore_count}.</summary>
        [JsiiProperty(name: "coordinatorVcoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoordinatorVcoreCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#ha_enabled CosmosdbPostgresqlCluster#ha_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "haEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HaEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#id CosmosdbPostgresqlCluster#id}.</summary>
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

        /// <summary>maintenance_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#maintenance_window CosmosdbPostgresqlCluster#maintenance_window}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"azurerm.cosmosdbPostgresqlCluster.CosmosdbPostgresqlClusterMaintenanceWindow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CosmosdbPostgresqlCluster.ICosmosdbPostgresqlClusterMaintenanceWindow? MaintenanceWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#node_public_ip_access_enabled CosmosdbPostgresqlCluster#node_public_ip_access_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "nodePublicIpAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NodePublicIpAccessEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#node_server_edition CosmosdbPostgresqlCluster#node_server_edition}.</summary>
        [JsiiProperty(name: "nodeServerEdition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeServerEdition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#node_storage_quota_in_mb CosmosdbPostgresqlCluster#node_storage_quota_in_mb}.</summary>
        [JsiiProperty(name: "nodeStorageQuotaInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NodeStorageQuotaInMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#node_vcores CosmosdbPostgresqlCluster#node_vcores}.</summary>
        [JsiiProperty(name: "nodeVcores", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NodeVcores
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#point_in_time_in_utc CosmosdbPostgresqlCluster#point_in_time_in_utc}.</summary>
        [JsiiProperty(name: "pointInTimeInUtc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PointInTimeInUtc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#preferred_primary_zone CosmosdbPostgresqlCluster#preferred_primary_zone}.</summary>
        [JsiiProperty(name: "preferredPrimaryZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredPrimaryZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#shards_on_coordinator_enabled CosmosdbPostgresqlCluster#shards_on_coordinator_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "shardsOnCoordinatorEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShardsOnCoordinatorEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#source_location CosmosdbPostgresqlCluster#source_location}.</summary>
        [JsiiProperty(name: "sourceLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#source_resource_id CosmosdbPostgresqlCluster#source_resource_id}.</summary>
        [JsiiProperty(name: "sourceResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#sql_version CosmosdbPostgresqlCluster#sql_version}.</summary>
        [JsiiProperty(name: "sqlVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqlVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#tags CosmosdbPostgresqlCluster#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#timeouts CosmosdbPostgresqlCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cosmosdbPostgresqlCluster.CosmosdbPostgresqlClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CosmosdbPostgresqlCluster.ICosmosdbPostgresqlClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbPostgresqlClusterConfig), fullyQualifiedName: "azurerm.cosmosdbPostgresqlCluster.CosmosdbPostgresqlClusterConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbPostgresqlCluster.ICosmosdbPostgresqlClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#location CosmosdbPostgresqlCluster#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#name CosmosdbPostgresqlCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#node_count CosmosdbPostgresqlCluster#node_count}.</summary>
            [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double NodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#resource_group_name CosmosdbPostgresqlCluster#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#administrator_login_password CosmosdbPostgresqlCluster#administrator_login_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "administratorLoginPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdministratorLoginPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#citus_version CosmosdbPostgresqlCluster#citus_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "citusVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CitusVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_public_ip_access_enabled CosmosdbPostgresqlCluster#coordinator_public_ip_access_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "coordinatorPublicIpAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CoordinatorPublicIpAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_server_edition CosmosdbPostgresqlCluster#coordinator_server_edition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coordinatorServerEdition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CoordinatorServerEdition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_storage_quota_in_mb CosmosdbPostgresqlCluster#coordinator_storage_quota_in_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coordinatorStorageQuotaInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoordinatorStorageQuotaInMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_vcore_count CosmosdbPostgresqlCluster#coordinator_vcore_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coordinatorVcoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoordinatorVcoreCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#ha_enabled CosmosdbPostgresqlCluster#ha_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "haEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HaEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#id CosmosdbPostgresqlCluster#id}.</summary>
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

            /// <summary>maintenance_window block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#maintenance_window CosmosdbPostgresqlCluster#maintenance_window}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"azurerm.cosmosdbPostgresqlCluster.CosmosdbPostgresqlClusterMaintenanceWindow\"}", isOptional: true)]
            public azurerm.CosmosdbPostgresqlCluster.ICosmosdbPostgresqlClusterMaintenanceWindow? MaintenanceWindow
            {
                get => GetInstanceProperty<azurerm.CosmosdbPostgresqlCluster.ICosmosdbPostgresqlClusterMaintenanceWindow?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#node_public_ip_access_enabled CosmosdbPostgresqlCluster#node_public_ip_access_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodePublicIpAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? NodePublicIpAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#node_server_edition CosmosdbPostgresqlCluster#node_server_edition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeServerEdition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeServerEdition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#node_storage_quota_in_mb CosmosdbPostgresqlCluster#node_storage_quota_in_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeStorageQuotaInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NodeStorageQuotaInMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#node_vcores CosmosdbPostgresqlCluster#node_vcores}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeVcores", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NodeVcores
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#point_in_time_in_utc CosmosdbPostgresqlCluster#point_in_time_in_utc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pointInTimeInUtc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PointInTimeInUtc
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#preferred_primary_zone CosmosdbPostgresqlCluster#preferred_primary_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredPrimaryZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredPrimaryZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#shards_on_coordinator_enabled CosmosdbPostgresqlCluster#shards_on_coordinator_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shardsOnCoordinatorEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShardsOnCoordinatorEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#source_location CosmosdbPostgresqlCluster#source_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceLocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#source_resource_id CosmosdbPostgresqlCluster#source_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#sql_version CosmosdbPostgresqlCluster#sql_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqlVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqlVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#tags CosmosdbPostgresqlCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cosmosdb_postgresql_cluster#timeouts CosmosdbPostgresqlCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cosmosdbPostgresqlCluster.CosmosdbPostgresqlClusterTimeouts\"}", isOptional: true)]
            public azurerm.CosmosdbPostgresqlCluster.ICosmosdbPostgresqlClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.CosmosdbPostgresqlCluster.ICosmosdbPostgresqlClusterTimeouts?>();
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
