using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsAuthenticationFactorSettings
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "authenticationFactorSettingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationFactorSettingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoEnrollEmailFactorDisabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AutoEnrollEmailFactorDisabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "bypassCodeEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BypassCodeEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "bypassCodeSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsBypassCodeSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsBypassCodeSettingsList BypassCodeSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsBypassCodeSettingsList>()!;
        }

        [JsiiProperty(name: "clientAppSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsClientAppSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsClientAppSettingsList ClientAppSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsClientAppSettingsList>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compliancePolicy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsCompliancePolicyList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsCompliancePolicyList CompliancePolicy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsCompliancePolicyList>()!;
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

        [JsiiProperty(name: "emailEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EmailEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "emailSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsEmailSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsEmailSettingsList EmailSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsEmailSettingsList>()!;
        }

        [JsiiProperty(name: "endpointRestrictions", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsEndpointRestrictionsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsEndpointRestrictionsList EndpointRestrictions
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsEndpointRestrictionsList>()!;
        }

        [JsiiProperty(name: "fidoAuthenticatorEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FidoAuthenticatorEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "hideBackupFactorEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HideBackupFactorEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "identityStoreSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsIdentityStoreSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsIdentityStoreSettingsList IdentityStoreSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsIdentityStoreSettingsList>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsMetaList>()!;
        }

        [JsiiProperty(name: "mfaEnabledCategory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MfaEnabledCategory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mfaEnrollmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MfaEnrollmentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsNotificationSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsNotificationSettingsList NotificationSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsNotificationSettingsList>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phoneCallEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PhoneCallEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "pushEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PushEnabled
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

        [JsiiProperty(name: "securityQuestionsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SecurityQuestionsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "smsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SmsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "thirdPartyFactor", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsThirdPartyFactorList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsThirdPartyFactorList ThirdPartyFactor
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsThirdPartyFactorList>()!;
        }

        [JsiiProperty(name: "totpEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable TotpEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "totpSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsTotpSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsTotpSettingsList TotpSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsTotpSettingsList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsList UrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettingsList UrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettingsList>()!;
        }

        [JsiiProperty(name: "userEnrollmentDisabledFactors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UserEnrollmentDisabledFactors
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "yubicoOtpEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable YubicoOtpEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettings\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.IDataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.IDataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
