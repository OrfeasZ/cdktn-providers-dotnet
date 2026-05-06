using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataintegrationWorkspaceImportRequests
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataintegrationWorkspaceImportRequests.DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataintegrationWorkspaceImportRequests.DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "areDataAssetReferencesIncluded", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreDataAssetReferencesIncluded
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMessages", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap ErrorMessages
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "fileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "importConflictResolution", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceImportRequests.DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsImportConflictResolutionList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceImportRequests.DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsImportConflictResolutionList ImportConflictResolution
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceImportRequests.DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsImportConflictResolutionList>()!;
        }

        [JsiiProperty(name: "importedObjects", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceImportRequests.DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsImportedObjectsList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceImportRequests.DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsImportedObjectsList ImportedObjects
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceImportRequests.DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItemsImportedObjectsList>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectKeyForImport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectKeyForImport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStorageRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStorageRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStorageTenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStorageTenancyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEndedInMillis", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEndedInMillis
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStartedInMillis", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStartedInMillis
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalImportedObjectCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalImportedObjectCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceImportRequests.DataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataintegrationWorkspaceImportRequests.IDataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceImportRequests.IDataOciDataintegrationWorkspaceImportRequestsImportRequestSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
