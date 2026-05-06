using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMeteringComputationSchedule
{
    [JsiiClass(nativeType: typeof(oci.DataOciMeteringComputationSchedule.DataOciMeteringComputationScheduleQueryPropertiesOutputReference), fullyQualifiedName: "oci.dataOciMeteringComputationSchedule.DataOciMeteringComputationScheduleQueryPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMeteringComputationScheduleQueryPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMeteringComputationScheduleQueryPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMeteringComputationScheduleQueryPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMeteringComputationScheduleQueryPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompartmentDepth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"oci.dataOciMeteringComputationSchedule.DataOciMeteringComputationScheduleQueryPropertiesDateRangeList\"}")]
        public virtual oci.DataOciMeteringComputationSchedule.DataOciMeteringComputationScheduleQueryPropertiesDateRangeList DateRange
        {
            get => GetInstanceProperty<oci.DataOciMeteringComputationSchedule.DataOciMeteringComputationScheduleQueryPropertiesDateRangeList>()!;
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

        [JsiiProperty(name: "groupByTag", typeJson: "{\"fqn\":\"oci.dataOciMeteringComputationSchedule.DataOciMeteringComputationScheduleQueryPropertiesGroupByTagList\"}")]
        public virtual oci.DataOciMeteringComputationSchedule.DataOciMeteringComputationScheduleQueryPropertiesGroupByTagList GroupByTag
        {
            get => GetInstanceProperty<oci.DataOciMeteringComputationSchedule.DataOciMeteringComputationScheduleQueryPropertiesGroupByTagList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMeteringComputationSchedule.DataOciMeteringComputationScheduleQueryProperties\"}", isOptional: true)]
        public virtual oci.DataOciMeteringComputationSchedule.IDataOciMeteringComputationScheduleQueryProperties? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMeteringComputationSchedule.IDataOciMeteringComputationScheduleQueryProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
