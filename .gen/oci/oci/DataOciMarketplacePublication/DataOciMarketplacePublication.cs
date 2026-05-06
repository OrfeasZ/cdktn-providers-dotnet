using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMarketplacePublication
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/marketplace_publication oci_marketplace_publication}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciMarketplacePublication.DataOciMarketplacePublication), fullyQualifiedName: "oci.dataOciMarketplacePublication.DataOciMarketplacePublication", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciMarketplacePublication.DataOciMarketplacePublicationConfig\"}}]")]
    public class DataOciMarketplacePublication : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/marketplace_publication oci_marketplace_publication} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciMarketplacePublication(Constructs.Construct scope, string id, oci.DataOciMarketplacePublication.IDataOciMarketplacePublicationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciMarketplacePublication.IDataOciMarketplacePublicationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMarketplacePublication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMarketplacePublication(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciMarketplacePublication resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciMarketplacePublication to import.</param>
        /// <param name="importFromId">The id of the existing DataOciMarketplacePublication that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciMarketplacePublication to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciMarketplacePublication to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/marketplace_publication#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciMarketplacePublication that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciMarketplacePublication to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciMarketplacePublication.DataOciMarketplacePublication), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciMarketplacePublication.DataOciMarketplacePublication))!;

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

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "icon", typeJson: "{\"fqn\":\"oci.dataOciMarketplacePublication.DataOciMarketplacePublicationIconList\"}")]
        public virtual oci.DataOciMarketplacePublication.DataOciMarketplacePublicationIconList Icon
        {
            get => GetInstanceProperty<oci.DataOciMarketplacePublication.DataOciMarketplacePublicationIconList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAgreementAcknowledged", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAgreementAcknowledged
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "packageDetails", typeJson: "{\"fqn\":\"oci.dataOciMarketplacePublication.DataOciMarketplacePublicationPackageDetailsList\"}")]
        public virtual oci.DataOciMarketplacePublication.DataOciMarketplacePublicationPackageDetailsList PackageDetails
        {
            get => GetInstanceProperty<oci.DataOciMarketplacePublication.DataOciMarketplacePublicationPackageDetailsList>()!;
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shortDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportContacts", typeJson: "{\"fqn\":\"oci.dataOciMarketplacePublication.DataOciMarketplacePublicationSupportContactsList\"}")]
        public virtual oci.DataOciMarketplacePublication.DataOciMarketplacePublicationSupportContactsList SupportContacts
        {
            get => GetInstanceProperty<oci.DataOciMarketplacePublication.DataOciMarketplacePublicationSupportContactsList>()!;
        }

        [JsiiProperty(name: "supportedOperatingSystems", typeJson: "{\"fqn\":\"oci.dataOciMarketplacePublication.DataOciMarketplacePublicationSupportedOperatingSystemsList\"}")]
        public virtual oci.DataOciMarketplacePublication.DataOciMarketplacePublicationSupportedOperatingSystemsList SupportedOperatingSystems
        {
            get => GetInstanceProperty<oci.DataOciMarketplacePublication.DataOciMarketplacePublicationSupportedOperatingSystemsList>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "publicationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "publicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
