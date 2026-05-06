using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementInventoryRecords
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "components", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsList\"}")]
        public virtual oci.DataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsList Components
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsList>()!;
        }

        [JsiiProperty(name: "installedPatches", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsInstalledPatchesList\"}")]
        public virtual oci.DataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsInstalledPatchesList InstalledPatches
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsInstalledPatchesList>()!;
        }

        [JsiiProperty(name: "osType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsPropertiesList\"}")]
        public virtual oci.DataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsPropertiesList Properties
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsPropertiesList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetProductId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetProductId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetProductName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetProductName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetResourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceName
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementInventoryRecords.IDataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementInventoryRecords.IDataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
