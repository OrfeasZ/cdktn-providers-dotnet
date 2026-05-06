using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityAssessmentComparison
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSecurityAssessmentComparisonTargetsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSecurityAssessmentComparisonTargetsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSecurityAssessmentComparisonTargetsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentComparisonTargetsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "auditing", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsAuditingList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsAuditingList Auditing
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsAuditingList>()!;
        }

        [JsiiProperty(name: "authorizationControl", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsAuthorizationControlList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsAuthorizationControlList AuthorizationControl
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsAuthorizationControlList>()!;
        }

        [JsiiProperty(name: "baselineTargetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaselineTargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentTargetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentTargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataEncryption", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsDataEncryptionList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsDataEncryptionList DataEncryption
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsDataEncryptionList>()!;
        }

        [JsiiProperty(name: "dbConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsDbConfigurationList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsDbConfigurationList DbConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsDbConfigurationList>()!;
        }

        [JsiiProperty(name: "fineGrainedAccessControl", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsFineGrainedAccessControlList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsFineGrainedAccessControlList FineGrainedAccessControl
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsFineGrainedAccessControlList>()!;
        }

        [JsiiProperty(name: "privilegesAndRoles", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsPrivilegesAndRolesList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsPrivilegesAndRolesList PrivilegesAndRoles
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsPrivilegesAndRolesList>()!;
        }

        [JsiiProperty(name: "userAccounts", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsUserAccountsList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsUserAccountsList UserAccounts
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargetsUserAccountsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentComparison.DataOciDataSafeSecurityAssessmentComparisonTargets\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSecurityAssessmentComparison.IDataOciDataSafeSecurityAssessmentComparisonTargets? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentComparison.IDataOciDataSafeSecurityAssessmentComparisonTargets?>();
            set => SetInstanceProperty(value);
        }
    }
}
