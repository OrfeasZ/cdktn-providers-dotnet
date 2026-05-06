using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMediaServicesMediaAssets
{
    [JsiiClass(nativeType: typeof(oci.DataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "isLockOverride", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLockOverride
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsLocksList\"}")]
        public virtual oci.DataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsLocksList>()!;
        }

        [JsiiProperty(name: "masterMediaAssetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterMediaAssetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mediaAssetTags", typeJson: "{\"fqn\":\"oci.dataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsMediaAssetTagsList\"}")]
        public virtual oci.DataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsMediaAssetTagsList MediaAssetTags
        {
            get => GetInstanceProperty<oci.DataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsMediaAssetTagsList>()!;
        }

        [JsiiProperty(name: "mediaWorkflowJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MediaWorkflowJobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsMetadataList\"}")]
        public virtual oci.DataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItemsMetadataList>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectEtag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectEtag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentMediaAssetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentMediaAssetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "segmentRangeEndIndex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SegmentRangeEndIndex
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "segmentRangeStartIndex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SegmentRangeStartIndex
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceMediaWorkflowId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceMediaWorkflowId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceMediaWorkflowVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceMediaWorkflowVersion
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMediaServicesMediaAssets.DataOciMediaServicesMediaAssetsMediaAssetCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciMediaServicesMediaAssets.IDataOciMediaServicesMediaAssetsMediaAssetCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMediaServicesMediaAssets.IDataOciMediaServicesMediaAssetsMediaAssetCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
