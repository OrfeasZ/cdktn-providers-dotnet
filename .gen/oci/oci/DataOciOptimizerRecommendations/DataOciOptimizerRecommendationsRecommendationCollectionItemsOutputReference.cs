using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOptimizerRecommendations
{
    [JsiiClass(nativeType: typeof(oci.DataOciOptimizerRecommendations.DataOciOptimizerRecommendationsRecommendationCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOptimizerRecommendations.DataOciOptimizerRecommendationsRecommendationCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOptimizerRecommendationsRecommendationCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOptimizerRecommendationsRecommendationCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOptimizerRecommendationsRecommendationCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOptimizerRecommendationsRecommendationCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "categoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CategoryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedCostSaving", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EstimatedCostSaving
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "extendedMetadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap ExtendedMetadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "importance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Importance
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recommendationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecommendationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceCounts", typeJson: "{\"fqn\":\"oci.dataOciOptimizerRecommendations.DataOciOptimizerRecommendationsRecommendationCollectionItemsResourceCountsList\"}")]
        public virtual oci.DataOciOptimizerRecommendations.DataOciOptimizerRecommendationsRecommendationCollectionItemsResourceCountsList ResourceCounts
        {
            get => GetInstanceProperty<oci.DataOciOptimizerRecommendations.DataOciOptimizerRecommendationsRecommendationCollectionItemsResourceCountsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportedLevels", typeJson: "{\"fqn\":\"oci.dataOciOptimizerRecommendations.DataOciOptimizerRecommendationsRecommendationCollectionItemsSupportedLevelsList\"}")]
        public virtual oci.DataOciOptimizerRecommendations.DataOciOptimizerRecommendationsRecommendationCollectionItemsSupportedLevelsList SupportedLevels
        {
            get => GetInstanceProperty<oci.DataOciOptimizerRecommendations.DataOciOptimizerRecommendationsRecommendationCollectionItemsSupportedLevelsList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStatusBegin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStatusBegin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStatusEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStatusEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOptimizerRecommendations.DataOciOptimizerRecommendationsRecommendationCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOptimizerRecommendations.IDataOciOptimizerRecommendationsRecommendationCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOptimizerRecommendations.IDataOciOptimizerRecommendationsRecommendationCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
