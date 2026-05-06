using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsSetting
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_setting oci_identity_domains_setting}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSetting), fullyQualifiedName: "oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSetting", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingConfig\"}}]")]
    public class DataOciIdentityDomainsSetting : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_setting oci_identity_domains_setting} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIdentityDomainsSetting(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsSetting.IDataOciIdentityDomainsSettingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsSetting.IDataOciIdentityDomainsSettingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsSetting(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsSetting(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIdentityDomainsSetting resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIdentityDomainsSetting to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIdentityDomainsSetting that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIdentityDomainsSetting to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIdentityDomainsSetting to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_setting#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIdentityDomainsSetting that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIdentityDomainsSetting to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSetting), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSetting))!;

        [JsiiProperty(name: "accountAlwaysTrustScope", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AccountAlwaysTrustScope
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "allowedDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedDomains
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowedForgotPasswordFlowReturnUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedForgotPasswordFlowReturnUrls
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowedNotificationRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedNotificationRedirectUrls
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "auditEventRetentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AuditEventRetentionPeriod
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "certificateValidation", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingCertificateValidationList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingCertificateValidationList CertificateValidation
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingCertificateValidationList>()!;
        }

        [JsiiProperty(name: "cloudAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudAccountName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudGateCorsSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingCloudGateCorsSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingCloudGateCorsSettingsList CloudGateCorsSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingCloudGateCorsSettingsList>()!;
        }

        [JsiiProperty(name: "cloudMigrationCustomUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudMigrationCustomUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudMigrationUrlEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CloudMigrationUrlEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "companyNames", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingCompanyNamesList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingCompanyNamesList CompanyNames
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingCompanyNamesList>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contactEmails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ContactEmails
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "csrAccess", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsrAccess
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

        [JsiiProperty(name: "defaultCompanyNames", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingDefaultCompanyNamesList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingDefaultCompanyNamesList DefaultCompanyNames
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingDefaultCompanyNamesList>()!;
        }

        [JsiiProperty(name: "defaultImages", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingDefaultImagesList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingDefaultImagesList DefaultImages
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingDefaultImagesList>()!;
        }

        [JsiiProperty(name: "defaultLoginTexts", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingDefaultLoginTextsList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingDefaultLoginTextsList DefaultLoginTexts
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingDefaultLoginTextsList>()!;
        }

        [JsiiProperty(name: "defaultTrustScope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultTrustScope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "diagnosticLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DiagnosticLevel
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "diagnosticRecordForSearchIdentifiesReturnedResources", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DiagnosticRecordForSearchIdentifiesReturnedResources
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "diagnosticTracingUpto", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiagnosticTracingUpto
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "iamUpstSessionExpiry", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IamUpstSessionExpiry
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "images", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingImagesList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingImagesList Images
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingImagesList>()!;
        }

        [JsiiProperty(name: "isHostedPage", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHostedPage
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loginTexts", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingLoginTextsList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingLoginTextsList LoginTexts
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingLoginTextsList>()!;
        }

        [JsiiProperty(name: "maxNoOfAppCmvaToReturn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxNoOfAppCmvaToReturn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxNoOfAppRoleMembersToReturn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxNoOfAppRoleMembersToReturn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingMetaList>()!;
        }

        [JsiiProperty(name: "migrationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onPremisesProvisioning", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable OnPremisesProvisioning
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredLanguage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "prevIssuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrevIssuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privacyPolicyUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivacyPolicyUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "purgeConfigs", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingPurgeConfigsList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingPurgeConfigsList PurgeConfigs
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingPurgeConfigsList>()!;
        }

        [JsiiProperty(name: "reAuthFactor", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReAuthFactor
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "reAuthWhenChangingMyAuthenticationFactors", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReAuthWhenChangingMyAuthenticationFactors
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "serviceAdminCannotListOtherUsers", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ServiceAdminCannotListOtherUsers
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "signingCertPublicAccess", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SigningCertPublicAccess
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "subMappingAttr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubMappingAttr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenantCustomClaims", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingTenantCustomClaimsList\"}")]
        public virtual oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingTenantCustomClaimsList TenantCustomClaims
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSetting.DataOciIdentityDomainsSettingTenantCustomClaimsList>()!;
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
        [JsiiProperty(name: "idcsEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "settingIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SettingIdInput
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

        [JsiiProperty(name: "settingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SettingId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
