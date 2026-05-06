using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseDbSystemsUpgradeHistoryEntry
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_db_systems_upgrade_history_entry oci_database_db_systems_upgrade_history_entry}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseDbSystemsUpgradeHistoryEntry.DataOciDatabaseDbSystemsUpgradeHistoryEntry), fullyQualifiedName: "oci.dataOciDatabaseDbSystemsUpgradeHistoryEntry.DataOciDatabaseDbSystemsUpgradeHistoryEntry", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseDbSystemsUpgradeHistoryEntry.DataOciDatabaseDbSystemsUpgradeHistoryEntryConfig\"}}]")]
    public class DataOciDatabaseDbSystemsUpgradeHistoryEntry : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_db_systems_upgrade_history_entry oci_database_db_systems_upgrade_history_entry} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseDbSystemsUpgradeHistoryEntry(Constructs.Construct scope, string id, oci.DataOciDatabaseDbSystemsUpgradeHistoryEntry.IDataOciDatabaseDbSystemsUpgradeHistoryEntryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseDbSystemsUpgradeHistoryEntry.IDataOciDatabaseDbSystemsUpgradeHistoryEntryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseDbSystemsUpgradeHistoryEntry(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseDbSystemsUpgradeHistoryEntry(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseDbSystemsUpgradeHistoryEntry resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseDbSystemsUpgradeHistoryEntry to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseDbSystemsUpgradeHistoryEntry that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseDbSystemsUpgradeHistoryEntry to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseDbSystemsUpgradeHistoryEntry to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_db_systems_upgrade_history_entry#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseDbSystemsUpgradeHistoryEntry that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseDbSystemsUpgradeHistoryEntry to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseDbSystemsUpgradeHistoryEntry.DataOciDatabaseDbSystemsUpgradeHistoryEntry), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseDbSystemsUpgradeHistoryEntry.DataOciDatabaseDbSystemsUpgradeHistoryEntry))!;

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "newGiVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NewGiVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "newOsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NewOsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oldGiVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OldGiVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oldOsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OldOsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "snapshotRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SnapshotRetentionPeriodInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbSystemIdInput
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
        [JsiiProperty(name: "upgradeHistoryEntryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpgradeHistoryEntryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
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

        [JsiiProperty(name: "upgradeHistoryEntryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradeHistoryEntryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
