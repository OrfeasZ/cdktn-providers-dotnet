using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabaseSnapshotStandby
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby oci_database_database_snapshot_standby}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandby), fullyQualifiedName: "oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandby", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyConfig\"}}]")]
    public class DatabaseDatabaseSnapshotStandby : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby oci_database_database_snapshot_standby} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseDatabaseSnapshotStandby(Constructs.Construct scope, string id, oci.DatabaseDatabaseSnapshotStandby.IDatabaseDatabaseSnapshotStandbyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseDatabaseSnapshotStandby.IDatabaseDatabaseSnapshotStandbyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseDatabaseSnapshotStandby(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseDatabaseSnapshotStandby(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseDatabaseSnapshotStandby resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseDatabaseSnapshotStandby to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseDatabaseSnapshotStandby that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseDatabaseSnapshotStandby to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseDatabaseSnapshotStandby to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseDatabaseSnapshotStandby that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseDatabaseSnapshotStandby to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandby), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseDatabaseSnapshotStandby.IDatabaseDatabaseSnapshotStandbyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseDatabaseSnapshotStandby.IDatabaseDatabaseSnapshotStandbyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotDurationInDays")]
        public virtual void ResetSnapshotDurationInDays()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandby))!;

        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"fqn\":\"oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyConnectionStringsList\"}")]
        public virtual oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyConnectionStringsList ConnectionStrings
        {
            get => GetInstanceProperty<oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyConnectionStringsList>()!;
        }

        [JsiiProperty(name: "databaseManagementConfig", typeJson: "{\"fqn\":\"oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyDatabaseManagementConfigList\"}")]
        public virtual oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyDatabaseManagementConfigList DatabaseManagementConfig
        {
            get => GetInstanceProperty<oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyDatabaseManagementConfigList>()!;
        }

        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSoftwareImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataGuardGroup", typeJson: "{\"fqn\":\"oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyDataGuardGroupList\"}")]
        public virtual oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyDataGuardGroupList DataGuardGroup
        {
            get => GetInstanceProperty<oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyDataGuardGroupList>()!;
        }

        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyDbBackupConfigList\"}")]
        public virtual oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyDbBackupConfigList DbBackupConfig
        {
            get => GetInstanceProperty<oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyDbBackupConfigList>()!;
        }

        [JsiiProperty(name: "dbHomeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbHomeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbUniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbUniqueName
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

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "isCdb", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCdb
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "lastBackupDurationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LastBackupDurationInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lastBackupTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastBackupTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastFailedBackupTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastFailedBackupTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NcharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pdbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PdbName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sidPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SidPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDatabasePointInTimeRecoveryTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDatabasePointInTimeRecoveryTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseAdminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseAdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotDurationInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SnapshotDurationInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "standbyConversionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StandbyConversionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "databaseAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseAdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotDurationInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SnapshotDurationInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "standbyConversionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StandbyConversionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
