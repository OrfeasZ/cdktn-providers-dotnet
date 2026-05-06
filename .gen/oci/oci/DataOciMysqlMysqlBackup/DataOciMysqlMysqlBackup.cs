using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlMysqlBackup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/mysql_mysql_backup oci_mysql_mysql_backup}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackup), fullyQualifiedName: "oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupConfig\"}}]")]
    public class DataOciMysqlMysqlBackup : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/mysql_mysql_backup oci_mysql_mysql_backup} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciMysqlMysqlBackup(Constructs.Construct scope, string id, oci.DataOciMysqlMysqlBackup.IDataOciMysqlMysqlBackupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciMysqlMysqlBackup.IDataOciMysqlMysqlBackupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlMysqlBackup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlMysqlBackup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciMysqlMysqlBackup resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciMysqlMysqlBackup to import.</param>
        /// <param name="importFromId">The id of the existing DataOciMysqlMysqlBackup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciMysqlMysqlBackup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciMysqlMysqlBackup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/mysql_mysql_backup#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciMysqlMysqlBackup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciMysqlMysqlBackup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackup))!;

        [JsiiProperty(name: "backupSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupValidationDetails", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupBackupValidationDetailsList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupBackupValidationDetailsList BackupValidationDetails
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupBackupValidationDetailsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbSystemSnapshot", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotList DbSystemSnapshot
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotList>()!;
        }

        [JsiiProperty(name: "dbSystemSnapshotSummary", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotSummaryList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotSummaryList DbSystemSnapshotSummary
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotSummaryList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptData", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupEncryptDataList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupEncryptDataList EncryptData
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupEncryptDataList>()!;
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

        [JsiiProperty(name: "immediateSourceBackupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImmediateSourceBackupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mysqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MysqlVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originalSourceBackupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginalSourceBackupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "softDelete", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftDelete
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupSourceDetailsList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupSourceDetailsList SourceDetails
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupSourceDetailsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCopyCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCopyCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validateBackupDetails", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupValidateBackupDetailsList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupValidateBackupDetailsList ValidateBackupDetails
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupValidateBackupDetailsList>()!;
        }

        [JsiiProperty(name: "validateTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidateTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
