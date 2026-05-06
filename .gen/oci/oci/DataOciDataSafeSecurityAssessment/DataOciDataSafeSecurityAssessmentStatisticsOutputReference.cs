using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityAssessment
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSecurityAssessmentStatisticsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSecurityAssessmentStatisticsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSecurityAssessmentStatisticsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentStatisticsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "advisory", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsAdvisoryList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsAdvisoryList Advisory
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsAdvisoryList>()!;
        }

        [JsiiProperty(name: "deferred", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsDeferredList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsDeferredList Deferred
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsDeferredList>()!;
        }

        [JsiiProperty(name: "evaluate", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsEvaluateList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsEvaluateList Evaluate
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsEvaluateList>()!;
        }

        [JsiiProperty(name: "highRisk", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsHighRiskList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsHighRiskList HighRisk
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsHighRiskList>()!;
        }

        [JsiiProperty(name: "lowRisk", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsLowRiskList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsLowRiskList LowRisk
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsLowRiskList>()!;
        }

        [JsiiProperty(name: "mediumRisk", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsMediumRiskList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsMediumRiskList MediumRisk
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsMediumRiskList>()!;
        }

        [JsiiProperty(name: "pass", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsPassList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsPassList Pass
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatisticsPassList>()!;
        }

        [JsiiProperty(name: "targetsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessment.DataOciDataSafeSecurityAssessmentStatistics\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSecurityAssessment.IDataOciDataSafeSecurityAssessmentStatistics? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessment.IDataOciDataSafeSecurityAssessmentStatistics?>();
            set => SetInstanceProperty(value);
        }
    }
}
