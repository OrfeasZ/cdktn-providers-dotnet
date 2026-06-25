using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseConfig), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseConfig")]
    public interface IDistributedDatabaseDistributedAutonomousDatabaseConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>catalog_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#catalog_details DistributedDatabaseDistributedAutonomousDatabase#catalog_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "catalogDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetails\"},\"kind\":\"array\"}}]}}")]
        object CatalogDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#character_set DistributedDatabaseDistributedAutonomousDatabase#character_set}.</summary>
        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        string CharacterSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#compartment_id DistributedDatabaseDistributedAutonomousDatabase#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#database_version DistributedDatabaseDistributedAutonomousDatabase#database_version}.</summary>
        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#db_deployment_type DistributedDatabaseDistributedAutonomousDatabase#db_deployment_type}.</summary>
        [JsiiProperty(name: "dbDeploymentType", typeJson: "{\"primitive\":\"string\"}")]
        string DbDeploymentType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#db_workload DistributedDatabaseDistributedAutonomousDatabase#db_workload}.</summary>
        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        string DbWorkload
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#display_name DistributedDatabaseDistributedAutonomousDatabase#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#listener_port DistributedDatabaseDistributedAutonomousDatabase#listener_port}.</summary>
        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
        double ListenerPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#ncharacter_set DistributedDatabaseDistributedAutonomousDatabase#ncharacter_set}.</summary>
        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        string NcharacterSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#ons_port_local DistributedDatabaseDistributedAutonomousDatabase#ons_port_local}.</summary>
        [JsiiProperty(name: "onsPortLocal", typeJson: "{\"primitive\":\"number\"}")]
        double OnsPortLocal
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#ons_port_remote DistributedDatabaseDistributedAutonomousDatabase#ons_port_remote}.</summary>
        [JsiiProperty(name: "onsPortRemote", typeJson: "{\"primitive\":\"number\"}")]
        double OnsPortRemote
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#prefix DistributedDatabaseDistributedAutonomousDatabase#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#private_endpoint_ids DistributedDatabaseDistributedAutonomousDatabase#private_endpoint_ids}.</summary>
        [JsiiProperty(name: "privateEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] PrivateEndpointIds
        {
            get;
        }

        /// <summary>shard_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#shard_details DistributedDatabaseDistributedAutonomousDatabase#shard_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseShardDetails" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "shardDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseShardDetails\"},\"kind\":\"array\"}}]}}")]
        object ShardDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#sharding_method DistributedDatabaseDistributedAutonomousDatabase#sharding_method}.</summary>
        [JsiiProperty(name: "shardingMethod", typeJson: "{\"primitive\":\"string\"}")]
        string ShardingMethod
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#ca_bundle_id DistributedDatabaseDistributedAutonomousDatabase#ca_bundle_id}.</summary>
        [JsiiProperty(name: "caBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaBundleId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#certificate_id DistributedDatabaseDistributedAutonomousDatabase#certificate_id}.</summary>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#change_db_backup_config_trigger DistributedDatabaseDistributedAutonomousDatabase#change_db_backup_config_trigger}.</summary>
        [JsiiProperty(name: "changeDbBackupConfigTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ChangeDbBackupConfigTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#chunks DistributedDatabaseDistributedAutonomousDatabase#chunks}.</summary>
        [JsiiProperty(name: "chunks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Chunks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#configure_gsm_wallet_trigger DistributedDatabaseDistributedAutonomousDatabase#configure_gsm_wallet_trigger}.</summary>
        [JsiiProperty(name: "configureGsmWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConfigureGsmWalletTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#configure_sharding_is_rebalance_required DistributedDatabaseDistributedAutonomousDatabase#configure_sharding_is_rebalance_required}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "configureShardingIsRebalanceRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConfigureShardingIsRebalanceRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#configure_sharding_trigger DistributedDatabaseDistributedAutonomousDatabase#configure_sharding_trigger}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#db_backup_config DistributedDatabaseDistributedAutonomousDatabase#db_backup_config}
        /// </remarks>
        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig? DbBackupConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#defined_tags DistributedDatabaseDistributedAutonomousDatabase#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#download_gsm_certificate_signing_request_trigger DistributedDatabaseDistributedAutonomousDatabase#download_gsm_certificate_signing_request_trigger}.</summary>
        [JsiiProperty(name: "downloadGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DownloadGsmCertificateSigningRequestTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#freeform_tags DistributedDatabaseDistributedAutonomousDatabase#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#generate_gsm_certificate_signing_request_trigger DistributedDatabaseDistributedAutonomousDatabase#generate_gsm_certificate_signing_request_trigger}.</summary>
        [JsiiProperty(name: "generateGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GenerateGsmCertificateSigningRequestTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#generate_gsm_certificate_signing_request_trigger_ca_bundle_id DistributedDatabaseDistributedAutonomousDatabase#generate_gsm_certificate_signing_request_trigger_ca_bundle_id}.</summary>
        [JsiiProperty(name: "generateGsmCertificateSigningRequestTriggerCaBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GenerateGsmCertificateSigningRequestTriggerCaBundleId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#generate_wallet_password DistributedDatabaseDistributedAutonomousDatabase#generate_wallet_password}.</summary>
        [JsiiProperty(name: "generateWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GenerateWalletPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#generate_wallet_trigger DistributedDatabaseDistributedAutonomousDatabase#generate_wallet_trigger}.</summary>
        [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GenerateWalletTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#id DistributedDatabaseDistributedAutonomousDatabase#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#listener_port_tls DistributedDatabaseDistributedAutonomousDatabase#listener_port_tls}.</summary>
        [JsiiProperty(name: "listenerPortTls", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ListenerPortTls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#move_replication_unit_trigger DistributedDatabaseDistributedAutonomousDatabase#move_replication_unit_trigger}.</summary>
        [JsiiProperty(name: "moveReplicationUnitTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MoveReplicationUnitTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>patch_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#patch_operations DistributedDatabaseDistributedAutonomousDatabase#patch_operations}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabasePatchOperations" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabasePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PatchOperations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#recreate_failed_resource_trigger DistributedDatabaseDistributedAutonomousDatabase#recreate_failed_resource_trigger}.</summary>
        [JsiiProperty(name: "recreateFailedResourceTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RecreateFailedResourceTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#replication_factor DistributedDatabaseDistributedAutonomousDatabase#replication_factor}.</summary>
        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplicationFactor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#replication_method DistributedDatabaseDistributedAutonomousDatabase#replication_method}.</summary>
        [JsiiProperty(name: "replicationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplicationMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#replication_unit DistributedDatabaseDistributedAutonomousDatabase#replication_unit}.</summary>
        [JsiiProperty(name: "replicationUnit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplicationUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Increment this value to trigger StartDistributedAutonomousDatabase action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#start_database_trigger DistributedDatabaseDistributedAutonomousDatabase#start_database_trigger}
        /// </remarks>
        [JsiiProperty(name: "startDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartDatabaseTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#state DistributedDatabaseDistributedAutonomousDatabase#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>Increment this value to trigger StopDistributedAutonomousDatabase action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#stop_database_trigger DistributedDatabaseDistributedAutonomousDatabase#stop_database_trigger}
        /// </remarks>
        [JsiiProperty(name: "stopDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StopDatabaseTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#timeouts DistributedDatabaseDistributedAutonomousDatabase#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#upload_ca_signed_certificate DistributedDatabaseDistributedAutonomousDatabase#upload_ca_signed_certificate}.</summary>
        [JsiiProperty(name: "uploadCaSignedCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UploadCaSignedCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#upload_signed_certificate_and_generate_wallet_trigger DistributedDatabaseDistributedAutonomousDatabase#upload_signed_certificate_and_generate_wallet_trigger}.</summary>
        [JsiiProperty(name: "uploadSignedCertificateAndGenerateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UploadSignedCertificateAndGenerateWalletTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#validate_ca_bundle_trigger DistributedDatabaseDistributedAutonomousDatabase#validate_ca_bundle_trigger}.</summary>
        [JsiiProperty(name: "validateCaBundleTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ValidateCaBundleTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>validate_network_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#validate_network_details DistributedDatabaseDistributedAutonomousDatabase#validate_network_details}
        /// </remarks>
        [JsiiProperty(name: "validateNetworkDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails? ValidateNetworkDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#validate_network_trigger DistributedDatabaseDistributedAutonomousDatabase#validate_network_trigger}.</summary>
        [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ValidateNetworkTrigger
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseConfig), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>catalog_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#catalog_details DistributedDatabaseDistributedAutonomousDatabase#catalog_details}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "catalogDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetails\"},\"kind\":\"array\"}}]}}")]
            public object CatalogDetails
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#character_set DistributedDatabaseDistributedAutonomousDatabase#character_set}.</summary>
            [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
            public string CharacterSet
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#compartment_id DistributedDatabaseDistributedAutonomousDatabase#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#database_version DistributedDatabaseDistributedAutonomousDatabase#database_version}.</summary>
            [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#db_deployment_type DistributedDatabaseDistributedAutonomousDatabase#db_deployment_type}.</summary>
            [JsiiProperty(name: "dbDeploymentType", typeJson: "{\"primitive\":\"string\"}")]
            public string DbDeploymentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#db_workload DistributedDatabaseDistributedAutonomousDatabase#db_workload}.</summary>
            [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
            public string DbWorkload
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#display_name DistributedDatabaseDistributedAutonomousDatabase#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#listener_port DistributedDatabaseDistributedAutonomousDatabase#listener_port}.</summary>
            [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ListenerPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#ncharacter_set DistributedDatabaseDistributedAutonomousDatabase#ncharacter_set}.</summary>
            [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
            public string NcharacterSet
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#ons_port_local DistributedDatabaseDistributedAutonomousDatabase#ons_port_local}.</summary>
            [JsiiProperty(name: "onsPortLocal", typeJson: "{\"primitive\":\"number\"}")]
            public double OnsPortLocal
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#ons_port_remote DistributedDatabaseDistributedAutonomousDatabase#ons_port_remote}.</summary>
            [JsiiProperty(name: "onsPortRemote", typeJson: "{\"primitive\":\"number\"}")]
            public double OnsPortRemote
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#prefix DistributedDatabaseDistributedAutonomousDatabase#prefix}.</summary>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#private_endpoint_ids DistributedDatabaseDistributedAutonomousDatabase#private_endpoint_ids}.</summary>
            [JsiiProperty(name: "privateEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] PrivateEndpointIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>shard_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#shard_details DistributedDatabaseDistributedAutonomousDatabase#shard_details}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseShardDetails" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "shardDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseShardDetails\"},\"kind\":\"array\"}}]}}")]
            public object ShardDetails
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#sharding_method DistributedDatabaseDistributedAutonomousDatabase#sharding_method}.</summary>
            [JsiiProperty(name: "shardingMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string ShardingMethod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#ca_bundle_id DistributedDatabaseDistributedAutonomousDatabase#ca_bundle_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaBundleId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#certificate_id DistributedDatabaseDistributedAutonomousDatabase#certificate_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#change_db_backup_config_trigger DistributedDatabaseDistributedAutonomousDatabase#change_db_backup_config_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "changeDbBackupConfigTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ChangeDbBackupConfigTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#chunks DistributedDatabaseDistributedAutonomousDatabase#chunks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "chunks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Chunks
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#configure_gsm_wallet_trigger DistributedDatabaseDistributedAutonomousDatabase#configure_gsm_wallet_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configureGsmWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConfigureGsmWalletTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#configure_sharding_is_rebalance_required DistributedDatabaseDistributedAutonomousDatabase#configure_sharding_is_rebalance_required}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configureShardingIsRebalanceRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ConfigureShardingIsRebalanceRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#configure_sharding_trigger DistributedDatabaseDistributedAutonomousDatabase#configure_sharding_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configureShardingTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConfigureShardingTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>db_backup_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#db_backup_config DistributedDatabaseDistributedAutonomousDatabase#db_backup_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig\"}", isOptional: true)]
            public oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig? DbBackupConfig
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#defined_tags DistributedDatabaseDistributedAutonomousDatabase#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#download_gsm_certificate_signing_request_trigger DistributedDatabaseDistributedAutonomousDatabase#download_gsm_certificate_signing_request_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "downloadGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DownloadGsmCertificateSigningRequestTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#freeform_tags DistributedDatabaseDistributedAutonomousDatabase#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#generate_gsm_certificate_signing_request_trigger DistributedDatabaseDistributedAutonomousDatabase#generate_gsm_certificate_signing_request_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "generateGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GenerateGsmCertificateSigningRequestTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#generate_gsm_certificate_signing_request_trigger_ca_bundle_id DistributedDatabaseDistributedAutonomousDatabase#generate_gsm_certificate_signing_request_trigger_ca_bundle_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "generateGsmCertificateSigningRequestTriggerCaBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GenerateGsmCertificateSigningRequestTriggerCaBundleId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#generate_wallet_password DistributedDatabaseDistributedAutonomousDatabase#generate_wallet_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "generateWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GenerateWalletPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#generate_wallet_trigger DistributedDatabaseDistributedAutonomousDatabase#generate_wallet_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GenerateWalletTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#id DistributedDatabaseDistributedAutonomousDatabase#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#listener_port_tls DistributedDatabaseDistributedAutonomousDatabase#listener_port_tls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "listenerPortTls", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ListenerPortTls
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#move_replication_unit_trigger DistributedDatabaseDistributedAutonomousDatabase#move_replication_unit_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "moveReplicationUnitTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MoveReplicationUnitTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>patch_operations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#patch_operations DistributedDatabaseDistributedAutonomousDatabase#patch_operations}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabasePatchOperations" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabasePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PatchOperations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#recreate_failed_resource_trigger DistributedDatabaseDistributedAutonomousDatabase#recreate_failed_resource_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recreateFailedResourceTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RecreateFailedResourceTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#replication_factor DistributedDatabaseDistributedAutonomousDatabase#replication_factor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplicationFactor
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#replication_method DistributedDatabaseDistributedAutonomousDatabase#replication_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplicationMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#replication_unit DistributedDatabaseDistributedAutonomousDatabase#replication_unit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationUnit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplicationUnit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Increment this value to trigger StartDistributedAutonomousDatabase action.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#start_database_trigger DistributedDatabaseDistributedAutonomousDatabase#start_database_trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartDatabaseTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#state DistributedDatabaseDistributedAutonomousDatabase#state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Increment this value to trigger StopDistributedAutonomousDatabase action.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#stop_database_trigger DistributedDatabaseDistributedAutonomousDatabase#stop_database_trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stopDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StopDatabaseTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#timeouts DistributedDatabaseDistributedAutonomousDatabase#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseTimeouts\"}", isOptional: true)]
            public oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#upload_ca_signed_certificate DistributedDatabaseDistributedAutonomousDatabase#upload_ca_signed_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uploadCaSignedCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UploadCaSignedCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#upload_signed_certificate_and_generate_wallet_trigger DistributedDatabaseDistributedAutonomousDatabase#upload_signed_certificate_and_generate_wallet_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uploadSignedCertificateAndGenerateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UploadSignedCertificateAndGenerateWalletTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#validate_ca_bundle_trigger DistributedDatabaseDistributedAutonomousDatabase#validate_ca_bundle_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validateCaBundleTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ValidateCaBundleTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>validate_network_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#validate_network_details DistributedDatabaseDistributedAutonomousDatabase#validate_network_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validateNetworkDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails\"}", isOptional: true)]
            public oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails? ValidateNetworkDetails
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/distributed_database_distributed_autonomous_database#validate_network_trigger DistributedDatabaseDistributedAutonomousDatabase#validate_network_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ValidateNetworkTrigger
            {
                get => GetInstanceProperty<double?>();
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
