using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousContainerDatabase
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_autonomous_container_database oci_database_autonomous_container_database}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabase), fullyQualifiedName: "oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabase", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseConfig\"}}]")]
    public class DataOciDatabaseAutonomousContainerDatabase : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_autonomous_container_database oci_database_autonomous_container_database} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseAutonomousContainerDatabase(Constructs.Construct scope, string id, oci.DataOciDatabaseAutonomousContainerDatabase.IDataOciDatabaseAutonomousContainerDatabaseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseAutonomousContainerDatabase.IDataOciDatabaseAutonomousContainerDatabaseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousContainerDatabase(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousContainerDatabase(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseAutonomousContainerDatabase resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseAutonomousContainerDatabase to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseAutonomousContainerDatabase that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseAutonomousContainerDatabase to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseAutonomousContainerDatabase to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_autonomous_container_database#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseAutonomousContainerDatabase that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseAutonomousContainerDatabase to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabase), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabase))!;

        [JsiiProperty(name: "associatedBackupConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseAssociatedBackupConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseAssociatedBackupConfigurationDetailsList AssociatedBackupConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseAssociatedBackupConfigurationDetailsList>()!;
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

        [JsiiProperty(name: "backupConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseBackupConfigList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseBackupConfigList BackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseBackupConfigList>()!;
        }

        [JsiiProperty(name: "backupDestinationPropertiesList", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseBackupDestinationPropertiesListStructList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseBackupDestinationPropertiesListStructList BackupDestinationPropertiesList
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseBackupDestinationPropertiesListStructList>()!;
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

        [JsiiProperty(name: "customerContacts", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseCustomerContactsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseCustomerContactsList CustomerContacts
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseCustomerContactsList>()!;
        }

        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSoftwareImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataguard", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseDataguardList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseDataguardList Dataguard
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseDataguardList>()!;
        }

        [JsiiProperty(name: "dataguardGroupMembers", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseDataguardGroupMembersList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseDataguardGroupMembersList DataguardGroupMembers
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseDataguardGroupMembersList>()!;
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

        [JsiiProperty(name: "keyHistoryEntry", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseKeyHistoryEntryList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseKeyHistoryEntryList KeyHistoryEntry
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseKeyHistoryEntryList>()!;
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

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseMaintenanceWindowList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "maintenanceWindowDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseMaintenanceWindowDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseMaintenanceWindowDetailsList MaintenanceWindowDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseMaintenanceWindowDetailsList>()!;
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

        [JsiiProperty(name: "peerAutonomousContainerDatabaseBackupConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfigList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfigList PeerAutonomousContainerDatabaseBackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfigList>()!;
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

        [JsiiProperty(name: "recoveryApplianceDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseRecoveryApplianceDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseRecoveryApplianceDetailsList RecoveryApplianceDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabase.DataOciDatabaseAutonomousContainerDatabaseRecoveryApplianceDetailsList>()!;
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
        [JsiiProperty(name: "autonomousContainerDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutonomousContainerDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autonomousContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
