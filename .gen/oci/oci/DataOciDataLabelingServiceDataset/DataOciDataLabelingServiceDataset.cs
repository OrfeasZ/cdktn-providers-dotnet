using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataLabelingServiceDataset
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_labeling_service_dataset oci_data_labeling_service_dataset}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDataset), fullyQualifiedName: "oci.dataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDataset", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetConfig\"}}]")]
    public class DataOciDataLabelingServiceDataset : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_labeling_service_dataset oci_data_labeling_service_dataset} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataLabelingServiceDataset(Constructs.Construct scope, string id, oci.DataOciDataLabelingServiceDataset.IDataOciDataLabelingServiceDatasetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataLabelingServiceDataset.IDataOciDataLabelingServiceDatasetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataLabelingServiceDataset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataLabelingServiceDataset(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataLabelingServiceDataset resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataLabelingServiceDataset to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataLabelingServiceDataset that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataLabelingServiceDataset to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataLabelingServiceDataset to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_labeling_service_dataset#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataLabelingServiceDataset that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataLabelingServiceDataset to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDataset), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDataset))!;

        [JsiiProperty(name: "additionalProperties", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalProperties
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "annotationFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnnotationFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "datasetFormatDetails", typeJson: "{\"fqn\":\"oci.dataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetDatasetFormatDetailsList\"}")]
        public virtual oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetDatasetFormatDetailsList DatasetFormatDetails
        {
            get => GetInstanceProperty<oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetDatasetFormatDetailsList>()!;
        }

        [JsiiProperty(name: "datasetSourceDetails", typeJson: "{\"fqn\":\"oci.dataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetDatasetSourceDetailsList\"}")]
        public virtual oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetDatasetSourceDetailsList DatasetSourceDetails
        {
            get => GetInstanceProperty<oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetDatasetSourceDetailsList>()!;
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

        [JsiiProperty(name: "initialImportDatasetConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetInitialImportDatasetConfigurationList\"}")]
        public virtual oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetInitialImportDatasetConfigurationList InitialImportDatasetConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetInitialImportDatasetConfigurationList>()!;
        }

        [JsiiProperty(name: "initialRecordGenerationConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetInitialRecordGenerationConfigurationList\"}")]
        public virtual oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetInitialRecordGenerationConfigurationList InitialRecordGenerationConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetInitialRecordGenerationConfigurationList>()!;
        }

        [JsiiProperty(name: "labelingInstructions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LabelingInstructions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "labelSet", typeJson: "{\"fqn\":\"oci.dataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetLabelSetList\"}")]
        public virtual oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetLabelSetList LabelSet
        {
            get => GetInstanceProperty<oci.DataOciDataLabelingServiceDataset.DataOciDataLabelingServiceDatasetLabelSetList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleSubstate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleSubstate
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatasetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "datasetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatasetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
