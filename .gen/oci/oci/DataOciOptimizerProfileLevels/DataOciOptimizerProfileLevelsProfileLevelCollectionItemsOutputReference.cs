using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOptimizerProfileLevels
{
    [JsiiClass(nativeType: typeof(oci.DataOciOptimizerProfileLevels.DataOciOptimizerProfileLevelsProfileLevelCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOptimizerProfileLevels.DataOciOptimizerProfileLevelsProfileLevelCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOptimizerProfileLevelsProfileLevelCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOptimizerProfileLevelsProfileLevelCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOptimizerProfileLevelsProfileLevelCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOptimizerProfileLevelsProfileLevelCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "defaultInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultInterval
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"oci.dataOciOptimizerProfileLevels.DataOciOptimizerProfileLevelsProfileLevelCollectionItemsMetricsList\"}")]
        public virtual oci.DataOciOptimizerProfileLevels.DataOciOptimizerProfileLevelsProfileLevelCollectionItemsMetricsList Metrics
        {
            get => GetInstanceProperty<oci.DataOciOptimizerProfileLevels.DataOciOptimizerProfileLevelsProfileLevelCollectionItemsMetricsList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recommendationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecommendationName
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

        [JsiiProperty(name: "validIntervals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] ValidIntervals
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOptimizerProfileLevels.DataOciOptimizerProfileLevelsProfileLevelCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOptimizerProfileLevels.IDataOciOptimizerProfileLevelsProfileLevelCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOptimizerProfileLevels.IDataOciOptimizerProfileLevelsProfileLevelCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
