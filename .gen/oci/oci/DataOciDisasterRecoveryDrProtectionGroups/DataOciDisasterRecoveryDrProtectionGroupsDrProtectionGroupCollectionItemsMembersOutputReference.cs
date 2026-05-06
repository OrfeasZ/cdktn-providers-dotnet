using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDisasterRecoveryDrProtectionGroups
{
    [JsiiClass(nativeType: typeof(oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersOutputReference), fullyQualifiedName: "oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autonomousDatabaseStandbyTypeForDrDrills", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousDatabaseStandbyTypeForDrDrills
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backendSetMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBackendSetMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBackendSetMappingsList BackendSetMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBackendSetMappingsList>()!;
        }

        [JsiiProperty(name: "backupConfig", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBackupConfigList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBackupConfigList BackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBackupConfigList>()!;
        }

        [JsiiProperty(name: "backupLocation", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBackupLocationList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBackupLocationList BackupLocation
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBackupLocationList>()!;
        }

        [JsiiProperty(name: "blockVolumeAttachAndMountOperations", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBlockVolumeAttachAndMountOperationsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBlockVolumeAttachAndMountOperationsList BlockVolumeAttachAndMountOperations
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBlockVolumeAttachAndMountOperationsList>()!;
        }

        [JsiiProperty(name: "blockVolumeOperations", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBlockVolumeOperationsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBlockVolumeOperationsList BlockVolumeOperations
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersBlockVolumeOperationsList>()!;
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "commonDestinationKey", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersCommonDestinationKeyList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersCommonDestinationKeyList CommonDestinationKey
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersCommonDestinationKeyList>()!;
        }

        [JsiiProperty(name: "connectionStringType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionStringType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbSystemAdminUserDetails", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersDbSystemAdminUserDetailsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersDbSystemAdminUserDetailsList DbSystemAdminUserDetails
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersDbSystemAdminUserDetailsList>()!;
        }

        [JsiiProperty(name: "dbSystemReplicationUserDetails", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersDbSystemReplicationUserDetailsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersDbSystemReplicationUserDetailsList DbSystemReplicationUserDetails
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersDbSystemReplicationUserDetailsList>()!;
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

        [JsiiProperty(name: "destinationEncryptionKey", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersDestinationEncryptionKeyList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersDestinationEncryptionKeyList DestinationEncryptionKey
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersDestinationEncryptionKeyList>()!;
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

        [JsiiProperty(name: "exportMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersExportMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersExportMappingsList ExportMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersExportMappingsList>()!;
        }

        [JsiiProperty(name: "fileSystemOperations", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersFileSystemOperationsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersFileSystemOperationsList FileSystemOperations
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersFileSystemOperationsList>()!;
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

        [JsiiProperty(name: "loadBalancerMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersLoadBalancerMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersLoadBalancerMappingsList LoadBalancerMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersLoadBalancerMappingsList>()!;
        }

        [JsiiProperty(name: "managedNodePoolConfigs", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersManagedNodePoolConfigsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersManagedNodePoolConfigsList ManagedNodePoolConfigs
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersManagedNodePoolConfigsList>()!;
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

        [JsiiProperty(name: "networkLoadBalancerMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersNetworkLoadBalancerMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersNetworkLoadBalancerMappingsList NetworkLoadBalancerMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersNetworkLoadBalancerMappingsList>()!;
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

        [JsiiProperty(name: "sourceVolumeToDestinationEncryptionKeyMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersSourceVolumeToDestinationEncryptionKeyMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersSourceVolumeToDestinationEncryptionKeyMappingsList SourceVolumeToDestinationEncryptionKeyMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersSourceVolumeToDestinationEncryptionKeyMappingsList>()!;
        }

        [JsiiProperty(name: "vaultMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVaultMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVaultMappingsList VaultMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVaultMappingsList>()!;
        }

        [JsiiProperty(name: "virtualNodePoolConfigs", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVirtualNodePoolConfigsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVirtualNodePoolConfigsList VirtualNodePoolConfigs
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVirtualNodePoolConfigsList>()!;
        }

        [JsiiProperty(name: "vnicMapping", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVnicMappingList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVnicMappingList VnicMapping
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVnicMappingList>()!;
        }

        [JsiiProperty(name: "vnicMappings", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVnicMappingsList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVnicMappingsList VnicMappings
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembersVnicMappingsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrProtectionGroups.DataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembers\"}", isOptional: true)]
        public virtual oci.DataOciDisasterRecoveryDrProtectionGroups.IDataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembers? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrProtectionGroups.IDataOciDisasterRecoveryDrProtectionGroupsDrProtectionGroupCollectionItemsMembers?>();
            set => SetInstanceProperty(value);
        }
    }
}
