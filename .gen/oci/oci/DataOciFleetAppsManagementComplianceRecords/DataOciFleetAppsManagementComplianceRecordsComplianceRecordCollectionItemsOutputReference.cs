using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementComplianceRecords
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "complianceState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComplianceState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "entityDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patch", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPatchList\"}")]
        public virtual oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPatchList Patch
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPatchList>()!;
        }

        [JsiiProperty(name: "policy", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyList\"}")]
        public virtual oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyList Policy
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsPolicyList>()!;
        }

        [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsResourceList\"}")]
        public virtual oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsResourceList Resource
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsResourceList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsTargetList\"}")]
        public virtual oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsTargetList Target
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItemsTargetList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementComplianceRecords.DataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementComplianceRecords.IDataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementComplianceRecords.IDataOciFleetAppsManagementComplianceRecordsComplianceRecordCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
