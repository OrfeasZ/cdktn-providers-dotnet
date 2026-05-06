using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMulticloudExternalLocationMappingMetadata
{
    [JsiiClass(nativeType: typeof(oci.DataOciMulticloudExternalLocationMappingMetadata.DataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciMulticloudExternalLocationMappingMetadata.DataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "externalLocation", typeJson: "{\"fqn\":\"oci.dataOciMulticloudExternalLocationMappingMetadata.DataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItemsExternalLocationList\"}")]
        public virtual oci.DataOciMulticloudExternalLocationMappingMetadata.DataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItemsExternalLocationList ExternalLocation
        {
            get => GetInstanceProperty<oci.DataOciMulticloudExternalLocationMappingMetadata.DataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItemsExternalLocationList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "ociLogicalAd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciLogicalAd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociPhysicalAd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciPhysicalAd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMulticloudExternalLocationMappingMetadata.DataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciMulticloudExternalLocationMappingMetadata.IDataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMulticloudExternalLocationMappingMetadata.IDataOciMulticloudExternalLocationMappingMetadataExternalLocationMappingMetadatumSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
