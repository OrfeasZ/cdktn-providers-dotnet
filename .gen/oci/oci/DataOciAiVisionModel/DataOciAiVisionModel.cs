using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAiVisionModel
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ai_vision_model oci_ai_vision_model}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciAiVisionModel.DataOciAiVisionModel), fullyQualifiedName: "oci.dataOciAiVisionModel.DataOciAiVisionModel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciAiVisionModel.DataOciAiVisionModelConfig\"}}]")]
    public class DataOciAiVisionModel : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ai_vision_model oci_ai_vision_model} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciAiVisionModel(Constructs.Construct scope, string id, oci.DataOciAiVisionModel.IDataOciAiVisionModelConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciAiVisionModel.IDataOciAiVisionModelConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiVisionModel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiVisionModel(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciAiVisionModel resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciAiVisionModel to import.</param>
        /// <param name="importFromId">The id of the existing DataOciAiVisionModel that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciAiVisionModel to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciAiVisionModel to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ai_vision_model#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciAiVisionModel that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciAiVisionModel to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciAiVisionModel.DataOciAiVisionModel), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciAiVisionModel.DataOciAiVisionModel))!;

        [JsiiProperty(name: "averagePrecision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AveragePrecision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "confidenceThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfidenceThreshold
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "isQuickMode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsQuickMode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxTrainingDurationInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTrainingDurationInHours
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Metrics
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "precision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Precision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recall", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Recall
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "testImageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TestImageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "testingDataset", typeJson: "{\"fqn\":\"oci.dataOciAiVisionModel.DataOciAiVisionModelTestingDatasetList\"}")]
        public virtual oci.DataOciAiVisionModel.DataOciAiVisionModelTestingDatasetList TestingDataset
        {
            get => GetInstanceProperty<oci.DataOciAiVisionModel.DataOciAiVisionModelTestingDatasetList>()!;
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

        [JsiiProperty(name: "totalImageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalImageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "trainedDurationInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TrainedDurationInHours
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "trainingDataset", typeJson: "{\"fqn\":\"oci.dataOciAiVisionModel.DataOciAiVisionModelTrainingDatasetList\"}")]
        public virtual oci.DataOciAiVisionModel.DataOciAiVisionModelTrainingDatasetList TrainingDataset
        {
            get => GetInstanceProperty<oci.DataOciAiVisionModel.DataOciAiVisionModelTrainingDatasetList>()!;
        }

        [JsiiProperty(name: "validationDataset", typeJson: "{\"fqn\":\"oci.dataOciAiVisionModel.DataOciAiVisionModelValidationDatasetList\"}")]
        public virtual oci.DataOciAiVisionModel.DataOciAiVisionModelValidationDatasetList ValidationDataset
        {
            get => GetInstanceProperty<oci.DataOciAiVisionModel.DataOciAiVisionModelValidationDatasetList>()!;
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
