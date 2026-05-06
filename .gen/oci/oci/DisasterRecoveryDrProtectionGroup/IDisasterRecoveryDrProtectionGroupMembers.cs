using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembers), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembers")]
    public interface IDisasterRecoveryDrProtectionGroupMembers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#member_id DisasterRecoveryDrProtectionGroup#member_id}.</summary>
        [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
        string MemberId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#member_type DisasterRecoveryDrProtectionGroup#member_type}.</summary>
        [JsiiProperty(name: "memberType", typeJson: "{\"primitive\":\"string\"}")]
        string MemberType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#autonomous_database_standby_type_for_dr_drills DisasterRecoveryDrProtectionGroup#autonomous_database_standby_type_for_dr_drills}.</summary>
        [JsiiProperty(name: "autonomousDatabaseStandbyTypeForDrDrills", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutonomousDatabaseStandbyTypeForDrDrills
        {
            get
            {
                return null;
            }
        }

        /// <summary>backend_set_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#backend_set_mappings DisasterRecoveryDrProtectionGroup#backend_set_mappings}
        /// </remarks>
        [JsiiProperty(name: "backendSetMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackendSetMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BackendSetMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>backup_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#backup_config DisasterRecoveryDrProtectionGroup#backup_config}
        /// </remarks>
        [JsiiProperty(name: "backupConfig", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackupConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackupConfig? BackupConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>backup_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#backup_location DisasterRecoveryDrProtectionGroup#backup_location}
        /// </remarks>
        [JsiiProperty(name: "backupLocation", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackupLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackupLocation? BackupLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>block_volume_attach_and_mount_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#block_volume_attach_and_mount_operations DisasterRecoveryDrProtectionGroup#block_volume_attach_and_mount_operations}
        /// </remarks>
        [JsiiProperty(name: "blockVolumeAttachAndMountOperations", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperations\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperations? BlockVolumeAttachAndMountOperations
        {
            get
            {
                return null;
            }
        }

        /// <summary>block_volume_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#block_volume_operations DisasterRecoveryDrProtectionGroup#block_volume_operations}
        /// </remarks>
        [JsiiProperty(name: "blockVolumeOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BlockVolumeOperations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#bucket DisasterRecoveryDrProtectionGroup#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>common_destination_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#common_destination_key DisasterRecoveryDrProtectionGroup#common_destination_key}
        /// </remarks>
        [JsiiProperty(name: "commonDestinationKey", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersCommonDestinationKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersCommonDestinationKey? CommonDestinationKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#connection_string_type DisasterRecoveryDrProtectionGroup#connection_string_type}.</summary>
        [JsiiProperty(name: "connectionStringType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionStringType
        {
            get
            {
                return null;
            }
        }

        /// <summary>db_system_admin_user_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#db_system_admin_user_details DisasterRecoveryDrProtectionGroup#db_system_admin_user_details}
        /// </remarks>
        [JsiiProperty(name: "dbSystemAdminUserDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDbSystemAdminUserDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDbSystemAdminUserDetails? DbSystemAdminUserDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>db_system_replication_user_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#db_system_replication_user_details DisasterRecoveryDrProtectionGroup#db_system_replication_user_details}
        /// </remarks>
        [JsiiProperty(name: "dbSystemReplicationUserDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDbSystemReplicationUserDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDbSystemReplicationUserDetails? DbSystemReplicationUserDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_availability_domain DisasterRecoveryDrProtectionGroup#destination_availability_domain}.</summary>
        [JsiiProperty(name: "destinationAvailabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationAvailabilityDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_backup_policy_id DisasterRecoveryDrProtectionGroup#destination_backup_policy_id}.</summary>
        [JsiiProperty(name: "destinationBackupPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationBackupPolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_capacity_reservation_id DisasterRecoveryDrProtectionGroup#destination_capacity_reservation_id}.</summary>
        [JsiiProperty(name: "destinationCapacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationCapacityReservationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_compartment_id DisasterRecoveryDrProtectionGroup#destination_compartment_id}.</summary>
        [JsiiProperty(name: "destinationCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationCompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_dedicated_vm_host_id DisasterRecoveryDrProtectionGroup#destination_dedicated_vm_host_id}.</summary>
        [JsiiProperty(name: "destinationDedicatedVmHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationDedicatedVmHostId
        {
            get
            {
                return null;
            }
        }

        /// <summary>destination_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_encryption_key DisasterRecoveryDrProtectionGroup#destination_encryption_key}
        /// </remarks>
        [JsiiProperty(name: "destinationEncryptionKey", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDestinationEncryptionKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDestinationEncryptionKey? DestinationEncryptionKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_load_balancer_id DisasterRecoveryDrProtectionGroup#destination_load_balancer_id}.</summary>
        [JsiiProperty(name: "destinationLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationLoadBalancerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_network_load_balancer_id DisasterRecoveryDrProtectionGroup#destination_network_load_balancer_id}.</summary>
        [JsiiProperty(name: "destinationNetworkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationNetworkLoadBalancerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_snapshot_policy_id DisasterRecoveryDrProtectionGroup#destination_snapshot_policy_id}.</summary>
        [JsiiProperty(name: "destinationSnapshotPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationSnapshotPolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>export_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#export_mappings DisasterRecoveryDrProtectionGroup#export_mappings}
        /// </remarks>
        [JsiiProperty(name: "exportMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersExportMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExportMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_system_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#file_system_operations DisasterRecoveryDrProtectionGroup#file_system_operations}
        /// </remarks>
        [JsiiProperty(name: "fileSystemOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FileSystemOperations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#gtid_reconciliation_timeout DisasterRecoveryDrProtectionGroup#gtid_reconciliation_timeout}.</summary>
        [JsiiProperty(name: "gtidReconciliationTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GtidReconciliationTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_continue_on_gtid_reconciliation_timeout DisasterRecoveryDrProtectionGroup#is_continue_on_gtid_reconciliation_timeout}.</summary>
        [JsiiProperty(name: "isContinueOnGtidReconciliationTimeout", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsContinueOnGtidReconciliationTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_movable DisasterRecoveryDrProtectionGroup#is_movable}.</summary>
        [JsiiProperty(name: "isMovable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMovable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_retain_fault_domain DisasterRecoveryDrProtectionGroup#is_retain_fault_domain}.</summary>
        [JsiiProperty(name: "isRetainFaultDomain", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRetainFaultDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_start_stop_enabled DisasterRecoveryDrProtectionGroup#is_start_stop_enabled}.</summary>
        [JsiiProperty(name: "isStartStopEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsStartStopEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#jump_host_id DisasterRecoveryDrProtectionGroup#jump_host_id}.</summary>
        [JsiiProperty(name: "jumpHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JumpHostId
        {
            get
            {
                return null;
            }
        }

        /// <summary>load_balancer_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#load_balancer_mappings DisasterRecoveryDrProtectionGroup#load_balancer_mappings}
        /// </remarks>
        [JsiiProperty(name: "loadBalancerMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersLoadBalancerMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LoadBalancerMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>managed_node_pool_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#managed_node_pool_configs DisasterRecoveryDrProtectionGroup#managed_node_pool_configs}
        /// </remarks>
        [JsiiProperty(name: "managedNodePoolConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersManagedNodePoolConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedNodePoolConfigs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#namespace DisasterRecoveryDrProtectionGroup#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_load_balancer_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#network_load_balancer_mappings DisasterRecoveryDrProtectionGroup#network_load_balancer_mappings}
        /// </remarks>
        [JsiiProperty(name: "networkLoadBalancerMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkLoadBalancerMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#password_vault_secret_id DisasterRecoveryDrProtectionGroup#password_vault_secret_id}.</summary>
        [JsiiProperty(name: "passwordVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordVaultSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#peer_cluster_id DisasterRecoveryDrProtectionGroup#peer_cluster_id}.</summary>
        [JsiiProperty(name: "peerClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerClusterId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#peer_db_system_id DisasterRecoveryDrProtectionGroup#peer_db_system_id}.</summary>
        [JsiiProperty(name: "peerDbSystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerDbSystemId
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_volume_to_destination_encryption_key_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_volume_to_destination_encryption_key_mappings DisasterRecoveryDrProtectionGroup#source_volume_to_destination_encryption_key_mappings}
        /// </remarks>
        [JsiiProperty(name: "sourceVolumeToDestinationEncryptionKeyMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceVolumeToDestinationEncryptionKeyMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>vault_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#vault_mappings DisasterRecoveryDrProtectionGroup#vault_mappings}
        /// </remarks>
        [JsiiProperty(name: "vaultMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVaultMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VaultMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_node_pool_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#virtual_node_pool_configs DisasterRecoveryDrProtectionGroup#virtual_node_pool_configs}
        /// </remarks>
        [JsiiProperty(name: "virtualNodePoolConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVirtualNodePoolConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VirtualNodePoolConfigs
        {
            get
            {
                return null;
            }
        }

        /// <summary>vnic_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#vnic_mapping DisasterRecoveryDrProtectionGroup#vnic_mapping}
        /// </remarks>
        [JsiiProperty(name: "vnicMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVnicMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VnicMapping
        {
            get
            {
                return null;
            }
        }

        /// <summary>vnic_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#vnic_mappings DisasterRecoveryDrProtectionGroup#vnic_mappings}
        /// </remarks>
        [JsiiProperty(name: "vnicMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVnicMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VnicMappings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembers), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembers")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#member_id DisasterRecoveryDrProtectionGroup#member_id}.</summary>
            [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
            public string MemberId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#member_type DisasterRecoveryDrProtectionGroup#member_type}.</summary>
            [JsiiProperty(name: "memberType", typeJson: "{\"primitive\":\"string\"}")]
            public string MemberType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#autonomous_database_standby_type_for_dr_drills DisasterRecoveryDrProtectionGroup#autonomous_database_standby_type_for_dr_drills}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autonomousDatabaseStandbyTypeForDrDrills", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutonomousDatabaseStandbyTypeForDrDrills
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>backend_set_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#backend_set_mappings DisasterRecoveryDrProtectionGroup#backend_set_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendSetMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackendSetMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BackendSetMappings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>backup_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#backup_config DisasterRecoveryDrProtectionGroup#backup_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupConfig", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackupConfig\"}", isOptional: true)]
            public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackupConfig? BackupConfig
            {
                get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackupConfig?>();
            }

            /// <summary>backup_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#backup_location DisasterRecoveryDrProtectionGroup#backup_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupLocation", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackupLocation\"}", isOptional: true)]
            public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackupLocation? BackupLocation
            {
                get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackupLocation?>();
            }

            /// <summary>block_volume_attach_and_mount_operations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#block_volume_attach_and_mount_operations DisasterRecoveryDrProtectionGroup#block_volume_attach_and_mount_operations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockVolumeAttachAndMountOperations", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperations\"}", isOptional: true)]
            public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperations? BlockVolumeAttachAndMountOperations
            {
                get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperations?>();
            }

            /// <summary>block_volume_operations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#block_volume_operations DisasterRecoveryDrProtectionGroup#block_volume_operations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockVolumeOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BlockVolumeOperations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#bucket DisasterRecoveryDrProtectionGroup#bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>common_destination_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#common_destination_key DisasterRecoveryDrProtectionGroup#common_destination_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "commonDestinationKey", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersCommonDestinationKey\"}", isOptional: true)]
            public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersCommonDestinationKey? CommonDestinationKey
            {
                get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersCommonDestinationKey?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#connection_string_type DisasterRecoveryDrProtectionGroup#connection_string_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionStringType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionStringType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>db_system_admin_user_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#db_system_admin_user_details DisasterRecoveryDrProtectionGroup#db_system_admin_user_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbSystemAdminUserDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDbSystemAdminUserDetails\"}", isOptional: true)]
            public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDbSystemAdminUserDetails? DbSystemAdminUserDetails
            {
                get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDbSystemAdminUserDetails?>();
            }

            /// <summary>db_system_replication_user_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#db_system_replication_user_details DisasterRecoveryDrProtectionGroup#db_system_replication_user_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbSystemReplicationUserDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDbSystemReplicationUserDetails\"}", isOptional: true)]
            public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDbSystemReplicationUserDetails? DbSystemReplicationUserDetails
            {
                get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDbSystemReplicationUserDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_availability_domain DisasterRecoveryDrProtectionGroup#destination_availability_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationAvailabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationAvailabilityDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_backup_policy_id DisasterRecoveryDrProtectionGroup#destination_backup_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationBackupPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationBackupPolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_capacity_reservation_id DisasterRecoveryDrProtectionGroup#destination_capacity_reservation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationCapacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationCapacityReservationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_compartment_id DisasterRecoveryDrProtectionGroup#destination_compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationCompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_dedicated_vm_host_id DisasterRecoveryDrProtectionGroup#destination_dedicated_vm_host_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationDedicatedVmHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationDedicatedVmHostId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>destination_encryption_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_encryption_key DisasterRecoveryDrProtectionGroup#destination_encryption_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationEncryptionKey", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDestinationEncryptionKey\"}", isOptional: true)]
            public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDestinationEncryptionKey? DestinationEncryptionKey
            {
                get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDestinationEncryptionKey?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_load_balancer_id DisasterRecoveryDrProtectionGroup#destination_load_balancer_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationLoadBalancerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_network_load_balancer_id DisasterRecoveryDrProtectionGroup#destination_network_load_balancer_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationNetworkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationNetworkLoadBalancerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_snapshot_policy_id DisasterRecoveryDrProtectionGroup#destination_snapshot_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationSnapshotPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationSnapshotPolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>export_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#export_mappings DisasterRecoveryDrProtectionGroup#export_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exportMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersExportMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExportMappings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>file_system_operations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#file_system_operations DisasterRecoveryDrProtectionGroup#file_system_operations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FileSystemOperations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#gtid_reconciliation_timeout DisasterRecoveryDrProtectionGroup#gtid_reconciliation_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gtidReconciliationTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GtidReconciliationTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_continue_on_gtid_reconciliation_timeout DisasterRecoveryDrProtectionGroup#is_continue_on_gtid_reconciliation_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isContinueOnGtidReconciliationTimeout", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsContinueOnGtidReconciliationTimeout
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_movable DisasterRecoveryDrProtectionGroup#is_movable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMovable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMovable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_retain_fault_domain DisasterRecoveryDrProtectionGroup#is_retain_fault_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isRetainFaultDomain", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRetainFaultDomain
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_start_stop_enabled DisasterRecoveryDrProtectionGroup#is_start_stop_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isStartStopEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsStartStopEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#jump_host_id DisasterRecoveryDrProtectionGroup#jump_host_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jumpHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JumpHostId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>load_balancer_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#load_balancer_mappings DisasterRecoveryDrProtectionGroup#load_balancer_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersLoadBalancerMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LoadBalancerMappings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>managed_node_pool_configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#managed_node_pool_configs DisasterRecoveryDrProtectionGroup#managed_node_pool_configs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedNodePoolConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersManagedNodePoolConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ManagedNodePoolConfigs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#namespace DisasterRecoveryDrProtectionGroup#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_load_balancer_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#network_load_balancer_mappings DisasterRecoveryDrProtectionGroup#network_load_balancer_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkLoadBalancerMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkLoadBalancerMappings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#password_vault_secret_id DisasterRecoveryDrProtectionGroup#password_vault_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordVaultSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#peer_cluster_id DisasterRecoveryDrProtectionGroup#peer_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerClusterId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#peer_db_system_id DisasterRecoveryDrProtectionGroup#peer_db_system_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerDbSystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerDbSystemId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>source_volume_to_destination_encryption_key_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_volume_to_destination_encryption_key_mappings DisasterRecoveryDrProtectionGroup#source_volume_to_destination_encryption_key_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceVolumeToDestinationEncryptionKeyMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceVolumeToDestinationEncryptionKeyMappings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>vault_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#vault_mappings DisasterRecoveryDrProtectionGroup#vault_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vaultMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVaultMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VaultMappings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>virtual_node_pool_configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#virtual_node_pool_configs DisasterRecoveryDrProtectionGroup#virtual_node_pool_configs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNodePoolConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVirtualNodePoolConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VirtualNodePoolConfigs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>vnic_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#vnic_mapping DisasterRecoveryDrProtectionGroup#vnic_mapping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vnicMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVnicMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VnicMapping
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>vnic_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#vnic_mappings DisasterRecoveryDrProtectionGroup#vnic_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vnicMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVnicMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VnicMappings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
