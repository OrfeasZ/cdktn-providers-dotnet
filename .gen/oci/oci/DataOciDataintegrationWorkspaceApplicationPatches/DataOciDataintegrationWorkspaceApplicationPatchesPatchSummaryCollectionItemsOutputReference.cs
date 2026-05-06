using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataintegrationWorkspaceApplicationPatches
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dependentObjectMetadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsDependentObjectMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsDependentObjectMetadataList DependentObjectMetadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsDependentObjectMetadataList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMessages", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap ErrorMessages
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsMetadataList>()!;
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

        [JsiiProperty(name: "objectKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ObjectKeys
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsParentRefList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsParentRefList ParentRef
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsParentRefList>()!;
        }

        [JsiiProperty(name: "patchObjectMetadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsPatchObjectMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsPatchObjectMetadataList PatchObjectMetadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsPatchObjectMetadataList>()!;
        }

        [JsiiProperty(name: "patchStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "registryMetadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsRegistryMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsRegistryMetadataList RegistryMetadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItemsRegistryMetadataList>()!;
        }

        [JsiiProperty(name: "timePatched", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePatched
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationPatches.DataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationPatches.IDataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationPatches.IDataOciDataintegrationWorkspaceApplicationPatchesPatchSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
