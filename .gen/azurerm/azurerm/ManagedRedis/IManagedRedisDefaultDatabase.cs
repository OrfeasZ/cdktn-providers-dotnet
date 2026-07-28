using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedRedis
{
    [JsiiInterface(nativeType: typeof(IManagedRedisDefaultDatabase), fullyQualifiedName: "azurerm.managedRedis.ManagedRedisDefaultDatabase")]
    public interface IManagedRedisDefaultDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#access_keys_authentication_enabled ManagedRedis#access_keys_authentication_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "accessKeysAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AccessKeysAuthenticationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#client_protocol ManagedRedis#client_protocol}.</summary>
        [JsiiProperty(name: "clientProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientProtocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#clustering_policy ManagedRedis#clustering_policy}.</summary>
        [JsiiProperty(name: "clusteringPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusteringPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#eviction_policy ManagedRedis#eviction_policy}.</summary>
        [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EvictionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#geo_replication_group_name ManagedRedis#geo_replication_group_name}.</summary>
        [JsiiProperty(name: "geoReplicationGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GeoReplicationGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>module block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#module ManagedRedis#module}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "module", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedRedis.ManagedRedisDefaultDatabaseModule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Module
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#persistence_append_only_file_backup_frequency ManagedRedis#persistence_append_only_file_backup_frequency}.</summary>
        [JsiiProperty(name: "persistenceAppendOnlyFileBackupFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PersistenceAppendOnlyFileBackupFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#persistence_redis_database_backup_frequency ManagedRedis#persistence_redis_database_backup_frequency}.</summary>
        [JsiiProperty(name: "persistenceRedisDatabaseBackupFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PersistenceRedisDatabaseBackupFrequency
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedRedisDefaultDatabase), fullyQualifiedName: "azurerm.managedRedis.ManagedRedisDefaultDatabase")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedRedis.IManagedRedisDefaultDatabase
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#access_keys_authentication_enabled ManagedRedis#access_keys_authentication_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessKeysAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AccessKeysAuthenticationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#client_protocol ManagedRedis#client_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientProtocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#clustering_policy ManagedRedis#clustering_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusteringPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusteringPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#eviction_policy ManagedRedis#eviction_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EvictionPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#geo_replication_group_name ManagedRedis#geo_replication_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geoReplicationGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GeoReplicationGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>module block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#module ManagedRedis#module}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "module", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedRedis.ManagedRedisDefaultDatabaseModule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Module
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#persistence_append_only_file_backup_frequency ManagedRedis#persistence_append_only_file_backup_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "persistenceAppendOnlyFileBackupFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PersistenceAppendOnlyFileBackupFrequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#persistence_redis_database_backup_frequency ManagedRedis#persistence_redis_database_backup_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "persistenceRedisDatabaseBackupFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PersistenceRedisDatabaseBackupFrequency
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
