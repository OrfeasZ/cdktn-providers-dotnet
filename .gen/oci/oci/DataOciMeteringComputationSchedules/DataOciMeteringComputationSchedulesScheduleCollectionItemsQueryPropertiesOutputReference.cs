using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMeteringComputationSchedules
{
    [JsiiClass(nativeType: typeof(oci.DataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesOutputReference), fullyQualifiedName: "oci.dataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompartmentDepth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"oci.dataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesDateRangeList\"}")]
        public virtual oci.DataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesDateRangeList DateRange
        {
            get => GetInstanceProperty<oci.DataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesDateRangeList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Filter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Granularity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GroupBy
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "groupByTag", typeJson: "{\"fqn\":\"oci.dataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesGroupByTagList\"}")]
        public virtual oci.DataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesGroupByTagList GroupByTag
        {
            get => GetInstanceProperty<oci.DataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesGroupByTagList>()!;
        }

        [JsiiProperty(name: "isAggregateByTime", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAggregateByTime
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "queryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryProperties\"}", isOptional: true)]
        public virtual oci.DataOciMeteringComputationSchedules.IDataOciMeteringComputationSchedulesScheduleCollectionItemsQueryProperties? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMeteringComputationSchedules.IDataOciMeteringComputationSchedulesScheduleCollectionItemsQueryProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
