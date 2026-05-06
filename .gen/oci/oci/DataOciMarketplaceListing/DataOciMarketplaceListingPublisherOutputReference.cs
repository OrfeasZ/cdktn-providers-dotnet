using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMarketplaceListing
{
    [JsiiClass(nativeType: typeof(oci.DataOciMarketplaceListing.DataOciMarketplaceListingPublisherOutputReference), fullyQualifiedName: "oci.dataOciMarketplaceListing.DataOciMarketplaceListingPublisherOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMarketplaceListingPublisherOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMarketplaceListingPublisherOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMarketplaceListingPublisherOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMarketplaceListingPublisherOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "contactEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContactEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contactPhone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContactPhone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hqAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HqAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "links", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingPublisherLinksList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingPublisherLinksList Links
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingPublisherLinksList>()!;
        }

        [JsiiProperty(name: "logo", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingPublisherLogoList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingPublisherLogoList Logo
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingPublisherLogoList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "websiteUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebsiteUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "yearFounded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string YearFounded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingPublisher\"}", isOptional: true)]
        public virtual oci.DataOciMarketplaceListing.IDataOciMarketplaceListingPublisher? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.IDataOciMarketplaceListingPublisher?>();
            set => SetInstanceProperty(value);
        }
    }
}
