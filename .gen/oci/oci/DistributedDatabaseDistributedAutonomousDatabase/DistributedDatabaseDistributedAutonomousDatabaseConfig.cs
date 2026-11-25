using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseConfig")]
    public class DistributedDatabaseDistributedAutonomousDatabaseConfig : oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseConfig
    {
        private object _catalogDetails;

        /// <summary>catalog_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#catalog_details DistributedDatabaseDistributedAutonomousDatabase#catalog_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "catalogDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetails\"},\"kind\":\"array\"}}]}}")]
        public object CatalogDetails
        {
            get => _catalogDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _catalogDetails = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#character_set DistributedDatabaseDistributedAutonomousDatabase#character_set}.</summary>
        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        public string CharacterSet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#compartment_id DistributedDatabaseDistributedAutonomousDatabase#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#database_version DistributedDatabaseDistributedAutonomousDatabase#database_version}.</summary>
        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#db_workload_type DistributedDatabaseDistributedAutonomousDatabase#db_workload_type}.</summary>
        [JsiiProperty(name: "dbWorkloadType", typeJson: "{\"primitive\":\"string\"}")]
        public string DbWorkloadType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#display_name DistributedDatabaseDistributedAutonomousDatabase#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#listener_port DistributedDatabaseDistributedAutonomousDatabase#listener_port}.</summary>
        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
        public double ListenerPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#ncharacter_set DistributedDatabaseDistributedAutonomousDatabase#ncharacter_set}.</summary>
        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        public string NcharacterSet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#ons_port_local DistributedDatabaseDistributedAutonomousDatabase#ons_port_local}.</summary>
        [JsiiProperty(name: "onsPortLocal", typeJson: "{\"primitive\":\"number\"}")]
        public double OnsPortLocal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#ons_port_remote DistributedDatabaseDistributedAutonomousDatabase#ons_port_remote}.</summary>
        [JsiiProperty(name: "onsPortRemote", typeJson: "{\"primitive\":\"number\"}")]
        public double OnsPortRemote
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#prefix DistributedDatabaseDistributedAutonomousDatabase#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public string Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#private_endpoint_ids DistributedDatabaseDistributedAutonomousDatabase#private_endpoint_ids}.</summary>
        [JsiiProperty(name: "privateEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] PrivateEndpointIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#add_gds_control_node_trigger DistributedDatabaseDistributedAutonomousDatabase#add_gds_control_node_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addGdsControlNodeTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AddGdsControlNodeTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#change_db_backup_config_trigger DistributedDatabaseDistributedAutonomousDatabase#change_db_backup_config_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "changeDbBackupConfigTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ChangeDbBackupConfigTrigger
        {
            get;
            set;
        }

        private object? _compositeDataGuardShardSpaces;

        /// <summary>composite_data_guard_shard_spaces block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#composite_data_guard_shard_spaces DistributedDatabaseDistributedAutonomousDatabase#composite_data_guard_shard_spaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCompositeDataGuardShardSpaces" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compositeDataGuardShardSpaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCompositeDataGuardShardSpaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CompositeDataGuardShardSpaces
        {
            get => _compositeDataGuardShardSpaces;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCompositeDataGuardShardSpaces[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCompositeDataGuardShardSpaces).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _compositeDataGuardShardSpaces = value;
            }
        }

        private object? _compositeRaftShardSpaces;

        /// <summary>composite_raft_shard_spaces block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#composite_raft_shard_spaces DistributedDatabaseDistributedAutonomousDatabase#composite_raft_shard_spaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpaces" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compositeRaftShardSpaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CompositeRaftShardSpaces
        {
            get => _compositeRaftShardSpaces;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpaces[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpaces).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _compositeRaftShardSpaces = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#configure_auto_resource_management_trigger DistributedDatabaseDistributedAutonomousDatabase#configure_auto_resource_management_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configureAutoResourceManagementTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConfigureAutoResourceManagementTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#configure_gsm_wallet_trigger DistributedDatabaseDistributedAutonomousDatabase#configure_gsm_wallet_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configureGsmWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConfigureGsmWalletTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#configure_sharding_trigger DistributedDatabaseDistributedAutonomousDatabase#configure_sharding_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configureShardingTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConfigureShardingTrigger
        {
            get;
            set;
        }

        /// <summary>db_backup_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#db_backup_config DistributedDatabaseDistributedAutonomousDatabase#db_backup_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig\"}", isOptional: true)]
        public oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig? DbBackupConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#defined_tags DistributedDatabaseDistributedAutonomousDatabase#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#freeform_tags DistributedDatabaseDistributedAutonomousDatabase#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#generate_wallet_trigger DistributedDatabaseDistributedAutonomousDatabase#generate_wallet_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GenerateWalletTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#id DistributedDatabaseDistributedAutonomousDatabase#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#listener_port_tls DistributedDatabaseDistributedAutonomousDatabase#listener_port_tls}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "listenerPortTls", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ListenerPortTls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#move_replication_unit_trigger DistributedDatabaseDistributedAutonomousDatabase#move_replication_unit_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "moveReplicationUnitTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MoveReplicationUnitTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#notification_topic_ids DistributedDatabaseDistributedAutonomousDatabase#notification_topic_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationTopicIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotificationTopicIds
        {
            get;
            set;
        }

        /// <summary>Desired operational state of an existing database: AVAILABLE to start or STOPPED to stop.</summary>
        /// <remarks>
        /// Omit during creation and to leave start/stop unmanaged.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#operational_state DistributedDatabaseDistributedAutonomousDatabase#operational_state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "operationalState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OperationalState
        {
            get;
            set;
        }

        private object? _patchOperations;

        /// <summary>patch_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#patch_operations DistributedDatabaseDistributedAutonomousDatabase#patch_operations}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabasePatchOperations" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabasePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PatchOperations
        {
            get => _patchOperations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabasePatchOperations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabasePatchOperations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _patchOperations = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#recreate_failed_resource_trigger DistributedDatabaseDistributedAutonomousDatabase#recreate_failed_resource_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recreateFailedResourceTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RecreateFailedResourceTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#scale_gsms_trigger DistributedDatabaseDistributedAutonomousDatabase#scale_gsms_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleGsmsTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScaleGsmsTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#start_database_trigger DistributedDatabaseDistributedAutonomousDatabase#start_database_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartDatabaseTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#stop_database_trigger DistributedDatabaseDistributedAutonomousDatabase#stop_database_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stopDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StopDatabaseTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#system_chunk_count DistributedDatabaseDistributedAutonomousDatabase#system_chunk_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemChunkCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SystemChunkCount
        {
            get;
            set;
        }

        /// <summary>system_data_guard_databases block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#system_data_guard_databases DistributedDatabaseDistributedAutonomousDatabase#system_data_guard_databases}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "systemDataGuardDatabases", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabases\"}", isOptional: true)]
        public oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabases? SystemDataGuardDatabases
        {
            get;
            set;
        }

        private object? _systemRaftClusters;

        /// <summary>system_raft_clusters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#system_raft_clusters DistributedDatabaseDistributedAutonomousDatabase#system_raft_clusters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseSystemRaftClusters" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "systemRaftClusters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseSystemRaftClusters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SystemRaftClusters
        {
            get => _systemRaftClusters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseSystemRaftClusters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseSystemRaftClusters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _systemRaftClusters = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#system_raft_replication_unit_count DistributedDatabaseDistributedAutonomousDatabase#system_raft_replication_unit_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemRaftReplicationUnitCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SystemRaftReplicationUnitCount
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#timeouts DistributedDatabaseDistributedAutonomousDatabase#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseTimeouts\"}", isOptional: true)]
        public oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _userShardSpaces;

        /// <summary>user_shard_spaces block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#user_shard_spaces DistributedDatabaseDistributedAutonomousDatabase#user_shard_spaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpaces" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userShardSpaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseUserShardSpaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UserShardSpaces
        {
            get => _userShardSpaces;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpaces[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpaces).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _userShardSpaces = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#validate_ca_bundle_trigger DistributedDatabaseDistributedAutonomousDatabase#validate_ca_bundle_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "validateCaBundleTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ValidateCaBundleTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#validate_network_trigger DistributedDatabaseDistributedAutonomousDatabase#validate_network_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ValidateNetworkTrigger
        {
            get;
            set;
        }

        private object? _vcnNsgIds;

        /// <summary>vcn_nsg_ids block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#vcn_nsg_ids DistributedDatabaseDistributedAutonomousDatabase#vcn_nsg_ids}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseVcnNsgIds" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcnNsgIds", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseVcnNsgIds\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VcnNsgIds
        {
            get => _vcnNsgIds;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseVcnNsgIds[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseVcnNsgIds).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vcnNsgIds = value;
            }
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
