using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAiVisionModels
{
    [JsiiClass(nativeType: typeof(oci.DataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAiVisionModelsModelCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAiVisionModelsModelCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiVisionModelsModelCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiVisionModelsModelCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

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

        [JsiiProperty(name: "testingDataset", typeJson: "{\"fqn\":\"oci.dataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItemsTestingDatasetList\"}")]
        public virtual oci.DataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItemsTestingDatasetList TestingDataset
        {
            get => GetInstanceProperty<oci.DataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItemsTestingDatasetList>()!;
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

        [JsiiProperty(name: "trainingDataset", typeJson: "{\"fqn\":\"oci.dataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItemsTrainingDatasetList\"}")]
        public virtual oci.DataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItemsTrainingDatasetList TrainingDataset
        {
            get => GetInstanceProperty<oci.DataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItemsTrainingDatasetList>()!;
        }

        [JsiiProperty(name: "validationDataset", typeJson: "{\"fqn\":\"oci.dataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItemsValidationDatasetList\"}")]
        public virtual oci.DataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItemsValidationDatasetList ValidationDataset
        {
            get => GetInstanceProperty<oci.DataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItemsValidationDatasetList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAiVisionModels.DataOciAiVisionModelsModelCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciAiVisionModels.IDataOciAiVisionModelsModelCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAiVisionModels.IDataOciAiVisionModelsModelCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
