using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_database_ru_change_log oci_distributed_database_distributed_database_ru_change_log}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedDatabaseRuChangeLogConfig\"}}]")]
    public class DataOciDistributedDatabaseDistributedDatabaseRuChangeLog : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_database_ru_change_log oci_distributed_database_distributed_database_ru_change_log} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDistributedDatabaseDistributedDatabaseRuChangeLog(Constructs.Construct scope, string id, oci.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog.IDataOciDistributedDatabaseDistributedDatabaseRuChangeLogConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog.IDataOciDistributedDatabaseDistributedDatabaseRuChangeLogConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedDatabaseRuChangeLog(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedDatabaseRuChangeLog(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDistributedDatabaseDistributedDatabaseRuChangeLog resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDistributedDatabaseDistributedDatabaseRuChangeLog to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDistributedDatabaseDistributedDatabaseRuChangeLog that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDistributedDatabaseDistributedDatabaseRuChangeLog to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDistributedDatabaseDistributedDatabaseRuChangeLog to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_database_ru_change_log#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDistributedDatabaseDistributedDatabaseRuChangeLog that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDistributedDatabaseDistributedDatabaseRuChangeLog to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog))!;

        [JsiiProperty(name: "ruChangeLog", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedDatabaseRuChangeLogRuChangeLogList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedDatabaseRuChangeLogRuChangeLogList RuChangeLog
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabaseRuChangeLog.DataOciDistributedDatabaseDistributedDatabaseRuChangeLogRuChangeLogList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "distributedDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DistributedDatabaseIdInput
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

        [JsiiProperty(name: "distributedDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistributedDatabaseId
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
