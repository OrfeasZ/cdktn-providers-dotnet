using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseConfig")]
    public class DatabaseAutonomousContainerDatabaseConfig : oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#display_name DatabaseAutonomousContainerDatabase#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#patch_model DatabaseAutonomousContainerDatabase#patch_model}.</summary>
        [JsiiProperty(name: "patchModel", typeJson: "{\"primitive\":\"string\"}")]
        public string PatchModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#autonomous_container_database_backup_id DatabaseAutonomousContainerDatabase#autonomous_container_database_backup_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autonomousContainerDatabaseBackupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutonomousContainerDatabaseBackupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#autonomous_exadata_infrastructure_id DatabaseAutonomousContainerDatabase#autonomous_exadata_infrastructure_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autonomousExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutonomousExadataInfrastructureId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#autonomous_vm_cluster_id DatabaseAutonomousContainerDatabase#autonomous_vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutonomousVmClusterId
        {
            get;
            set;
        }

        /// <summary>backup_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#backup_config DatabaseAutonomousContainerDatabase#backup_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupConfig", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseBackupConfig\"}", isOptional: true)]
        public oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseBackupConfig? BackupConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#cloud_autonomous_vm_cluster_id DatabaseAutonomousContainerDatabase#cloud_autonomous_vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudAutonomousVmClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#compartment_id DatabaseAutonomousContainerDatabase#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        private object? _customerContacts;

        /// <summary>customer_contacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#customer_contacts DatabaseAutonomousContainerDatabase#customer_contacts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerContacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseCustomerContacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomerContacts
        {
            get => _customerContacts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseCustomerContacts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseCustomerContacts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customerContacts = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#database_software_image_id DatabaseAutonomousContainerDatabase#database_software_image_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseSoftwareImageId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#db_name DatabaseAutonomousContainerDatabase#db_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#db_split_threshold DatabaseAutonomousContainerDatabase#db_split_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbSplitThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DbSplitThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#db_unique_name DatabaseAutonomousContainerDatabase#db_unique_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbUniqueName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#db_version DatabaseAutonomousContainerDatabase#db_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#defined_tags DatabaseAutonomousContainerDatabase#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#distribution_affinity DatabaseAutonomousContainerDatabase#distribution_affinity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "distributionAffinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DistributionAffinity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#failover_trigger DatabaseAutonomousContainerDatabase#failover_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failoverTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailoverTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#fast_start_fail_over_lag_limit_in_seconds DatabaseAutonomousContainerDatabase#fast_start_fail_over_lag_limit_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fastStartFailOverLagLimitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FastStartFailOverLagLimitInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#freeform_tags DatabaseAutonomousContainerDatabase#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#id DatabaseAutonomousContainerDatabase#id}.</summary>
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

        private object? _isAutomaticFailoverEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#is_automatic_failover_enabled DatabaseAutonomousContainerDatabase#is_automatic_failover_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isAutomaticFailoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAutomaticFailoverEnabled
        {
            get => _isAutomaticFailoverEnabled;
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
                _isAutomaticFailoverEnabled = value;
            }
        }

        private object? _isDstFileUpdateEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#is_dst_file_update_enabled DatabaseAutonomousContainerDatabase#is_dst_file_update_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isDstFileUpdateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDstFileUpdateEnabled
        {
            get => _isDstFileUpdateEnabled;
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
                _isDstFileUpdateEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#key_store_id DatabaseAutonomousContainerDatabase#key_store_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyStoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyStoreId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#key_version_id DatabaseAutonomousContainerDatabase#key_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVersionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#kms_key_id DatabaseAutonomousContainerDatabase#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>maintenance_window_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#maintenance_window_details DatabaseAutonomousContainerDatabase#maintenance_window_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowDetails", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseMaintenanceWindowDetails\"}", isOptional: true)]
        public oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseMaintenanceWindowDetails? MaintenanceWindowDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#net_services_architecture DatabaseAutonomousContainerDatabase#net_services_architecture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netServicesArchitecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetServicesArchitecture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#okv_end_point_group_name DatabaseAutonomousContainerDatabase#okv_end_point_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "okvEndPointGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OkvEndPointGroupName
        {
            get;
            set;
        }

        /// <summary>peer_autonomous_container_database_backup_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#peer_autonomous_container_database_backup_config DatabaseAutonomousContainerDatabase#peer_autonomous_container_database_backup_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "peerAutonomousContainerDatabaseBackupConfig", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfig\"}", isOptional: true)]
        public oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfig? PeerAutonomousContainerDatabaseBackupConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#peer_autonomous_container_database_compartment_id DatabaseAutonomousContainerDatabase#peer_autonomous_container_database_compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerAutonomousContainerDatabaseCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerAutonomousContainerDatabaseCompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#peer_autonomous_container_database_display_name DatabaseAutonomousContainerDatabase#peer_autonomous_container_database_display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerAutonomousContainerDatabaseDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerAutonomousContainerDatabaseDisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#peer_autonomous_exadata_infrastructure_id DatabaseAutonomousContainerDatabase#peer_autonomous_exadata_infrastructure_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerAutonomousExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerAutonomousExadataInfrastructureId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#peer_autonomous_vm_cluster_id DatabaseAutonomousContainerDatabase#peer_autonomous_vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerAutonomousVmClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#peer_cloud_autonomous_vm_cluster_id DatabaseAutonomousContainerDatabase#peer_cloud_autonomous_vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerCloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerCloudAutonomousVmClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#peer_db_unique_name DatabaseAutonomousContainerDatabase#peer_db_unique_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerDbUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerDbUniqueName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#protection_mode DatabaseAutonomousContainerDatabase#protection_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProtectionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#reinstate_trigger DatabaseAutonomousContainerDatabase#reinstate_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reinstateTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReinstateTrigger
        {
            get;
            set;
        }

        private object? _rotateKeyTrigger;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#rotate_key_trigger DatabaseAutonomousContainerDatabase#rotate_key_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rotateKeyTrigger", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RotateKeyTrigger
        {
            get => _rotateKeyTrigger;
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
                _rotateKeyTrigger = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#service_level_agreement_type DatabaseAutonomousContainerDatabase#service_level_agreement_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceLevelAgreementType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceLevelAgreementType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#source DatabaseAutonomousContainerDatabase#source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#standby_maintenance_buffer_in_days DatabaseAutonomousContainerDatabase#standby_maintenance_buffer_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "standbyMaintenanceBufferInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StandbyMaintenanceBufferInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#switchover_trigger DatabaseAutonomousContainerDatabase#switchover_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "switchoverTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SwitchoverTrigger
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#timeouts DatabaseAutonomousContainerDatabase#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseTimeouts\"}", isOptional: true)]
        public oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#vault_id DatabaseAutonomousContainerDatabase#vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#version_preference DatabaseAutonomousContainerDatabase#version_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versionPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionPreference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#vm_failover_reservation DatabaseAutonomousContainerDatabase#vm_failover_reservation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmFailoverReservation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VmFailoverReservation
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
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
