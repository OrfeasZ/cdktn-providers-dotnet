using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDevopsRepositoryMirrorrecordA
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_repository_mirrorrecord oci_devops_repository_mirrorrecord}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDevopsRepositoryMirrorrecordA.DataOciDevopsRepositoryMirrorrecordA), fullyQualifiedName: "oci.dataOciDevopsRepositoryMirrorrecordA.DataOciDevopsRepositoryMirrorrecordA", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDevopsRepositoryMirrorrecordA.DataOciDevopsRepositoryMirrorrecordAConfig\"}}]")]
    public class DataOciDevopsRepositoryMirrorrecordA : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_repository_mirrorrecord oci_devops_repository_mirrorrecord} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDevopsRepositoryMirrorrecordA(Constructs.Construct scope, string id, oci.DataOciDevopsRepositoryMirrorrecordA.IDataOciDevopsRepositoryMirrorrecordAConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDevopsRepositoryMirrorrecordA.IDataOciDevopsRepositoryMirrorrecordAConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsRepositoryMirrorrecordA(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsRepositoryMirrorrecordA(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDevopsRepositoryMirrorrecordA resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDevopsRepositoryMirrorrecordA to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDevopsRepositoryMirrorrecordA that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDevopsRepositoryMirrorrecordA to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDevopsRepositoryMirrorrecordA to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_repository_mirrorrecord#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDevopsRepositoryMirrorrecordA that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDevopsRepositoryMirrorrecordA to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDevopsRepositoryMirrorrecordA.DataOciDevopsRepositoryMirrorrecordA), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDevopsRepositoryMirrorrecordA.DataOciDevopsRepositoryMirrorrecordA))!;

        [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enqueueTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnqueueTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mirrorStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MirrorStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkRequestId
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
        [JsiiProperty(name: "mirrorRecordTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MirrorRecordTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mirrorRecordType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MirrorRecordType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
