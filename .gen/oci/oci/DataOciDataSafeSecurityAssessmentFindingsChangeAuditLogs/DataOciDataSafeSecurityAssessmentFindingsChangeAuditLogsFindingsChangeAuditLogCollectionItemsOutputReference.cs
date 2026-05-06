using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityAssessmentFindingsChangeAuditLogs
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityAssessmentFindingsChangeAuditLogs.DataOciDataSafeSecurityAssessmentFindingsChangeAuditLogsFindingsChangeAuditLogCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSecurityAssessmentFindingsChangeAuditLogs.DataOciDataSafeSecurityAssessmentFindingsChangeAuditLogsFindingsChangeAuditLogCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSecurityAssessmentFindingsChangeAuditLogsFindingsChangeAuditLogCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSecurityAssessmentFindingsChangeAuditLogsFindingsChangeAuditLogCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSecurityAssessmentFindingsChangeAuditLogsFindingsChangeAuditLogCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentFindingsChangeAuditLogsFindingsChangeAuditLogCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "assessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "findingKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FindingKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "findingTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FindingTitle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isRiskDeferred", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRiskDeferred
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

        [JsiiProperty(name: "modifiedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleDefinedSeverity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleDefinedSeverity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "previousSeverity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreviousSeverity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Severity
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentFindingsChangeAuditLogs.DataOciDataSafeSecurityAssessmentFindingsChangeAuditLogsFindingsChangeAuditLogCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSecurityAssessmentFindingsChangeAuditLogs.IDataOciDataSafeSecurityAssessmentFindingsChangeAuditLogsFindingsChangeAuditLogCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentFindingsChangeAuditLogs.IDataOciDataSafeSecurityAssessmentFindingsChangeAuditLogsFindingsChangeAuditLogCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
