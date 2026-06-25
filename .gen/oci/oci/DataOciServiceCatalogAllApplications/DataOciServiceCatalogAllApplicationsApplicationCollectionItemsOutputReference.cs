using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciServiceCatalogAllApplications
{
    [JsiiClass(nativeType: typeof(oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciServiceCatalogAllApplicationsApplicationCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciServiceCatalogAllApplicationsApplicationCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciServiceCatalogAllApplicationsApplicationCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciServiceCatalogAllApplicationsApplicationCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "categories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Categories
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isFeatured", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFeatured
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logo", typeJson: "{\"fqn\":\"oci.dataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionItemsLogoList\"}")]
        public virtual oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionItemsLogoList Logo
        {
            get => GetInstanceProperty<oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionItemsLogoList>()!;
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pricingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PricingType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publisher", typeJson: "{\"fqn\":\"oci.dataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionItemsPublisherList\"}")]
        public virtual oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionItemsPublisherList Publisher
        {
            get => GetInstanceProperty<oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionItemsPublisherList>()!;
        }

        [JsiiProperty(name: "shortDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciServiceCatalogAllApplications.IDataOciServiceCatalogAllApplicationsApplicationCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciServiceCatalogAllApplications.IDataOciServiceCatalogAllApplicationsApplicationCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
