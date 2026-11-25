using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabaseConfig), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseConfig")]
    public interface IDistributedDatabaseDistributedDatabaseConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>catalog_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#catalog_details DistributedDatabaseDistributedDatabase#catalog_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetails" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "catalogDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetails\"},\"kind\":\"array\"}}]}}")]
        object CatalogDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#character_set DistributedDatabaseDistributedDatabase#character_set}.</summary>
        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        string CharacterSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#compartment_id DistributedDatabaseDistributedDatabase#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#database_version DistributedDatabaseDistributedDatabase#database_version}.</summary>
        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#display_name DistributedDatabaseDistributedDatabase#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#listener_port DistributedDatabaseDistributedDatabase#listener_port}.</summary>
        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
        double ListenerPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#ncharacter_set DistributedDatabaseDistributedDatabase#ncharacter_set}.</summary>
        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        string NcharacterSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#ons_port_local DistributedDatabaseDistributedDatabase#ons_port_local}.</summary>
        [JsiiProperty(name: "onsPortLocal", typeJson: "{\"primitive\":\"number\"}")]
        double OnsPortLocal
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#ons_port_remote DistributedDatabaseDistributedDatabase#ons_port_remote}.</summary>
        [JsiiProperty(name: "onsPortRemote", typeJson: "{\"primitive\":\"number\"}")]
        double OnsPortRemote
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#prefix DistributedDatabaseDistributedDatabase#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#private_endpoint_ids DistributedDatabaseDistributedDatabase#private_endpoint_ids}.</summary>
        [JsiiProperty(name: "privateEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] PrivateEndpointIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#add_gds_control_node_trigger DistributedDatabaseDistributedDatabase#add_gds_control_node_trigger}.</summary>
        [JsiiProperty(name: "addGdsControlNodeTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AddGdsControlNodeTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#change_db_backup_config_trigger DistributedDatabaseDistributedDatabase#change_db_backup_config_trigger}.</summary>
        [JsiiProperty(name: "changeDbBackupConfigTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ChangeDbBackupConfigTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>composite_data_guard_shard_spaces block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#composite_data_guard_shard_spaces DistributedDatabaseDistributedDatabase#composite_data_guard_shard_spaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpaces" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "compositeDataGuardShardSpaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CompositeDataGuardShardSpaces
        {
            get
            {
                return null;
            }
        }

        /// <summary>composite_raft_shard_spaces block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#composite_raft_shard_spaces DistributedDatabaseDistributedDatabase#composite_raft_shard_spaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpaces" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "compositeRaftShardSpaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeRaftShardSpaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CompositeRaftShardSpaces
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#configure_auto_resource_management_trigger DistributedDatabaseDistributedDatabase#configure_auto_resource_management_trigger}.</summary>
        [JsiiProperty(name: "configureAutoResourceManagementTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConfigureAutoResourceManagementTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#configure_sharding_trigger DistributedDatabaseDistributedDatabase#configure_sharding_trigger}.</summary>
        [JsiiProperty(name: "configureShardingTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConfigureShardingTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>db_backup_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#db_backup_config DistributedDatabaseDistributedDatabase#db_backup_config}
        /// </remarks>
        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseDbBackupConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseDbBackupConfig? DbBackupConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#defined_tags DistributedDatabaseDistributedDatabase#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#freeform_tags DistributedDatabaseDistributedDatabase#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#generate_wallet_trigger DistributedDatabaseDistributedDatabase#generate_wallet_trigger}.</summary>
        [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GenerateWalletTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#gsm_ssh_public_key DistributedDatabaseDistributedDatabase#gsm_ssh_public_key}.</summary>
        [JsiiProperty(name: "gsmSshPublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GsmSshPublicKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#id DistributedDatabaseDistributedDatabase#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#listener_port_tls DistributedDatabaseDistributedDatabase#listener_port_tls}.</summary>
        [JsiiProperty(name: "listenerPortTls", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ListenerPortTls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#move_replication_unit_trigger DistributedDatabaseDistributedDatabase#move_replication_unit_trigger}.</summary>
        [JsiiProperty(name: "moveReplicationUnitTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MoveReplicationUnitTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#notification_topic_ids DistributedDatabaseDistributedDatabase#notification_topic_ids}.</summary>
        [JsiiProperty(name: "notificationTopicIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotificationTopicIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Desired operational state of an existing database: AVAILABLE to start or STOPPED to stop.</summary>
        /// <remarks>
        /// Omit during creation and to leave start/stop unmanaged.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#operational_state DistributedDatabaseDistributedDatabase#operational_state}
        /// </remarks>
        [JsiiProperty(name: "operationalState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperationalState
        {
            get
            {
                return null;
            }
        }

        /// <summary>patch_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#patch_operations DistributedDatabaseDistributedDatabase#patch_operations}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabasePatchOperations" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabasePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PatchOperations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#recreate_failed_resource_trigger DistributedDatabaseDistributedDatabase#recreate_failed_resource_trigger}.</summary>
        [JsiiProperty(name: "recreateFailedResourceTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RecreateFailedResourceTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#scale_gsms_trigger DistributedDatabaseDistributedDatabase#scale_gsms_trigger}.</summary>
        [JsiiProperty(name: "scaleGsmsTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleGsmsTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#scan_listener_port DistributedDatabaseDistributedDatabase#scan_listener_port}.</summary>
        [JsiiProperty(name: "scanListenerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScanListenerPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#start_database_trigger DistributedDatabaseDistributedDatabase#start_database_trigger}.</summary>
        [JsiiProperty(name: "startDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartDatabaseTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#stop_database_trigger DistributedDatabaseDistributedDatabase#stop_database_trigger}.</summary>
        [JsiiProperty(name: "stopDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StopDatabaseTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#system_chunk_count DistributedDatabaseDistributedDatabase#system_chunk_count}.</summary>
        [JsiiProperty(name: "systemChunkCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SystemChunkCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>system_data_guard_databases block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#system_data_guard_databases DistributedDatabaseDistributedDatabase#system_data_guard_databases}
        /// </remarks>
        [JsiiProperty(name: "systemDataGuardDatabases", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseSystemDataGuardDatabases\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseSystemDataGuardDatabases? SystemDataGuardDatabases
        {
            get
            {
                return null;
            }
        }

        /// <summary>system_raft_clusters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#system_raft_clusters DistributedDatabaseDistributedDatabase#system_raft_clusters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseSystemRaftClusters" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "systemRaftClusters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseSystemRaftClusters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SystemRaftClusters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#system_raft_replication_unit_count DistributedDatabaseDistributedDatabase#system_raft_replication_unit_count}.</summary>
        [JsiiProperty(name: "systemRaftReplicationUnitCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SystemRaftReplicationUnitCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#timeouts DistributedDatabaseDistributedDatabase#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_shard_spaces block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#user_shard_spaces DistributedDatabaseDistributedDatabase#user_shard_spaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseUserShardSpaces" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "userShardSpaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseUserShardSpaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserShardSpaces
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#validate_network_trigger DistributedDatabaseDistributedDatabase#validate_network_trigger}.</summary>
        [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ValidateNetworkTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>vcn_nsg_ids block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#vcn_nsg_ids DistributedDatabaseDistributedDatabase#vcn_nsg_ids}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseVcnNsgIds" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "vcnNsgIds", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseVcnNsgIds\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VcnNsgIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabaseConfig), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>catalog_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#catalog_details DistributedDatabaseDistributedDatabase#catalog_details}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetails" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "catalogDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetails\"},\"kind\":\"array\"}}]}}")]
            public object CatalogDetails
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#character_set DistributedDatabaseDistributedDatabase#character_set}.</summary>
            [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
            public string CharacterSet
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#compartment_id DistributedDatabaseDistributedDatabase#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#database_version DistributedDatabaseDistributedDatabase#database_version}.</summary>
            [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#display_name DistributedDatabaseDistributedDatabase#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#listener_port DistributedDatabaseDistributedDatabase#listener_port}.</summary>
            [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ListenerPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#ncharacter_set DistributedDatabaseDistributedDatabase#ncharacter_set}.</summary>
            [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
            public string NcharacterSet
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#ons_port_local DistributedDatabaseDistributedDatabase#ons_port_local}.</summary>
            [JsiiProperty(name: "onsPortLocal", typeJson: "{\"primitive\":\"number\"}")]
            public double OnsPortLocal
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#ons_port_remote DistributedDatabaseDistributedDatabase#ons_port_remote}.</summary>
            [JsiiProperty(name: "onsPortRemote", typeJson: "{\"primitive\":\"number\"}")]
            public double OnsPortRemote
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#prefix DistributedDatabaseDistributedDatabase#prefix}.</summary>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#private_endpoint_ids DistributedDatabaseDistributedDatabase#private_endpoint_ids}.</summary>
            [JsiiProperty(name: "privateEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] PrivateEndpointIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#add_gds_control_node_trigger DistributedDatabaseDistributedDatabase#add_gds_control_node_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "addGdsControlNodeTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AddGdsControlNodeTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#change_db_backup_config_trigger DistributedDatabaseDistributedDatabase#change_db_backup_config_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "changeDbBackupConfigTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ChangeDbBackupConfigTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>composite_data_guard_shard_spaces block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#composite_data_guard_shard_spaces DistributedDatabaseDistributedDatabase#composite_data_guard_shard_spaces}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpaces" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compositeDataGuardShardSpaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CompositeDataGuardShardSpaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>composite_raft_shard_spaces block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#composite_raft_shard_spaces DistributedDatabaseDistributedDatabase#composite_raft_shard_spaces}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpaces" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compositeRaftShardSpaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeRaftShardSpaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CompositeRaftShardSpaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#configure_auto_resource_management_trigger DistributedDatabaseDistributedDatabase#configure_auto_resource_management_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configureAutoResourceManagementTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConfigureAutoResourceManagementTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#configure_sharding_trigger DistributedDatabaseDistributedDatabase#configure_sharding_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configureShardingTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConfigureShardingTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>db_backup_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#db_backup_config DistributedDatabaseDistributedDatabase#db_backup_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseDbBackupConfig\"}", isOptional: true)]
            public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseDbBackupConfig? DbBackupConfig
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseDbBackupConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#defined_tags DistributedDatabaseDistributedDatabase#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#freeform_tags DistributedDatabaseDistributedDatabase#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#generate_wallet_trigger DistributedDatabaseDistributedDatabase#generate_wallet_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GenerateWalletTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#gsm_ssh_public_key DistributedDatabaseDistributedDatabase#gsm_ssh_public_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gsmSshPublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GsmSshPublicKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#id DistributedDatabaseDistributedDatabase#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#listener_port_tls DistributedDatabaseDistributedDatabase#listener_port_tls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "listenerPortTls", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ListenerPortTls
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#move_replication_unit_trigger DistributedDatabaseDistributedDatabase#move_replication_unit_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "moveReplicationUnitTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MoveReplicationUnitTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#notification_topic_ids DistributedDatabaseDistributedDatabase#notification_topic_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notificationTopicIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotificationTopicIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Desired operational state of an existing database: AVAILABLE to start or STOPPED to stop.</summary>
            /// <remarks>
            /// Omit during creation and to leave start/stop unmanaged.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#operational_state DistributedDatabaseDistributedDatabase#operational_state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "operationalState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperationalState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>patch_operations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#patch_operations DistributedDatabaseDistributedDatabase#patch_operations}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabasePatchOperations" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabasePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PatchOperations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#recreate_failed_resource_trigger DistributedDatabaseDistributedDatabase#recreate_failed_resource_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recreateFailedResourceTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RecreateFailedResourceTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#scale_gsms_trigger DistributedDatabaseDistributedDatabase#scale_gsms_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleGsmsTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleGsmsTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#scan_listener_port DistributedDatabaseDistributedDatabase#scan_listener_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scanListenerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScanListenerPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#start_database_trigger DistributedDatabaseDistributedDatabase#start_database_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartDatabaseTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#stop_database_trigger DistributedDatabaseDistributedDatabase#stop_database_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stopDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StopDatabaseTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#system_chunk_count DistributedDatabaseDistributedDatabase#system_chunk_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemChunkCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SystemChunkCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>system_data_guard_databases block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#system_data_guard_databases DistributedDatabaseDistributedDatabase#system_data_guard_databases}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "systemDataGuardDatabases", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseSystemDataGuardDatabases\"}", isOptional: true)]
            public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseSystemDataGuardDatabases? SystemDataGuardDatabases
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseSystemDataGuardDatabases?>();
            }

            /// <summary>system_raft_clusters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#system_raft_clusters DistributedDatabaseDistributedDatabase#system_raft_clusters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseSystemRaftClusters" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "systemRaftClusters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseSystemRaftClusters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SystemRaftClusters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#system_raft_replication_unit_count DistributedDatabaseDistributedDatabase#system_raft_replication_unit_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemRaftReplicationUnitCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SystemRaftReplicationUnitCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#timeouts DistributedDatabaseDistributedDatabase#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseTimeouts\"}", isOptional: true)]
            public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseTimeouts?>();
            }

            /// <summary>user_shard_spaces block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#user_shard_spaces DistributedDatabaseDistributedDatabase#user_shard_spaces}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseUserShardSpaces" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userShardSpaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseUserShardSpaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UserShardSpaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#validate_network_trigger DistributedDatabaseDistributedDatabase#validate_network_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ValidateNetworkTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>vcn_nsg_ids block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#vcn_nsg_ids DistributedDatabaseDistributedDatabase#vcn_nsg_ids}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseVcnNsgIds" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcnNsgIds", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseVcnNsgIds\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VcnNsgIds
            {
                get => GetInstanceProperty<object?>();
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
