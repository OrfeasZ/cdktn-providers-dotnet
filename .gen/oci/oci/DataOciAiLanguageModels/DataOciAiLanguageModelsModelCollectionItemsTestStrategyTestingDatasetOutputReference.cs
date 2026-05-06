using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAiLanguageModels
{
    [JsiiClass(nativeType: typeof(oci.DataOciAiLanguageModels.DataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDatasetOutputReference), fullyQualifiedName: "oci.dataOciAiLanguageModels.DataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDatasetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDatasetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDatasetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDatasetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDatasetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "datasetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatasetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "datasetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatasetType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locationDetails", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageModels.DataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDatasetLocationDetailsList\"}")]
        public virtual oci.DataOciAiLanguageModels.DataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDatasetLocationDetailsList LocationDetails
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageModels.DataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDatasetLocationDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageModels.DataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDataset\"}", isOptional: true)]
        public virtual oci.DataOciAiLanguageModels.IDataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDataset? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageModels.IDataOciAiLanguageModelsModelCollectionItemsTestStrategyTestingDataset?>();
            set => SetInstanceProperty(value);
        }
    }
}
