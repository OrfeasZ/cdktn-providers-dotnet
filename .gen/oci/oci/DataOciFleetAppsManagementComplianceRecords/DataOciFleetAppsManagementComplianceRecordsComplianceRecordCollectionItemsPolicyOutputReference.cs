using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementComplianceRecords
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compliancePolicyDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompliancePolicyDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compliancePolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompliancePolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compliancePolicyRuleDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompliancePolicyRuleDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compliancePolicyRuleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompliancePolicyRuleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gracePeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GracePeriod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchSelection", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyPatchSelectionList\"}")]
        public virtual oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyPatchSelectionList PatchSelection
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyPatchSelectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicy\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementComplianceRecords.IDataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicy? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementComplianceRecords.IDataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
