using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityAssessments
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "advisory", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsAdvisoryList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsAdvisoryList Advisory
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsAdvisoryList>()!;
        }

        [JsiiProperty(name: "deferred", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsDeferredList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsDeferredList Deferred
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsDeferredList>()!;
        }

        [JsiiProperty(name: "evaluate", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsEvaluateList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsEvaluateList Evaluate
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsEvaluateList>()!;
        }

        [JsiiProperty(name: "highRisk", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsHighRiskList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsHighRiskList HighRisk
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsHighRiskList>()!;
        }

        [JsiiProperty(name: "lowRisk", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsLowRiskList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsLowRiskList LowRisk
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsLowRiskList>()!;
        }

        [JsiiProperty(name: "mediumRisk", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsMediumRiskList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsMediumRiskList MediumRisk
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsMediumRiskList>()!;
        }

        [JsiiProperty(name: "pass", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsPassList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsPassList Pass
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatisticsPassList>()!;
        }

        [JsiiProperty(name: "targetsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessments.DataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatistics\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSecurityAssessments.IDataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatistics? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessments.IDataOciDataSafeSecurityAssessmentsSecurityAssessmentsStatistics?>();
            set => SetInstanceProperty(value);
        }
    }
}
