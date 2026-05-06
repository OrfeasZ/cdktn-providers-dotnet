using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMeteringComputationUsageCarbonEmissionsQuery
{
    [JsiiClass(nativeType: typeof(oci.DataOciMeteringComputationUsageCarbonEmissionsQuery.DataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryOutputReference), fullyQualifiedName: "oci.dataOciMeteringComputationUsageCarbonEmissionsQuery.DataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompartmentDepth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dateRangeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DateRangeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emissionCalculationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmissionCalculationMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emissionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmissionType
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

        [JsiiProperty(name: "groupByTag", typeJson: "{\"fqn\":\"oci.dataOciMeteringComputationUsageCarbonEmissionsQuery.DataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryGroupByTagList\"}")]
        public virtual oci.DataOciMeteringComputationUsageCarbonEmissionsQuery.DataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryGroupByTagList GroupByTag
        {
            get => GetInstanceProperty<oci.DataOciMeteringComputationUsageCarbonEmissionsQuery.DataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryGroupByTagList>()!;
        }

        [JsiiProperty(name: "isAggregateByTime", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAggregateByTime
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUsageEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUsageStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usageCarbonEmissionsQueryFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageCarbonEmissionsQueryFilter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMeteringComputationUsageCarbonEmissionsQuery.DataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQuery\"}", isOptional: true)]
        public virtual oci.DataOciMeteringComputationUsageCarbonEmissionsQuery.IDataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQuery? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMeteringComputationUsageCarbonEmissionsQuery.IDataOciMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQuery?>();
            set => SetInstanceProperty(value);
        }
    }
}
