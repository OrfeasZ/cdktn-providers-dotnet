using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsCreatedByList\"}")]
        public virtual oci.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsCreatedByList CreatedBy
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsCreatedByList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "lastUpdatedBy", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsLastUpdatedByList\"}")]
        public virtual oci.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsLastUpdatedByList LastUpdatedBy
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItemsLastUpdatedByList>()!;
        }

        [JsiiProperty(name: "licenseAcceptanceStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseAcceptanceStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseType
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeAccepted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAccepted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords.IDataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaDownloadsJavaLicenseAcceptanceRecords.IDataOciJmsJavaDownloadsJavaLicenseAcceptanceRecordsJavaLicenseAcceptanceRecordCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
