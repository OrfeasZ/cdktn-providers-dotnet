using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembers")]
    public class DisasterRecoveryDrProtectionGroupMembers : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#member_id DisasterRecoveryDrProtectionGroup#member_id}.</summary>
        [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
        public string MemberId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#member_type DisasterRecoveryDrProtectionGroup#member_type}.</summary>
        [JsiiProperty(name: "memberType", typeJson: "{\"primitive\":\"string\"}")]
        public string MemberType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#autonomous_database_standby_type_for_dr_drills DisasterRecoveryDrProtectionGroup#autonomous_database_standby_type_for_dr_drills}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autonomousDatabaseStandbyTypeForDrDrills", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutonomousDatabaseStandbyTypeForDrDrills
        {
            get;
            set;
        }

        private object? _backendSetMappings;

        /// <summary>backend_set_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#backend_set_mappings DisasterRecoveryDrProtectionGroup#backend_set_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backendSetMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackendSetMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BackendSetMappings
        {
            get => _backendSetMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackendSetMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackendSetMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backendSetMappings = value;
            }
        }

        /// <summary>backup_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#backup_config DisasterRecoveryDrProtectionGroup#backup_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupConfig", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackupConfig\"}", isOptional: true)]
        public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackupConfig? BackupConfig
        {
            get;
            set;
        }

        /// <summary>backup_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#backup_location DisasterRecoveryDrProtectionGroup#backup_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupLocation", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackupLocation\"}", isOptional: true)]
        public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackupLocation? BackupLocation
        {
            get;
            set;
        }

        /// <summary>block_volume_attach_and_mount_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#block_volume_attach_and_mount_operations DisasterRecoveryDrProtectionGroup#block_volume_attach_and_mount_operations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockVolumeAttachAndMountOperations", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperations\"}", isOptional: true)]
        public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperations? BlockVolumeAttachAndMountOperations
        {
            get;
            set;
        }

        private object? _blockVolumeOperations;

        /// <summary>block_volume_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#block_volume_operations DisasterRecoveryDrProtectionGroup#block_volume_operations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockVolumeOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BlockVolumeOperations
        {
            get => _blockVolumeOperations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _blockVolumeOperations = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#bucket DisasterRecoveryDrProtectionGroup#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>common_destination_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#common_destination_key DisasterRecoveryDrProtectionGroup#common_destination_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "commonDestinationKey", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersCommonDestinationKey\"}", isOptional: true)]
        public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersCommonDestinationKey? CommonDestinationKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#connection_string_type DisasterRecoveryDrProtectionGroup#connection_string_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionStringType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionStringType
        {
            get;
            set;
        }

        /// <summary>db_system_admin_user_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#db_system_admin_user_details DisasterRecoveryDrProtectionGroup#db_system_admin_user_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbSystemAdminUserDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDbSystemAdminUserDetails\"}", isOptional: true)]
        public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDbSystemAdminUserDetails? DbSystemAdminUserDetails
        {
            get;
            set;
        }

        /// <summary>db_system_replication_user_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#db_system_replication_user_details DisasterRecoveryDrProtectionGroup#db_system_replication_user_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbSystemReplicationUserDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDbSystemReplicationUserDetails\"}", isOptional: true)]
        public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDbSystemReplicationUserDetails? DbSystemReplicationUserDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_availability_domain DisasterRecoveryDrProtectionGroup#destination_availability_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationAvailabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationAvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_backup_policy_id DisasterRecoveryDrProtectionGroup#destination_backup_policy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationBackupPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationBackupPolicyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_capacity_reservation_id DisasterRecoveryDrProtectionGroup#destination_capacity_reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationCapacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationCapacityReservationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_compartment_id DisasterRecoveryDrProtectionGroup#destination_compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationCompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_dedicated_vm_host_id DisasterRecoveryDrProtectionGroup#destination_dedicated_vm_host_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationDedicatedVmHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationDedicatedVmHostId
        {
            get;
            set;
        }

        /// <summary>destination_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_encryption_key DisasterRecoveryDrProtectionGroup#destination_encryption_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationEncryptionKey", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDestinationEncryptionKey\"}", isOptional: true)]
        public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDestinationEncryptionKey? DestinationEncryptionKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_load_balancer_id DisasterRecoveryDrProtectionGroup#destination_load_balancer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationLoadBalancerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_network_load_balancer_id DisasterRecoveryDrProtectionGroup#destination_network_load_balancer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationNetworkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationNetworkLoadBalancerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_snapshot_policy_id DisasterRecoveryDrProtectionGroup#destination_snapshot_policy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationSnapshotPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationSnapshotPolicyId
        {
            get;
            set;
        }

        private object? _exportMappings;

        /// <summary>export_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#export_mappings DisasterRecoveryDrProtectionGroup#export_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exportMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersExportMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExportMappings
        {
            get => _exportMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersExportMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersExportMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exportMappings = value;
            }
        }

        private object? _fileSystemOperations;

        /// <summary>file_system_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#file_system_operations DisasterRecoveryDrProtectionGroup#file_system_operations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FileSystemOperations
        {
            get => _fileSystemOperations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fileSystemOperations = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#gtid_reconciliation_timeout DisasterRecoveryDrProtectionGroup#gtid_reconciliation_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gtidReconciliationTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GtidReconciliationTimeout
        {
            get;
            set;
        }

        private object? _isContinueOnGtidReconciliationTimeout;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_continue_on_gtid_reconciliation_timeout DisasterRecoveryDrProtectionGroup#is_continue_on_gtid_reconciliation_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isContinueOnGtidReconciliationTimeout", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsContinueOnGtidReconciliationTimeout
        {
            get => _isContinueOnGtidReconciliationTimeout;
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
                _isContinueOnGtidReconciliationTimeout = value;
            }
        }

        private object? _isMovable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_movable DisasterRecoveryDrProtectionGroup#is_movable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isMovable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsMovable
        {
            get => _isMovable;
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
                _isMovable = value;
            }
        }

        private object? _isRetainFaultDomain;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_retain_fault_domain DisasterRecoveryDrProtectionGroup#is_retain_fault_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isRetainFaultDomain", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsRetainFaultDomain
        {
            get => _isRetainFaultDomain;
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
                _isRetainFaultDomain = value;
            }
        }

        private object? _isStartStopEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_start_stop_enabled DisasterRecoveryDrProtectionGroup#is_start_stop_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isStartStopEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsStartStopEnabled
        {
            get => _isStartStopEnabled;
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
                _isStartStopEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#jump_host_id DisasterRecoveryDrProtectionGroup#jump_host_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jumpHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JumpHostId
        {
            get;
            set;
        }

        private object? _loadBalancerMappings;

        /// <summary>load_balancer_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#load_balancer_mappings DisasterRecoveryDrProtectionGroup#load_balancer_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersLoadBalancerMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LoadBalancerMappings
        {
            get => _loadBalancerMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersLoadBalancerMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersLoadBalancerMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _loadBalancerMappings = value;
            }
        }

        private object? _managedNodePoolConfigs;

        /// <summary>managed_node_pool_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#managed_node_pool_configs DisasterRecoveryDrProtectionGroup#managed_node_pool_configs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedNodePoolConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersManagedNodePoolConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ManagedNodePoolConfigs
        {
            get => _managedNodePoolConfigs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersManagedNodePoolConfigs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersManagedNodePoolConfigs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _managedNodePoolConfigs = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#namespace DisasterRecoveryDrProtectionGroup#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        private object? _networkLoadBalancerMappings;

        /// <summary>network_load_balancer_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#network_load_balancer_mappings DisasterRecoveryDrProtectionGroup#network_load_balancer_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkLoadBalancerMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkLoadBalancerMappings
        {
            get => _networkLoadBalancerMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkLoadBalancerMappings = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#password_vault_secret_id DisasterRecoveryDrProtectionGroup#password_vault_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PasswordVaultSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#peer_cluster_id DisasterRecoveryDrProtectionGroup#peer_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#peer_db_system_id DisasterRecoveryDrProtectionGroup#peer_db_system_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerDbSystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerDbSystemId
        {
            get;
            set;
        }

        private object? _sourceVolumeToDestinationEncryptionKeyMappings;

        /// <summary>source_volume_to_destination_encryption_key_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_volume_to_destination_encryption_key_mappings DisasterRecoveryDrProtectionGroup#source_volume_to_destination_encryption_key_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceVolumeToDestinationEncryptionKeyMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SourceVolumeToDestinationEncryptionKeyMappings
        {
            get => _sourceVolumeToDestinationEncryptionKeyMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sourceVolumeToDestinationEncryptionKeyMappings = value;
            }
        }

        private object? _vaultMappings;

        /// <summary>vault_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#vault_mappings DisasterRecoveryDrProtectionGroup#vault_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vaultMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVaultMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VaultMappings
        {
            get => _vaultMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersVaultMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersVaultMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vaultMappings = value;
            }
        }

        private object? _virtualNodePoolConfigs;

        /// <summary>virtual_node_pool_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#virtual_node_pool_configs DisasterRecoveryDrProtectionGroup#virtual_node_pool_configs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNodePoolConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVirtualNodePoolConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualNodePoolConfigs
        {
            get => _virtualNodePoolConfigs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersVirtualNodePoolConfigs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersVirtualNodePoolConfigs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualNodePoolConfigs = value;
            }
        }

        private object? _vnicMapping;

        /// <summary>vnic_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#vnic_mapping DisasterRecoveryDrProtectionGroup#vnic_mapping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vnicMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVnicMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VnicMapping
        {
            get => _vnicMapping;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersVnicMapping[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersVnicMapping).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vnicMapping = value;
            }
        }

        private object? _vnicMappings;

        /// <summary>vnic_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#vnic_mappings DisasterRecoveryDrProtectionGroup#vnic_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vnicMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVnicMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VnicMappings
        {
            get => _vnicMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersVnicMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersVnicMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vnicMappings = value;
            }
        }
    }
}
