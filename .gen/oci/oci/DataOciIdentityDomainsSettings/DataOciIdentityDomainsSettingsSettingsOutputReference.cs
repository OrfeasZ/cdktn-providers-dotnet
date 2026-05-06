using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsSettings
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsSettingsSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsSettingsSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsSettingsSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsSettingsSettingsOutputReference(DeputyProps props): base(props)
        {
        }

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

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "auditEventRetentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AuditEventRetentionPeriod
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateValidation", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsCertificateValidationList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsCertificateValidationList CertificateValidation
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsCertificateValidationList>()!;
        }

        [JsiiProperty(name: "cloudAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudAccountName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudGateCorsSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsCloudGateCorsSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsCloudGateCorsSettingsList CloudGateCorsSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsCloudGateCorsSettingsList>()!;
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

        [JsiiProperty(name: "companyNames", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsCompanyNamesList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsCompanyNamesList CompanyNames
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsCompanyNamesList>()!;
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

        [JsiiProperty(name: "defaultCompanyNames", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsDefaultCompanyNamesList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsDefaultCompanyNamesList DefaultCompanyNames
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsDefaultCompanyNamesList>()!;
        }

        [JsiiProperty(name: "defaultImages", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsDefaultImagesList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsDefaultImagesList DefaultImages
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsDefaultImagesList>()!;
        }

        [JsiiProperty(name: "defaultLoginTexts", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsDefaultLoginTextsList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsDefaultLoginTextsList DefaultLoginTexts
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsDefaultLoginTextsList>()!;
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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "images", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsImagesList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsImagesList Images
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsImagesList>()!;
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

        [JsiiProperty(name: "loginTexts", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsLoginTextsList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsLoginTextsList LoginTexts
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsLoginTextsList>()!;
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

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsMetaList>()!;
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

        [JsiiProperty(name: "purgeConfigs", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsPurgeConfigsList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsPurgeConfigsList PurgeConfigs
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsPurgeConfigsList>()!;
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

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "settingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SettingId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenantCustomClaims", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsTenantCustomClaimsList\"}")]
        public virtual oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsTenantCustomClaimsList TenantCustomClaims
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettingsTenantCustomClaimsList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSettings.DataOciIdentityDomainsSettingsSettings\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsSettings.IDataOciIdentityDomainsSettingsSettings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSettings.IDataOciIdentityDomainsSettingsSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
