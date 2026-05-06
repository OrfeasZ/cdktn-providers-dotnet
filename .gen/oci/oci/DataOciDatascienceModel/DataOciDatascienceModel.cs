using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceModel
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_model oci_datascience_model}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceModel.DataOciDatascienceModel), fullyQualifiedName: "oci.dataOciDatascienceModel.DataOciDatascienceModel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatascienceModel.DataOciDatascienceModelConfig\"}}]")]
    public class DataOciDatascienceModel : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_model oci_datascience_model} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatascienceModel(Constructs.Construct scope, string id, oci.DataOciDatascienceModel.IDataOciDatascienceModelConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatascienceModel.IDataOciDatascienceModelConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceModel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceModel(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatascienceModel resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatascienceModel to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatascienceModel that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatascienceModel to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatascienceModel to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_model#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatascienceModel that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatascienceModel to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatascienceModel.DataOciDatascienceModel), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatascienceModel.DataOciDatascienceModel))!;

        [JsiiProperty(name: "artifactContentDisposition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactContentDisposition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactContentLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactContentLength
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactContentMd5", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactContentMd5
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactLastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupOperationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModel.DataOciDatascienceModelBackupOperationDetailsList\"}")]
        public virtual oci.DataOciDatascienceModel.DataOciDatascienceModelBackupOperationDetailsList BackupOperationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModel.DataOciDatascienceModelBackupOperationDetailsList>()!;
        }

        [JsiiProperty(name: "backupSetting", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModel.DataOciDatascienceModelBackupSettingList\"}")]
        public virtual oci.DataOciDatascienceModel.DataOciDatascienceModelBackupSettingList BackupSetting
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModel.DataOciDatascienceModelBackupSettingList>()!;
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customMetadataList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModel.DataOciDatascienceModelCustomMetadataListStructList\"}")]
        public virtual oci.DataOciDatascienceModel.DataOciDatascienceModelCustomMetadataListStructList CustomMetadataList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModel.DataOciDatascienceModelCustomMetadataListStructList>()!;
        }

        [JsiiProperty(name: "definedMetadataList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModel.DataOciDatascienceModelDefinedMetadataListStructList\"}")]
        public virtual oci.DataOciDatascienceModel.DataOciDatascienceModelDefinedMetadataListStructList DefinedMetadataList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModel.DataOciDatascienceModelDefinedMetadataListStructList>()!;
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

        [JsiiProperty(name: "emptyModel", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EmptyModel
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "inputSchema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputSchema
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isModelByReference", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsModelByReference
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelArtifact", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelArtifact
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelVersionSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersionSetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelVersionSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersionSetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputSchema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputSchema
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retentionOperationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModel.DataOciDatascienceModelRetentionOperationDetailsList\"}")]
        public virtual oci.DataOciDatascienceModel.DataOciDatascienceModelRetentionOperationDetailsList RetentionOperationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModel.DataOciDatascienceModelRetentionOperationDetailsList>()!;
        }

        [JsiiProperty(name: "retentionSetting", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModel.DataOciDatascienceModelRetentionSettingList\"}")]
        public virtual oci.DataOciDatascienceModel.DataOciDatascienceModelRetentionSettingList RetentionSetting
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModel.DataOciDatascienceModelRetentionSettingList>()!;
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

        [JsiiProperty(name: "versionLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
