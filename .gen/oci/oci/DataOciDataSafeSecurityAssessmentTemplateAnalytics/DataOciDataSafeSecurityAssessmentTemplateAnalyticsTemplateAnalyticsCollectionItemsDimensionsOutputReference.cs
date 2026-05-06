using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityAssessmentTemplateAnalytics
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityAssessmentTemplateAnalytics.DataOciDataSafeSecurityAssessmentTemplateAnalyticsTemplateAnalyticsCollectionItemsDimensionsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSecurityAssessmentTemplateAnalytics.DataOciDataSafeSecurityAssessmentTemplateAnalyticsTemplateAnalyticsCollectionItemsDimensionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSecurityAssessmentTemplateAnalyticsTemplateAnalyticsCollectionItemsDimensionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSecurityAssessmentTemplateAnalyticsTemplateAnalyticsCollectionItemsDimensionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSecurityAssessmentTemplateAnalyticsTemplateAnalyticsCollectionItemsDimensionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentTemplateAnalyticsTemplateAnalyticsCollectionItemsDimensionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "isCompared", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCompared
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCompliant", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCompliant
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isGroup", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsGroup
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "targetDatabaseGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetDatabaseGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "templateAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemplateAssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "templateBaselineAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemplateBaselineAssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastCompared", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastCompared
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalChecks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalChecks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalChecksFailed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalChecksFailed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalNonCompliantTargets", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalNonCompliantTargets
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalTargets", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalTargets
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentTemplateAnalytics.DataOciDataSafeSecurityAssessmentTemplateAnalyticsTemplateAnalyticsCollectionItemsDimensions\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSecurityAssessmentTemplateAnalytics.IDataOciDataSafeSecurityAssessmentTemplateAnalyticsTemplateAnalyticsCollectionItemsDimensions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentTemplateAnalytics.IDataOciDataSafeSecurityAssessmentTemplateAnalyticsTemplateAnalyticsCollectionItemsDimensions?>();
            set => SetInstanceProperty(value);
        }
    }
}
