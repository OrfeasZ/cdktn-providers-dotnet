using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiNewsReport
{
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiNewsReport.DataOciOpsiNewsReportContentTypesOutputReference), fullyQualifiedName: "oci.dataOciOpsiNewsReport.DataOciOpsiNewsReportContentTypesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOpsiNewsReportContentTypesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOpsiNewsReportContentTypesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOpsiNewsReportContentTypesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiNewsReportContentTypesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "actionableInsightsResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ActionableInsightsResources
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "capacityPlanningResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CapacityPlanningResources
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sqlInsightsFleetAnalysisResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SqlInsightsFleetAnalysisResources
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sqlInsightsPerformanceDegradationResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SqlInsightsPerformanceDegradationResources
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sqlInsightsPlanChangesResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SqlInsightsPlanChangesResources
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sqlInsightsTopDatabasesResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SqlInsightsTopDatabasesResources
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sqlInsightsTopSqlByInsightsResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SqlInsightsTopSqlByInsightsResources
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sqlInsightsTopSqlResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SqlInsightsTopSqlResources
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOpsiNewsReport.DataOciOpsiNewsReportContentTypes\"}", isOptional: true)]
        public virtual oci.DataOciOpsiNewsReport.IDataOciOpsiNewsReportContentTypes? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOpsiNewsReport.IDataOciOpsiNewsReportContentTypes?>();
            set => SetInstanceProperty(value);
        }
    }
}
