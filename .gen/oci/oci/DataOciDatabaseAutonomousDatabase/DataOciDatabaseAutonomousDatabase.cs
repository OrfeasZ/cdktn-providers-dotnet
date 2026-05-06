using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousDatabase
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_autonomous_database oci_database_autonomous_database}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabase), fullyQualifiedName: "oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabase", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseConfig\"}}]")]
    public class DataOciDatabaseAutonomousDatabase : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_autonomous_database oci_database_autonomous_database} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseAutonomousDatabase(Constructs.Construct scope, string id, oci.DataOciDatabaseAutonomousDatabase.IDataOciDatabaseAutonomousDatabaseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseAutonomousDatabase.IDataOciDatabaseAutonomousDatabaseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousDatabase(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousDatabase(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseAutonomousDatabase resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseAutonomousDatabase to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseAutonomousDatabase that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseAutonomousDatabase to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseAutonomousDatabase to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_autonomous_database#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseAutonomousDatabase that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseAutonomousDatabase to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabase), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabase))!;

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

        [JsiiProperty(name: "apexDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseApexDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseApexDetailsList ApexDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseApexDetailsList>()!;
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

        [JsiiProperty(name: "backupConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseBackupConfigList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseBackupConfigList BackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseBackupConfigList>()!;
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

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseConnectionStringsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseConnectionStringsList ConnectionStrings
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseConnectionStringsList>()!;
        }

        [JsiiProperty(name: "connectionUrls", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseConnectionUrlsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseConnectionUrlsList ConnectionUrls
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseConnectionUrlsList>()!;
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "customerContacts", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseCustomerContactsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseCustomerContactsList CustomerContacts
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseCustomerContactsList>()!;
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

        [JsiiProperty(name: "dbToolsDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseDbToolsDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseDbToolsDetailsList DbToolsDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseDbToolsDetailsList>()!;
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

        [JsiiProperty(name: "encryptionKey", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseEncryptionKeyList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseEncryptionKeyList EncryptionKey
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseEncryptionKeyList>()!;
        }

        [JsiiProperty(name: "encryptionKeyHistoryEntry", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseEncryptionKeyHistoryEntryList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseEncryptionKeyHistoryEntryList EncryptionKeyHistoryEntry
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseEncryptionKeyHistoryEntryList>()!;
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

        [JsiiProperty(name: "keyHistoryEntry", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseKeyHistoryEntryList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseKeyHistoryEntryList KeyHistoryEntry
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseKeyHistoryEntryList>()!;
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

        [JsiiProperty(name: "localStandbyDb", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseLocalStandbyDbList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseLocalStandbyDbList LocalStandbyDb
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseLocalStandbyDbList>()!;
        }

        [JsiiProperty(name: "longTermBackupSchedule", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseLongTermBackupScheduleList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseLongTermBackupScheduleList LongTermBackupSchedule
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseLongTermBackupScheduleList>()!;
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

        [JsiiProperty(name: "publicConnectionUrls", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabasePublicConnectionUrlsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabasePublicConnectionUrlsList PublicConnectionUrls
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabasePublicConnectionUrlsList>()!;
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

        [JsiiProperty(name: "remoteDisasterRecoveryConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseRemoteDisasterRecoveryConfigurationList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseRemoteDisasterRecoveryConfigurationList RemoteDisasterRecoveryConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseRemoteDisasterRecoveryConfigurationList>()!;
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

        [JsiiProperty(name: "resourcePoolSummary", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseResourcePoolSummaryList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseResourcePoolSummaryList ResourcePoolSummary
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseResourcePoolSummaryList>()!;
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

        [JsiiProperty(name: "scheduledOperations", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseScheduledOperationsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseScheduledOperationsList ScheduledOperations
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseScheduledOperationsList>()!;
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

        [JsiiProperty(name: "standbyDb", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseStandbyDbList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseStandbyDbList StandbyDb
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseStandbyDbList>()!;
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
        [JsiiProperty(name: "autonomousDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutonomousDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
