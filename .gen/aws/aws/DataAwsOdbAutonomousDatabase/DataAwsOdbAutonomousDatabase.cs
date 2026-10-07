using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsOdbAutonomousDatabase
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/data-sources/odb_autonomous_database aws_odb_autonomous_database}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabase), fullyQualifiedName: "aws.dataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabase", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseConfig\"}}]")]
    public class DataAwsOdbAutonomousDatabase : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/data-sources/odb_autonomous_database aws_odb_autonomous_database} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsOdbAutonomousDatabase(Constructs.Construct scope, string id, aws.DataAwsOdbAutonomousDatabase.IDataAwsOdbAutonomousDatabaseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsOdbAutonomousDatabase.IDataAwsOdbAutonomousDatabaseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOdbAutonomousDatabase(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOdbAutonomousDatabase(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsOdbAutonomousDatabase resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsOdbAutonomousDatabase to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsOdbAutonomousDatabase that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsOdbAutonomousDatabase to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsOdbAutonomousDatabase to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/data-sources/odb_autonomous_database#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsOdbAutonomousDatabase that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsOdbAutonomousDatabase to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabase), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabase))!;

        [JsiiProperty(name: "actualUsedDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActualUsedDataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "adminPasswordSource", typeJson: "{\"fqn\":\"aws.dataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseAdminPasswordSourceList\"}")]
        public virtual aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseAdminPasswordSourceList AdminPasswordSource
        {
            get => GetInstanceProperty<aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseAdminPasswordSourceList>()!;
        }

        [JsiiProperty(name: "allocatedStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllocatedStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "allowlistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowlistedIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
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

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZoneId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerContactsToSendToOci", typeJson: "{\"fqn\":\"aws.dataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseCustomerContactsToSendToOciList\"}")]
        public virtual aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseCustomerContactsToSendToOciList CustomerContactsToSendToOci
        {
            get => GetInstanceProperty<aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseCustomerContactsToSendToOciList>()!;
        }

        [JsiiProperty(name: "databaseEdition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseEdition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGbs
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

        [JsiiProperty(name: "dbToolsDetails", typeJson: "{\"fqn\":\"aws.dataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseDbToolsDetailsList\"}")]
        public virtual aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseDbToolsDetailsList DbToolsDetails
        {
            get => GetInstanceProperty<aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseDbToolsDetailsList>()!;
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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionKeyProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionKeyProvider
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "isRefreshableClone", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRefreshableClone
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localAdgAutoFailoverMaxDataLossLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LocalAdgAutoFailoverMaxDataLossLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "longTermBackupSchedule", typeJson: "{\"fqn\":\"aws.dataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseLongTermBackupScheduleList\"}")]
        public virtual aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseLongTermBackupScheduleList LongTermBackupSchedule
        {
            get => GetInstanceProperty<aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseLongTermBackupScheduleList>()!;
        }

        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NcharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociResourceAnchorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciResourceAnchorName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "odbNetworkArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OdbNetworkArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "odbNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OdbNetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "openMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpenMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "percentProgress", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PercentProgress
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "refreshableMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshableMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourcePoolLeaderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourcePoolLeaderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourcePoolSummary", typeJson: "{\"fqn\":\"aws.dataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseResourcePoolSummaryList\"}")]
        public virtual aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseResourcePoolSummaryList ResourcePoolSummary
        {
            get => GetInstanceProperty<aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseResourcePoolSummaryList>()!;
        }

        [JsiiProperty(name: "scheduledOperations", typeJson: "{\"fqn\":\"aws.dataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseScheduledOperationsList\"}")]
        public virtual aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseScheduledOperationsList ScheduledOperations
        {
            get => GetInstanceProperty<aws.DataAwsOdbAutonomousDatabase.DataAwsOdbAutonomousDatabaseScheduledOperationsList>()!;
        }

        [JsiiProperty(name: "serviceConsoleUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceConsoleUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlWebDeveloperUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlWebDeveloperUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "standbyAllowlistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] StandbyAllowlistedIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "standbyAllowlistedIpsSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StandbyAllowlistedIpsSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeOfAutoRefreshStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfAutoRefreshStart
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
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
