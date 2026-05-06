using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDefinedMetadataArtifact
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_defined_metadata_artifact oci_datascience_model_defined_metadata_artifact}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatascienceModelDefinedMetadataArtifact.DatascienceModelDefinedMetadataArtifact), fullyQualifiedName: "oci.datascienceModelDefinedMetadataArtifact.DatascienceModelDefinedMetadataArtifact", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.datascienceModelDefinedMetadataArtifact.DatascienceModelDefinedMetadataArtifactConfig\"}}]")]
    public class DatascienceModelDefinedMetadataArtifact : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_defined_metadata_artifact oci_datascience_model_defined_metadata_artifact} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatascienceModelDefinedMetadataArtifact(Constructs.Construct scope, string id, oci.DatascienceModelDefinedMetadataArtifact.IDatascienceModelDefinedMetadataArtifactConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatascienceModelDefinedMetadataArtifact.IDatascienceModelDefinedMetadataArtifactConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelDefinedMetadataArtifact(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelDefinedMetadataArtifact(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatascienceModelDefinedMetadataArtifact resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatascienceModelDefinedMetadataArtifact to import.</param>
        /// <param name="importFromId">The id of the existing DatascienceModelDefinedMetadataArtifact that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatascienceModelDefinedMetadataArtifact to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatascienceModelDefinedMetadataArtifact to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_defined_metadata_artifact#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatascienceModelDefinedMetadataArtifact that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatascienceModelDefinedMetadataArtifact to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatascienceModelDefinedMetadataArtifact.DatascienceModelDefinedMetadataArtifact), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelDefinedMetadataArtifact.DatascienceModelDefinedMetadataArtifactTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatascienceModelDefinedMetadataArtifact.IDatascienceModelDefinedMetadataArtifactTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelDefinedMetadataArtifact.IDatascienceModelDefinedMetadataArtifactTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContentDisposition")]
        public virtual void ResetContentDisposition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.DatascienceModelDefinedMetadataArtifact.DatascienceModelDefinedMetadataArtifact))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.datascienceModelDefinedMetadataArtifact.DatascienceModelDefinedMetadataArtifactTimeoutsOutputReference\"}")]
        public virtual oci.DatascienceModelDefinedMetadataArtifact.DatascienceModelDefinedMetadataArtifactTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatascienceModelDefinedMetadataArtifact.DatascienceModelDefinedMetadataArtifactTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentDispositionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentDispositionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentLengthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentLengthInput
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
        [JsiiProperty(name: "metadatumKeyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetadatumKeyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelDefinedMetadatumArtifactInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelDefinedMetadatumArtifactInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datascienceModelDefinedMetadataArtifact.DatascienceModelDefinedMetadataArtifactTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "contentDisposition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentDisposition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentLength
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

        [JsiiProperty(name: "metadatumKeyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetadatumKeyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelDefinedMetadatumArtifact", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelDefinedMetadatumArtifact
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
