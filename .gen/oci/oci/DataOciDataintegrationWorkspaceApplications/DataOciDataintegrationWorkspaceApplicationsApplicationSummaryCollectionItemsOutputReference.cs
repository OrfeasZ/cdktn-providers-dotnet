using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataintegrationWorkspaceApplications
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "dependentObjectMetadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsDependentObjectMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsDependentObjectMetadataList DependentObjectMetadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsDependentObjectMetadataList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyMap", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap KeyMap
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsMetadataList>()!;
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStatus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectStatus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "objectVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsParentRefList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsParentRefList ParentRef
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsParentRefList>()!;
        }

        [JsiiProperty(name: "publishedObjectMetadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsPublishedObjectMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsPublishedObjectMetadataList PublishedObjectMetadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsPublishedObjectMetadataList>()!;
        }

        [JsiiProperty(name: "registryMetadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsRegistryMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsRegistryMetadataList RegistryMetadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsRegistryMetadataList>()!;
        }

        [JsiiProperty(name: "sourceApplicationInfo", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsSourceApplicationInfoList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsSourceApplicationInfoList SourceApplicationInfo
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItemsSourceApplicationInfoList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePatched", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePatched
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplications.DataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataintegrationWorkspaceApplications.IDataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplications.IDataOciDataintegrationWorkspaceApplicationsApplicationSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
