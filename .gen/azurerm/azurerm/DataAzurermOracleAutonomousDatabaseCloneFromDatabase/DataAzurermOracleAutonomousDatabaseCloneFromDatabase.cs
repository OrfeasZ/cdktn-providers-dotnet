using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/oracle_autonomous_database_clone_from_database azurerm_oracle_autonomous_database_clone_from_database}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabase), fullyQualifiedName: "azurerm.dataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabase", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabaseConfig\"}}]")]
    public class DataAzurermOracleAutonomousDatabaseCloneFromDatabase : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/oracle_autonomous_database_clone_from_database azurerm_oracle_autonomous_database_clone_from_database} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermOracleAutonomousDatabaseCloneFromDatabase(Constructs.Construct scope, string id, azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.IDataAzurermOracleAutonomousDatabaseCloneFromDatabaseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.IDataAzurermOracleAutonomousDatabaseCloneFromDatabaseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermOracleAutonomousDatabaseCloneFromDatabase(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermOracleAutonomousDatabaseCloneFromDatabase(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermOracleAutonomousDatabaseCloneFromDatabase resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermOracleAutonomousDatabaseCloneFromDatabase to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermOracleAutonomousDatabaseCloneFromDatabase that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermOracleAutonomousDatabaseCloneFromDatabase to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermOracleAutonomousDatabaseCloneFromDatabase to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/oracle_autonomous_database_clone_from_database#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermOracleAutonomousDatabaseCloneFromDatabase that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermOracleAutonomousDatabaseCloneFromDatabase to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabase), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabaseTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.IDataAzurermOracleAutonomousDatabaseCloneFromDatabaseTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.IDataAzurermOracleAutonomousDatabaseCloneFromDatabaseTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabase))!;

        [JsiiProperty(name: "actualUsedDataStorageSizeInTb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActualUsedDataStorageSizeInTb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "allocatedStorageSizeInTb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllocatedStorageSizeInTb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "allowedIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "autoScalingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AutoScalingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "autoScalingForStorageEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AutoScalingForStorageEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "availableUpgradeVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailableUpgradeVersions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "backupRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupRetentionPeriodInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CharacterSet
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

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ConnectionStrings
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "customerContacts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CustomerContacts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseWorkload", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseWorkload
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInTb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInTb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failedDataRecoveryInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailedDataRecoveryInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "inMemoryAreaInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InMemoryAreaInGb
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "lifecycleState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localAdgAutoFailoverMaxDataLossLimitInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LocalAdgAutoFailoverMaxDataLossLimitInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "localDataGuardEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable LocalDataGuardEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "longTermBackupSchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabaseLongTermBackupScheduleList\"}")]
        public virtual azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabaseLongTermBackupScheduleList LongTermBackupSchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabaseLongTermBackupScheduleList>()!;
        }

        [JsiiProperty(name: "memoryPerOracleComputeUnitInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryPerOracleComputeUnitInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mtlsConnectionRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable MtlsConnectionRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "nationalCharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NationalCharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextLongTermBackupTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextLongTermBackupTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerDatabaseIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PeerDatabaseIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "preview", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Preview
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "previewVersionWithServiceTermsAccepted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PreviewVersionWithServiceTermsAccepted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "privateEndpointUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpointUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisionableCpus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] ProvisionableCpus
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "reconnectCloneEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReconnectCloneEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "refreshableClone", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RefreshableClone
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "refreshableStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshableStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remoteDataGuardEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RemoteDataGuardEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "serviceConsoleUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceConsoleUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceAutonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceAutonomousDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlWebDeveloperUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlWebDeveloperUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportedRegionsToCloneTo", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedRegionsToCloneTo
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreatedInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreatedInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeDataGuardRoleChangedInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeDataGuardRoleChangedInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeDeletionOfFreeAutonomousDatabaseInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeDeletionOfFreeAutonomousDatabaseInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLocalDataGuardEnabledInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLocalDataGuardEnabledInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMaintenanceBeginInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaintenanceBeginInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMaintenanceEndInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaintenanceEndInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfLastFailoverInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastFailoverInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfLastRefreshInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastRefreshInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfLastRefreshPointInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastRefreshPointInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfLastSwitchoverInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastSwitchoverInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabaseTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabaseTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabaseTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeReclamationOfFreeAutonomousDatabaseInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeReclamationOfFreeAutonomousDatabaseInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUntilReconnectInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUntilReconnectInUtc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usedDataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UsedDataStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "usedDataStorageSizeInTb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UsedDataStorageSizeInTb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.IDataAzurermOracleAutonomousDatabaseCloneFromDatabaseTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabaseTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
