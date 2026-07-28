using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedRedis
{
    [JsiiByValue(fqn: "azurerm.managedRedis.ManagedRedisDefaultDatabase")]
    public class ManagedRedisDefaultDatabase : azurerm.ManagedRedis.IManagedRedisDefaultDatabase
    {
        private object? _accessKeysAuthenticationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#access_keys_authentication_enabled ManagedRedis#access_keys_authentication_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessKeysAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AccessKeysAuthenticationEnabled
        {
            get => _accessKeysAuthenticationEnabled;
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
                _accessKeysAuthenticationEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#client_protocol ManagedRedis#client_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#clustering_policy ManagedRedis#clustering_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusteringPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusteringPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#eviction_policy ManagedRedis#eviction_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EvictionPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#geo_replication_group_name ManagedRedis#geo_replication_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geoReplicationGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GeoReplicationGroupName
        {
            get;
            set;
        }

        private object? _module;

        /// <summary>module block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#module ManagedRedis#module}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "module", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedRedis.ManagedRedisDefaultDatabaseModule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Module
        {
            get => _module;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _module = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#persistence_append_only_file_backup_frequency ManagedRedis#persistence_append_only_file_backup_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "persistenceAppendOnlyFileBackupFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PersistenceAppendOnlyFileBackupFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_redis#persistence_redis_database_backup_frequency ManagedRedis#persistence_redis_database_backup_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "persistenceRedisDatabaseBackupFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PersistenceRedisDatabaseBackupFrequency
        {
            get;
            set;
        }
    }
}
