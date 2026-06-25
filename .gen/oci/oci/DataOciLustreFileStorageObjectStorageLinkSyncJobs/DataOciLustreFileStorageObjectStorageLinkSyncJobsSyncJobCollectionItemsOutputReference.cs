using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLustreFileStorageObjectStorageLinkSyncJobs
{
    [JsiiClass(nativeType: typeof(oci.DataOciLustreFileStorageObjectStorageLinkSyncJobs.DataOciLustreFileStorageObjectStorageLinkSyncJobsSyncJobCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciLustreFileStorageObjectStorageLinkSyncJobs.DataOciLustreFileStorageObjectStorageLinkSyncJobsSyncJobCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLustreFileStorageObjectStorageLinkSyncJobsSyncJobCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLustreFileStorageObjectStorageLinkSyncJobsSyncJobCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLustreFileStorageObjectStorageLinkSyncJobsSyncJobCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLustreFileStorageObjectStorageLinkSyncJobsSyncJobCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bytesTransferred", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BytesTransferred
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "isOverwrite", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOverwrite
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jobType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lustreFileSystemPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LustreFileSystemPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStoragePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStoragePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectsTransferred", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectsTransferred
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skippedErrorCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkippedErrorCount
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

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalObjectsScanned", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalObjectsScanned
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLustreFileStorageObjectStorageLinkSyncJobs.DataOciLustreFileStorageObjectStorageLinkSyncJobsSyncJobCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciLustreFileStorageObjectStorageLinkSyncJobs.IDataOciLustreFileStorageObjectStorageLinkSyncJobsSyncJobCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLustreFileStorageObjectStorageLinkSyncJobs.IDataOciLustreFileStorageObjectStorageLinkSyncJobsSyncJobCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
