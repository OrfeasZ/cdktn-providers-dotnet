using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMarketplaceListing
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/marketplace_listing oci_marketplace_listing}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciMarketplaceListing.DataOciMarketplaceListing), fullyQualifiedName: "oci.dataOciMarketplaceListing.DataOciMarketplaceListing", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingConfig\"}}]")]
    public class DataOciMarketplaceListing : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/marketplace_listing oci_marketplace_listing} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciMarketplaceListing(Constructs.Construct scope, string id, oci.DataOciMarketplaceListing.IDataOciMarketplaceListingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciMarketplaceListing.IDataOciMarketplaceListingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMarketplaceListing(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMarketplaceListing(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciMarketplaceListing resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciMarketplaceListing to import.</param>
        /// <param name="importFromId">The id of the existing DataOciMarketplaceListing that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciMarketplaceListing to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciMarketplaceListing to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/marketplace_listing#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciMarketplaceListing that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciMarketplaceListing to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciMarketplaceListing.DataOciMarketplaceListing), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciMarketplaceListing.DataOciMarketplaceListing))!;

        [JsiiProperty(name: "banner", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingBannerList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingBannerList Banner
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingBannerList>()!;
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

        [JsiiProperty(name: "documentationLinks", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingDocumentationLinksList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingDocumentationLinksList DocumentationLinks
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingDocumentationLinksList>()!;
        }

        [JsiiProperty(name: "icon", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingIconList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingIconList Icon
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingIconList>()!;
        }

        [JsiiProperty(name: "isFeatured", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFeatured
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "keywords", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Keywords
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "languages", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingLanguagesList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingLanguagesList Languages
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingLanguagesList>()!;
        }

        [JsiiProperty(name: "licenseModelDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModelDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "links", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingLinksList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingLinksList Links
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingLinksList>()!;
        }

        [JsiiProperty(name: "listingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListingType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "longDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LongDescription
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

        [JsiiProperty(name: "publisher", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingPublisherList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingPublisherList Publisher
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingPublisherList>()!;
        }

        [JsiiProperty(name: "regions", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingRegionsList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingRegionsList Regions
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingRegionsList>()!;
        }

        [JsiiProperty(name: "releaseNotes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseNotes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "screenshots", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingScreenshotsList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingScreenshotsList Screenshots
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingScreenshotsList>()!;
        }

        [JsiiProperty(name: "shortDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportContacts", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingSupportContactsList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingSupportContactsList SupportContacts
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingSupportContactsList>()!;
        }

        [JsiiProperty(name: "supportedOperatingSystems", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingSupportedOperatingSystemsList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingSupportedOperatingSystemsList SupportedOperatingSystems
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingSupportedOperatingSystemsList>()!;
        }

        [JsiiProperty(name: "supportLinks", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingSupportLinksList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingSupportLinksList SupportLinks
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingSupportLinksList>()!;
        }

        [JsiiProperty(name: "systemRequirements", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemRequirements
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tagline", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tagline
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeReleased", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeReleased
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usageInformation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageInformation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "videos", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceListing.DataOciMarketplaceListingVideosList\"}")]
        public virtual oci.DataOciMarketplaceListing.DataOciMarketplaceListingVideosList Videos
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceListing.DataOciMarketplaceListingVideosList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "listingIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ListingIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "listingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListingId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
