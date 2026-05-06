using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsAuthenticationFactorSetting
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_authentication_factor_setting oci_identity_domains_authentication_factor_setting}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSetting), fullyQualifiedName: "oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSetting", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingConfig\"}}]")]
    public class DataOciIdentityDomainsAuthenticationFactorSetting : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_authentication_factor_setting oci_identity_domains_authentication_factor_setting} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIdentityDomainsAuthenticationFactorSetting(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsAuthenticationFactorSetting.IDataOciIdentityDomainsAuthenticationFactorSettingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsAuthenticationFactorSetting.IDataOciIdentityDomainsAuthenticationFactorSettingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAuthenticationFactorSetting(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAuthenticationFactorSetting(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIdentityDomainsAuthenticationFactorSetting resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIdentityDomainsAuthenticationFactorSetting to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIdentityDomainsAuthenticationFactorSetting that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIdentityDomainsAuthenticationFactorSetting to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIdentityDomainsAuthenticationFactorSetting to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_authentication_factor_setting#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIdentityDomainsAuthenticationFactorSetting that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIdentityDomainsAuthenticationFactorSetting to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSetting), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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

        [JsiiMethod(name: "resetAuthenticationFactorSettingId")]
        public virtual void ResetAuthenticationFactorSettingId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSetting))!;

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

        [JsiiProperty(name: "bypassCodeSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingBypassCodeSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingBypassCodeSettingsList BypassCodeSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingBypassCodeSettingsList>()!;
        }

        [JsiiProperty(name: "clientAppSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingClientAppSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingClientAppSettingsList ClientAppSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingClientAppSettingsList>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compliancePolicy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingCompliancePolicyList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingCompliancePolicyList CompliancePolicy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingCompliancePolicyList>()!;
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

        [JsiiProperty(name: "emailSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingEmailSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingEmailSettingsList EmailSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingEmailSettingsList>()!;
        }

        [JsiiProperty(name: "endpointRestrictions", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingEndpointRestrictionsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingEndpointRestrictionsList EndpointRestrictions
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingEndpointRestrictionsList>()!;
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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "identityStoreSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingIdentityStoreSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingIdentityStoreSettingsList IdentityStoreSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingIdentityStoreSettingsList>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingMetaList>()!;
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

        [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingNotificationSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingNotificationSettingsList NotificationSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingNotificationSettingsList>()!;
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "thirdPartyFactor", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingThirdPartyFactorList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingThirdPartyFactorList ThirdPartyFactor
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingThirdPartyFactorList>()!;
        }

        [JsiiProperty(name: "totpEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable TotpEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "totpSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingTotpSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingTotpSettingsList TotpSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingTotpSettingsList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsList UrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettingsList UrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettingsList>()!;
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
        [JsiiProperty(name: "authenticationFactorSettingIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthenticationFactorSettingIdInput
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

        [JsiiProperty(name: "authenticationFactorSettingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationFactorSettingId
        {
            get => GetInstanceProperty<string>()!;
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
    }
}
