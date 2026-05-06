using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsJavaDownloadsJavaDownloadReports
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsJavaDownloadsJavaDownloadReports.DataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsJavaDownloadsJavaDownloadReports.DataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "checksumType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChecksumType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checksumValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChecksumValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaDownloadsJavaDownloadReports.DataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItemsCreatedByList\"}")]
        public virtual oci.DataOciJmsJavaDownloadsJavaDownloadReports.DataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItemsCreatedByList CreatedBy
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaDownloadsJavaDownloadReports.DataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItemsCreatedByList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSizeInBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSizeInBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Format
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

        [JsiiProperty(name: "sortBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SortBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SortOrder
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

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaDownloadsJavaDownloadReports.DataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsJavaDownloadsJavaDownloadReports.IDataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaDownloadsJavaDownloadReports.IDataOciJmsJavaDownloadsJavaDownloadReportsJavaDownloadReportCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
