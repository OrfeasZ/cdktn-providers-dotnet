using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_autonomous_database_ru_change_log oci_distributed_database_distributed_autonomous_database_ru_change_log}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLogConfig\"}}]")]
    public class DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_autonomous_database_ru_change_log oci_distributed_database_distributed_autonomous_database_ru_change_log} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog(Constructs.Construct scope, string id, oci.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog.IDataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLogConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog.IDataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLogConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_autonomous_database_ru_change_log#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceShardName")]
        public virtual void ResetSourceShardName()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog))!;

        [JsiiProperty(name: "ruChangeLog", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLogRuChangeLogList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLogRuChangeLogList RuChangeLog
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedAutonomousDatabaseRuChangeLogRuChangeLogList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "distributedAutonomousDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DistributedAutonomousDatabaseIdInput
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
        [JsiiProperty(name: "sourceShardNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceShardNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "distributedAutonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistributedAutonomousDatabaseId
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

        [JsiiProperty(name: "sourceShardName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceShardName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
