using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreAppCatalogListings
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreAppCatalogListings.DataOciCoreAppCatalogListingsAppCatalogListingsOutputReference), fullyQualifiedName: "oci.dataOciCoreAppCatalogListings.DataOciCoreAppCatalogListingsAppCatalogListingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreAppCatalogListingsAppCatalogListingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreAppCatalogListingsAppCatalogListingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreAppCatalogListingsAppCatalogListingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreAppCatalogListingsAppCatalogListingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "contactUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContactUrl
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "listingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publisherLogoUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublisherLogoUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publisherName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublisherName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Summary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePublished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePublished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreAppCatalogListings.DataOciCoreAppCatalogListingsAppCatalogListings\"}", isOptional: true)]
        public virtual oci.DataOciCoreAppCatalogListings.IDataOciCoreAppCatalogListingsAppCatalogListings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreAppCatalogListings.IDataOciCoreAppCatalogListingsAppCatalogListings?>();
            set => SetInstanceProperty(value);
        }
    }
}
