using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelCustomMetadataArtifact
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact oci_datascience_model_custom_metadata_artifact}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifact), fullyQualifiedName: "oci.datascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifact", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.datascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifactConfig\"}}]")]
    public class DatascienceModelCustomMetadataArtifact : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact oci_datascience_model_custom_metadata_artifact} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatascienceModelCustomMetadataArtifact(Constructs.Construct scope, string id, oci.DatascienceModelCustomMetadataArtifact.IDatascienceModelCustomMetadataArtifactConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatascienceModelCustomMetadataArtifact.IDatascienceModelCustomMetadataArtifactConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelCustomMetadataArtifact(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelCustomMetadataArtifact(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatascienceModelCustomMetadataArtifact resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatascienceModelCustomMetadataArtifact to import.</param>
        /// <param name="importFromId">The id of the existing DatascienceModelCustomMetadataArtifact that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatascienceModelCustomMetadataArtifact to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatascienceModelCustomMetadataArtifact to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatascienceModelCustomMetadataArtifact that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatascienceModelCustomMetadataArtifact to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifact), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifactTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatascienceModelCustomMetadataArtifact.IDatascienceModelCustomMetadataArtifactTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelCustomMetadataArtifact.IDatascienceModelCustomMetadataArtifactTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.DatascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifact))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.datascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifactTimeoutsOutputReference\"}")]
        public virtual oci.DatascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifactTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifactTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "modelCustomMetadatumArtifactInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelCustomMetadatumArtifactInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifactTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "modelCustomMetadatumArtifact", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelCustomMetadatumArtifact
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
