using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsBrandingSetting
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_branding_setting oci_identity_domains_branding_setting}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSetting), fullyQualifiedName: "oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSetting", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingConfig\"}}]")]
    public class DataOciIdentityDomainsBrandingSetting : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_branding_setting oci_identity_domains_branding_setting} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIdentityDomainsBrandingSetting(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsBrandingSetting.IDataOciIdentityDomainsBrandingSettingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsBrandingSetting.IDataOciIdentityDomainsBrandingSettingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsBrandingSetting(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsBrandingSetting(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIdentityDomainsBrandingSetting resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIdentityDomainsBrandingSetting to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIdentityDomainsBrandingSetting that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIdentityDomainsBrandingSetting to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIdentityDomainsBrandingSetting to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_branding_setting#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIdentityDomainsBrandingSetting that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIdentityDomainsBrandingSetting to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSetting), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAttributes")]
        public virtual void ResetAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttributeSets")]
        public virtual void ResetAttributeSets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeSchemaVersion")]
        public virtual void ResetResourceTypeSchemaVersion()
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
        = GetStaticProperty<string>(typeof(oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSetting))!;

        [JsiiProperty(name: "companyNames", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingCompanyNamesList\"}")]
        public virtual oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingCompanyNamesList CompanyNames
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingCompanyNamesList>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customBranding", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CustomBranding
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "customCssLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomCssLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customHtmlLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomHtmlLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customTranslation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomTranslation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultCompanyNames", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingDefaultCompanyNamesList\"}")]
        public virtual oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingDefaultCompanyNamesList DefaultCompanyNames
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingDefaultCompanyNamesList>()!;
        }

        [JsiiProperty(name: "defaultImages", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingDefaultImagesList\"}")]
        public virtual oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingDefaultImagesList DefaultImages
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingDefaultImagesList>()!;
        }

        [JsiiProperty(name: "defaultLoginTexts", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingDefaultLoginTextsList\"}")]
        public virtual oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingDefaultLoginTextsList DefaultLoginTexts
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingDefaultLoginTextsList>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableTermsOfUse", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableTermsOfUse
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "images", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingImagesList\"}")]
        public virtual oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingImagesList Images
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingImagesList>()!;
        }

        [JsiiProperty(name: "isHostedPage", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHostedPage
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loginTexts", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingLoginTextsList\"}")]
        public virtual oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingLoginTextsList LoginTexts
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingLoginTextsList>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingMetaList>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredLanguage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privacyPolicyUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivacyPolicyUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsBrandingSetting.DataOciIdentityDomainsBrandingSettingTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "termsOfUseUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TermsOfUseUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeSetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AttributeSetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "brandingSettingIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BrandingSettingIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsEndpointInput
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
        [JsiiProperty(name: "resourceTypeSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "brandingSettingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrandingSettingId
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

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
