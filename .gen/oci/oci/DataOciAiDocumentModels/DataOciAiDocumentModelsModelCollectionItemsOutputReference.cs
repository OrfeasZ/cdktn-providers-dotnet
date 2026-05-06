using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAiDocumentModels
{
    [JsiiClass(nativeType: typeof(oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAiDocumentModelsModelCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAiDocumentModelsModelCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAiDocumentModelsModelCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiDocumentModelsModelCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "componentModels", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsComponentModelsList\"}")]
        public virtual oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsComponentModelsList ComponentModels
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsComponentModelsList>()!;
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

        [JsiiProperty(name: "inferenceUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InferenceUnits
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isComposedModel", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsComposedModel
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isQuickMode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsQuickMode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Labels
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Language
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsLocksList\"}")]
        public virtual oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsLocksList>()!;
        }

        [JsiiProperty(name: "maxTrainingTimeInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTrainingTimeInHours
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsMetricsList\"}")]
        public virtual oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsMetricsList Metrics
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsMetricsList>()!;
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelSubType", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsModelSubTypeList\"}")]
        public virtual oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsModelSubTypeList ModelSubType
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsModelSubTypeList>()!;
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "testingDataset", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsTestingDatasetList\"}")]
        public virtual oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsTestingDatasetList TestingDataset
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsTestingDatasetList>()!;
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

        [JsiiProperty(name: "trainedTimeInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TrainedTimeInHours
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "trainingDataset", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsTrainingDatasetList\"}")]
        public virtual oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsTrainingDatasetList TrainingDataset
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsTrainingDatasetList>()!;
        }

        [JsiiProperty(name: "validationDataset", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsValidationDatasetList\"}")]
        public virtual oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsValidationDatasetList ValidationDataset
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItemsValidationDatasetList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModels.DataOciAiDocumentModelsModelCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciAiDocumentModels.IDataOciAiDocumentModelsModelCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModels.IDataOciAiDocumentModelsModelCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
