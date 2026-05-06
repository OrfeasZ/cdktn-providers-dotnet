using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDisasterRecoveryDrProtectionGroup
{
    [JsiiClass(nativeType: typeof(oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersOutputReference), fullyQualifiedName: "oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDisasterRecoveryDrProtectionGroupMembersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDisasterRecoveryDrProtectionGroupMembersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDisasterRecoveryDrProtectionGroupMembersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDisasterRecoveryDrProtectionGroupMembersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autonomousDatabaseStandbyTypeForDrDrills", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousDatabaseStandbyTypeForDrDrills
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backendSetMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBackendSetMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBackendSetMappingsList BackendSetMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBackendSetMappingsList>()!;
        }

        [JsiiProperty(name: "backupConfig", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBackupConfigList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBackupConfigList BackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBackupConfigList>()!;
        }

        [JsiiProperty(name: "backupLocation", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBackupLocationList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBackupLocationList BackupLocation
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBackupLocationList>()!;
        }

        [JsiiProperty(name: "blockVolumeAttachAndMountOperations", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsList BlockVolumeAttachAndMountOperations
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsList>()!;
        }

        [JsiiProperty(name: "blockVolumeOperations", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsList BlockVolumeOperations
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsList>()!;
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "commonDestinationKey", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersCommonDestinationKeyList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersCommonDestinationKeyList CommonDestinationKey
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersCommonDestinationKeyList>()!;
        }

        [JsiiProperty(name: "connectionStringType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionStringType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbSystemAdminUserDetails", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersDbSystemAdminUserDetailsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersDbSystemAdminUserDetailsList DbSystemAdminUserDetails
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersDbSystemAdminUserDetailsList>()!;
        }

        [JsiiProperty(name: "dbSystemReplicationUserDetails", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersDbSystemReplicationUserDetailsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersDbSystemReplicationUserDetailsList DbSystemReplicationUserDetails
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersDbSystemReplicationUserDetailsList>()!;
        }

        [JsiiProperty(name: "destinationAvailabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationAvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationBackupPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationBackupPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationCapacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationCapacityReservationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationDedicatedVmHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationDedicatedVmHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationEncryptionKey", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersDestinationEncryptionKeyList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersDestinationEncryptionKeyList DestinationEncryptionKey
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersDestinationEncryptionKeyList>()!;
        }

        [JsiiProperty(name: "destinationLoadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationLoadBalancerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationNetworkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationNetworkLoadBalancerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationSnapshotPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationSnapshotPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exportMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersExportMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersExportMappingsList ExportMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersExportMappingsList>()!;
        }

        [JsiiProperty(name: "fileSystemOperations", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsList FileSystemOperations
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsList>()!;
        }

        [JsiiProperty(name: "gtidReconciliationTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GtidReconciliationTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isContinueOnGtidReconciliationTimeout", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsContinueOnGtidReconciliationTimeout
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMovable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMovable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRetainFaultDomain", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRetainFaultDomain
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isStartStopEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsStartStopEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jumpHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JumpHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancerMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersLoadBalancerMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersLoadBalancerMappingsList LoadBalancerMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersLoadBalancerMappingsList>()!;
        }

        [JsiiProperty(name: "managedNodePoolConfigs", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersManagedNodePoolConfigsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersManagedNodePoolConfigsList ManagedNodePoolConfigs
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersManagedNodePoolConfigsList>()!;
        }

        [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemberId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memberType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemberType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkLoadBalancerMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappingsList NetworkLoadBalancerMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappingsList>()!;
        }

        [JsiiProperty(name: "passwordVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordVaultSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerDbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceVolumeToDestinationEncryptionKeyMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsList SourceVolumeToDestinationEncryptionKeyMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsList>()!;
        }

        [JsiiProperty(name: "vaultMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVaultMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVaultMappingsList VaultMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVaultMappingsList>()!;
        }

        [JsiiProperty(name: "virtualNodePoolConfigs", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVirtualNodePoolConfigsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVirtualNodePoolConfigsList VirtualNodePoolConfigs
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVirtualNodePoolConfigsList>()!;
        }

        [JsiiProperty(name: "vnicMapping", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVnicMappingList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVnicMappingList VnicMapping
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVnicMappingList>()!;
        }

        [JsiiProperty(name: "vnicMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVnicMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVnicMappingsList VnicMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembersVnicMappingsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroup.DataOciDisasterRecoveryDrProtectionGroupMembers\"}", isOptional: true)]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroup.IDataOciDisasterRecoveryDrProtectionGroupMembers? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroup.IDataOciDisasterRecoveryDrProtectionGroupMembers?>();
            set => SetInstanceProperty(value);
        }
    }
}
