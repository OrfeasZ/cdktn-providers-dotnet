using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousContainerDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesOutputReference), fullyQualifiedName: "oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associatedBackupConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesAssociatedBackupConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesAssociatedBackupConfigurationDetailsList AssociatedBackupConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesAssociatedBackupConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "autonomousContainerDatabaseBackupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousContainerDatabaseBackupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousVmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availableCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "backupConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesBackupConfigList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesBackupConfigList BackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesBackupConfigList>()!;
        }

        [JsiiProperty(name: "backupDestinationPropertiesList", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesBackupDestinationPropertiesListStructList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesBackupDestinationPropertiesListStructList BackupDestinationPropertiesList
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesBackupDestinationPropertiesListStructList>()!;
        }

        [JsiiProperty(name: "cloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudAutonomousVmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerContacts", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesCustomerContactsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesCustomerContactsList CustomerContacts
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesCustomerContactsList>()!;
        }

        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSoftwareImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataguard", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesDataguardList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesDataguardList Dataguard
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesDataguardList>()!;
        }

        [JsiiProperty(name: "dataguardGroupMembers", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesDataguardGroupMembersList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesDataguardGroupMembersList DataguardGroupMembers
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesDataguardGroupMembersList>()!;
        }

        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbSplitThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DbSplitThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbUniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbUniqueName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "distributionAffinity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistributionAffinity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dstFileVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DstFileVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failoverTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailoverTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fastStartFailOverLagLimitInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FastStartFailOverLagLimitInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infrastructureType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutomaticFailoverEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutomaticFailoverEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDataGuardEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDataGuardEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDstFileUpdateEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDstFileUpdateEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMultipleStandby", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMultipleStandby
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "keyHistoryEntry", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesKeyHistoryEntryList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesKeyHistoryEntryList KeyHistoryEntry
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesKeyHistoryEntryList>()!;
        }

        [JsiiProperty(name: "keyStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyStoreWalletName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStoreWalletName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyVersionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVersionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyVersionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "largestProvisionableAutonomousDatabaseInCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LargestProvisionableAutonomousDatabaseInCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lastMaintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastMaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listOneOffPatches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ListOneOffPatches
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesMaintenanceWindowList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "maintenanceWindowDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesMaintenanceWindowDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesMaintenanceWindowDetailsList MaintenanceWindowDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesMaintenanceWindowDetailsList>()!;
        }

        [JsiiProperty(name: "memoryPerComputeUnitInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryPerComputeUnitInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryPerOracleComputeUnitInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryPerOracleComputeUnitInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "netServicesArchitecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetServicesArchitecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextMaintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextMaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "okvEndPointGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OkvEndPointGroupName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerAutonomousContainerDatabaseBackupConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesPeerAutonomousContainerDatabaseBackupConfigList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesPeerAutonomousContainerDatabaseBackupConfigList PeerAutonomousContainerDatabaseBackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesPeerAutonomousContainerDatabaseBackupConfigList>()!;
        }

        [JsiiProperty(name: "peerAutonomousContainerDatabaseCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerAutonomousContainerDatabaseCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerAutonomousContainerDatabaseDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerAutonomousContainerDatabaseDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerAutonomousExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerAutonomousExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerAutonomousVmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerCloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerCloudAutonomousVmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerDbUniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerDbUniqueName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectionMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisionableCpus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] ProvisionableCpus
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "provisionedCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "reclaimableCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReclaimableCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "recoveryApplianceDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesRecoveryApplianceDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesRecoveryApplianceDetailsList RecoveryApplianceDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabasesRecoveryApplianceDetailsList>()!;
        }

        [JsiiProperty(name: "reinstateTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReinstateTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "reservedCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReservedCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rotateKeyTrigger", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RotateKeyTrigger
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "serviceLevelAgreementType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceLevelAgreementType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "standbyMaintenanceBufferInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StandbyMaintenanceBufferInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "switchoverTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SwitchoverTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfLastBackup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastBackup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeSnapshotStandbyRevert", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeSnapshotStandbyRevert
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionPreference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmFailoverReservation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VmFailoverReservation
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabases.DataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabases\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabases.IDataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabases? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabases.IDataOciDatabaseAutonomousContainerDatabasesAutonomousContainerDatabases?>();
            set => SetInstanceProperty(value);
        }
    }
}
