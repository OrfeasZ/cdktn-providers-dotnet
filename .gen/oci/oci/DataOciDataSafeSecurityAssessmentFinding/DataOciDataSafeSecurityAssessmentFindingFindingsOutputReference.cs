using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityAssessmentFinding
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityAssessmentFinding.DataOciDataSafeSecurityAssessmentFindingFindingsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSecurityAssessmentFinding.DataOciDataSafeSecurityAssessmentFindingFindingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSecurityAssessmentFindingFindingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSecurityAssessmentFindingFindingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSecurityAssessmentFindingFindingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentFindingFindingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "assessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "details", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Details
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "doclink", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Doclink
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hasTargetDbRiskLevelChanged", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasTargetDbRiskLevelChanged
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRiskModified", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRiskModified
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isTopFinding", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTopFinding
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Justification
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oneline", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Oneline
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleDefinedSeverity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleDefinedSeverity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "references", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentFinding.DataOciDataSafeSecurityAssessmentFindingFindingsReferencesList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentFinding.DataOciDataSafeSecurityAssessmentFindingFindingsReferencesList References
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentFinding.DataOciDataSafeSecurityAssessmentFindingFindingsReferencesList>()!;
        }

        [JsiiProperty(name: "remarks", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Remarks
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Severity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Summary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeValidUntil", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeValidUntil
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentFinding.DataOciDataSafeSecurityAssessmentFindingFindings\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSecurityAssessmentFinding.IDataOciDataSafeSecurityAssessmentFindingFindings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentFinding.IDataOciDataSafeSecurityAssessmentFindingFindings?>();
            set => SetInstanceProperty(value);
        }
    }
}
