using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMarketplaceListings
{
    [JsiiClass(nativeType: typeof(oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsOutputReference), fullyQualifiedName: "oci.dataOciMarketplaceListings.DataOciMarketplaceListingsListingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMarketplaceListingsListingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMarketplaceListingsListingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMarketplaceListingsListingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMarketplaceListingsListingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "banner", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListings.DataOciMarketplaceListingsListingsBannerList\"}")]
        public virtual oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsBannerList Banner
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsBannerList>()!;
        }

        [JsiiProperty(name: "categories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Categories
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "compatibleArchitectures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CompatibleArchitectures
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "defaultPackageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultPackageVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "documentationLinks", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListings.DataOciMarketplaceListingsListingsDocumentationLinksList\"}")]
        public virtual oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsDocumentationLinksList DocumentationLinks
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsDocumentationLinksList>()!;
        }

        [JsiiProperty(name: "icon", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListings.DataOciMarketplaceListingsListingsIconList\"}")]
        public virtual oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsIconList Icon
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsIconList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isFeatured", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFeatured
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "listingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListingType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pricingTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PricingTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "publisher", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListings.DataOciMarketplaceListingsListingsPublisherList\"}")]
        public virtual oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsPublisherList Publisher
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsPublisherList>()!;
        }

        [JsiiProperty(name: "regions", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListings.DataOciMarketplaceListingsListingsRegionsList\"}")]
        public virtual oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsRegionsList Regions
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsRegionsList>()!;
        }

        [JsiiProperty(name: "shortDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportedOperatingSystems", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListings.DataOciMarketplaceListingsListingsSupportedOperatingSystemsList\"}")]
        public virtual oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsSupportedOperatingSystemsList SupportedOperatingSystems
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListings.DataOciMarketplaceListingsListingsSupportedOperatingSystemsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListings.DataOciMarketplaceListingsListings\"}", isOptional: true)]
        public virtual oci.DataOciMarketplaceListings.IDataOciMarketplaceListingsListings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListings.IDataOciMarketplaceListingsListings?>();
            set => SetInstanceProperty(value);
        }
    }
}
