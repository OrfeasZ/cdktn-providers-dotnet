using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciPsqlDbSystemPitrDetail
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/psql_db_system_pitr_detail oci_psql_db_system_pitr_detail}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciPsqlDbSystemPitrDetail.DataOciPsqlDbSystemPitrDetail), fullyQualifiedName: "oci.dataOciPsqlDbSystemPitrDetail.DataOciPsqlDbSystemPitrDetail", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciPsqlDbSystemPitrDetail.DataOciPsqlDbSystemPitrDetailConfig\"}}]")]
    public class DataOciPsqlDbSystemPitrDetail : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/psql_db_system_pitr_detail oci_psql_db_system_pitr_detail} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciPsqlDbSystemPitrDetail(Constructs.Construct scope, string id, oci.DataOciPsqlDbSystemPitrDetail.IDataOciPsqlDbSystemPitrDetailConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciPsqlDbSystemPitrDetail.IDataOciPsqlDbSystemPitrDetailConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciPsqlDbSystemPitrDetail(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciPsqlDbSystemPitrDetail(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciPsqlDbSystemPitrDetail resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciPsqlDbSystemPitrDetail to import.</param>
        /// <param name="importFromId">The id of the existing DataOciPsqlDbSystemPitrDetail that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciPsqlDbSystemPitrDetail to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciPsqlDbSystemPitrDetail to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/psql_db_system_pitr_detail#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciPsqlDbSystemPitrDetail that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciPsqlDbSystemPitrDetail to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciPsqlDbSystemPitrDetail.DataOciPsqlDbSystemPitrDetail), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciPsqlDbSystemPitrDetail.DataOciPsqlDbSystemPitrDetail))!;

        [JsiiProperty(name: "pitrState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PitrState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recoveryTimeWindows", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystemPitrDetail.DataOciPsqlDbSystemPitrDetailRecoveryTimeWindowsList\"}")]
        public virtual oci.DataOciPsqlDbSystemPitrDetail.DataOciPsqlDbSystemPitrDetailRecoveryTimeWindowsList RecoveryTimeWindows
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystemPitrDetail.DataOciPsqlDbSystemPitrDetailRecoveryTimeWindowsList>()!;
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
    }
}
