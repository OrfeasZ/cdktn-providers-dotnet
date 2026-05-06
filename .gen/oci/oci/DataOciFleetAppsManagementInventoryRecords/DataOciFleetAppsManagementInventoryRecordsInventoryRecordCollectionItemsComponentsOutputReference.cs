using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementInventoryRecords
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "componentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "componentPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "componentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsPropertiesList\"}")]
        public virtual oci.DataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsPropertiesList Properties
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponentsPropertiesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementInventoryRecords.DataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponents\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementInventoryRecords.IDataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponents? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementInventoryRecords.IDataOciFleetAppsManagementInventoryRecordsInventoryRecordCollectionItemsComponents?>();
            set => SetInstanceProperty(value);
        }
    }
}
