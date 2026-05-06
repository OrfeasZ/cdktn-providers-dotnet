using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesOutputReference), fullyQualifiedName: "oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseAutonomousDatabasesAutonomousDatabasesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseAutonomousDatabasesAutonomousDatabasesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseAutonomousDatabasesAutonomousDatabasesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousDatabasesAutonomousDatabasesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "actualUsedDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActualUsedDataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "additionalAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "allocatedStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllocatedStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "apexDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesApexDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesApexDetailsList ApexDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesApexDetailsList>()!;
        }

        [JsiiProperty(name: "arePrimaryWhitelistedIpsUsed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ArePrimaryWhitelistedIpsUsed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "autonomousContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousDatabaseBackupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousDatabaseBackupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousMaintenanceScheduleType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousMaintenanceScheduleType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoRefreshFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutoRefreshFrequencyInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "autoRefreshPointLagInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutoRefreshPointLagInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availableUpgradeVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailableUpgradeVersions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "backupConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesBackupConfigList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesBackupConfigList BackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesBackupConfigList>()!;
        }

        [JsiiProperty(name: "backupRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupRetentionPeriodInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "byolComputeCountLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ByolComputeCountLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloneTableSpaceList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] CloneTableSpaceList
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "cloneType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloneType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesConnectionStringsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesConnectionStringsList ConnectionStrings
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesConnectionStringsList>()!;
        }

        [JsiiProperty(name: "connectionUrls", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesConnectionUrlsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesConnectionUrlsList ConnectionUrls
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesConnectionUrlsList>()!;
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "customerContacts", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesCustomerContactsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesCustomerContactsList CustomerContacts
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesCustomerContactsList>()!;
        }

        [JsiiProperty(name: "databaseEdition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseEdition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseManagementStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseManagementStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataguardRegionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataguardRegionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataSafeStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSafeStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbToolsDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesDbToolsDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesDbToolsDetailsList DbToolsDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesDbToolsDetailsList>()!;
        }

        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbWorkload
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "disasterRecoveryRegionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisasterRecoveryRegionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disasterRecoveryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisasterRecoveryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableDeleteScheduledOperations", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableDeleteScheduledOperations
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "encryptionKey", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesEncryptionKeyList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesEncryptionKeyList EncryptionKey
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesEncryptionKeyList>()!;
        }

        [JsiiProperty(name: "encryptionKeyHistoryEntry", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesEncryptionKeyHistoryEntryList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesEncryptionKeyHistoryEntryList EncryptionKeyHistoryEntry
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesEncryptionKeyHistoryEntryList>()!;
        }

        [JsiiProperty(name: "failedDataRecoveryInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailedDataRecoveryInSeconds
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

        [JsiiProperty(name: "inMemoryAreaInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InMemoryAreaInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "inMemoryPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InMemoryPercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isAccessControlEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAccessControlEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoScalingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isAutoScalingForStorageEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoScalingForStorageEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isBackupRetentionLocked", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBackupRetentionLocked
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDataGuardEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDataGuardEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDedicated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDedicated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDevTier", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDevTier
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDisableDbVersionUpgradeSchedule", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDisableDbVersionUpgradeSchedule
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDisconnectPeer", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDisconnectPeer
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isFreeTier", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFreeTier
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLocalDataGuardEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLocalDataGuardEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMtlsConnectionRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMtlsConnectionRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPreview", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPreview
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPreviewVersionWithServiceTermsAccepted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPreviewVersionWithServiceTermsAccepted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isReconnectCloneEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsReconnectCloneEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRefreshableClone", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRefreshableClone
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRemoteDataGuardEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRemoteDataGuardEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isReplicateAutomaticBackups", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsReplicateAutomaticBackups
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isScheduleDbVersionUpgradeToEarliest", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsScheduleDbVersionUpgradeToEarliest
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isShrinkOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsShrinkOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "keyHistoryEntry", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesKeyHistoryEntryList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesKeyHistoryEntryList KeyHistoryEntry
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesKeyHistoryEntryList>()!;
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

        [JsiiProperty(name: "kmsKeyLifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyLifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyVersionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localAdgAutoFailoverMaxDataLossLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LocalAdgAutoFailoverMaxDataLossLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "localDisasterRecoveryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalDisasterRecoveryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localStandbyDb", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesLocalStandbyDbList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesLocalStandbyDbList LocalStandbyDb
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesLocalStandbyDbList>()!;
        }

        [JsiiProperty(name: "longTermBackupSchedule", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesLongTermBackupScheduleList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesLongTermBackupScheduleList LongTermBackupSchedule
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesLongTermBackupScheduleList>()!;
        }

        [JsiiProperty(name: "maintenanceTargetComponent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceTargetComponent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxCpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NcharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "netServicesArchitecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetServicesArchitecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextLongTermBackupTimeStamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextLongTermBackupTimeStamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ocpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "openMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpenMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationsInsightsStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationsInsightsStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerDbId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerDbId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerDbIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PeerDbIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "permissionLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PermissionLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateEndpointIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpointIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateEndpointLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpointLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisionableCpus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] ProvisionableCpus
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "publicConnectionUrls", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesPublicConnectionUrlsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesPublicConnectionUrlsList PublicConnectionUrls
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesPublicConnectionUrlsList>()!;
        }

        [JsiiProperty(name: "publicEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshableMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshableMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshableStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshableStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remoteDisasterRecoveryConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesRemoteDisasterRecoveryConfigurationList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesRemoteDisasterRecoveryConfigurationList RemoteDisasterRecoveryConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesRemoteDisasterRecoveryConfigurationList>()!;
        }

        [JsiiProperty(name: "remoteDisasterRecoveryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteDisasterRecoveryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourcePoolLeaderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourcePoolLeaderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourcePoolSummary", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesResourcePoolSummaryList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesResourcePoolSummaryList ResourcePoolSummary
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesResourcePoolSummaryList>()!;
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

        [JsiiProperty(name: "scheduledOperations", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesScheduledOperationsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesScheduledOperationsList ScheduledOperations
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesScheduledOperationsList>()!;
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretVersionNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SecretVersionNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "serviceConsoleUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceConsoleUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shrinkAdbTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ShrinkAdbTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "standbyDb", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesStandbyDbList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesStandbyDbList StandbyDb
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabasesStandbyDbList>()!;
        }

        [JsiiProperty(name: "standbyWhitelistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] StandbyWhitelistedIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportedRegionsToCloneTo", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedRegionsToCloneTo
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "switchoverTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SwitchoverTo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "switchoverToRemotePeerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SwitchoverToRemotePeerId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeDataGuardRoleChanged", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeDataGuardRoleChanged
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeDeletionOfFreeAutonomousDatabase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeDeletionOfFreeAutonomousDatabase
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeDisasterRecoveryRoleChanged", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeDisasterRecoveryRoleChanged
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEarliestAvailableDbVersionUpgrade", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEarliestAvailableDbVersionUpgrade
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLatestAvailableDbVersionUpgrade", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLatestAvailableDbVersionUpgrade
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLocalDataGuardEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLocalDataGuardEnabled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMaintenanceBegin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaintenanceBegin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMaintenanceEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaintenanceEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfAutoRefreshStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfAutoRefreshStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfJoiningResourcePool", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfJoiningResourcePool
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfLastFailover", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastFailover
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfLastRefresh", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastRefresh
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfLastRefreshPoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastRefreshPoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfLastSwitchover", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastSwitchover
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfNextRefresh", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfNextRefresh
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeReclamationOfFreeAutonomousDatabase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeReclamationOfFreeAutonomousDatabase
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeScheduledDbVersionUpgrade", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeScheduledDbVersionUpgrade
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUndeleted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUndeleted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUntilReconnectCloneEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUntilReconnectCloneEnabled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalBackupStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalBackupStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "usedDataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UsedDataStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "usedDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UsedDataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "useLatestAvailableBackupTimeStamp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UseLatestAvailableBackupTimeStamp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "whitelistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WhitelistedIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabases.DataOciDatabaseAutonomousDatabasesAutonomousDatabases\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseAutonomousDatabases.IDataOciDatabaseAutonomousDatabasesAutonomousDatabases? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabases.IDataOciDatabaseAutonomousDatabasesAutonomousDatabases?>();
            set => SetInstanceProperty(value);
        }
    }
}
