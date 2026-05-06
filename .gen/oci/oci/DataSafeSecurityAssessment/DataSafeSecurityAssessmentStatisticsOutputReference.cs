using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSecurityAssessment
{
    [JsiiClass(nativeType: typeof(oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsOutputReference), fullyQualifiedName: "oci.dataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataSafeSecurityAssessmentStatisticsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataSafeSecurityAssessmentStatisticsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataSafeSecurityAssessmentStatisticsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSecurityAssessmentStatisticsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "advisory", typeJson: "{\"fqn\":\"oci.dataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsAdvisoryList\"}")]
        public virtual oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsAdvisoryList Advisory
        {
            get => GetInstanceProperty<oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsAdvisoryList>()!;
        }

        [JsiiProperty(name: "deferred", typeJson: "{\"fqn\":\"oci.dataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsDeferredList\"}")]
        public virtual oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsDeferredList Deferred
        {
            get => GetInstanceProperty<oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsDeferredList>()!;
        }

        [JsiiProperty(name: "evaluate", typeJson: "{\"fqn\":\"oci.dataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsEvaluateList\"}")]
        public virtual oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsEvaluateList Evaluate
        {
            get => GetInstanceProperty<oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsEvaluateList>()!;
        }

        [JsiiProperty(name: "highRisk", typeJson: "{\"fqn\":\"oci.dataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsHighRiskList\"}")]
        public virtual oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsHighRiskList HighRisk
        {
            get => GetInstanceProperty<oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsHighRiskList>()!;
        }

        [JsiiProperty(name: "lowRisk", typeJson: "{\"fqn\":\"oci.dataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsLowRiskList\"}")]
        public virtual oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsLowRiskList LowRisk
        {
            get => GetInstanceProperty<oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsLowRiskList>()!;
        }

        [JsiiProperty(name: "mediumRisk", typeJson: "{\"fqn\":\"oci.dataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsMediumRiskList\"}")]
        public virtual oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsMediumRiskList MediumRisk
        {
            get => GetInstanceProperty<oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsMediumRiskList>()!;
        }

        [JsiiProperty(name: "pass", typeJson: "{\"fqn\":\"oci.dataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsPassList\"}")]
        public virtual oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsPassList Pass
        {
            get => GetInstanceProperty<oci.DataSafeSecurityAssessment.DataSafeSecurityAssessmentStatisticsPassList>()!;
        }

        [JsiiProperty(name: "targetsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataSafeSecurityAssessment.DataSafeSecurityAssessmentStatistics\"}", isOptional: true)]
        public virtual oci.DataSafeSecurityAssessment.IDataSafeSecurityAssessmentStatistics? InternalValue
        {
            get => GetInstanceProperty<oci.DataSafeSecurityAssessment.IDataSafeSecurityAssessmentStatistics?>();
            set => SetInstanceProperty(value);
        }
    }
}
