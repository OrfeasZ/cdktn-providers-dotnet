using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsSelfRegistrationProfiles
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activationEmailRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ActivationEmailRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "active", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Active
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "afterSubmitText", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesAfterSubmitTextList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesAfterSubmitTextList AfterSubmitText
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesAfterSubmitTextList>()!;
        }

        [JsiiProperty(name: "allowedEmailDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedEmailDomains
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

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consentText", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesConsentTextList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesConsentTextList ConsentText
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesConsentTextList>()!;
        }

        [JsiiProperty(name: "consentTextPresent", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ConsentTextPresent
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "defaultGroups", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesDefaultGroupsList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesDefaultGroupsList DefaultGroups
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesDefaultGroupsList>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "disallowedEmailDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DisallowedEmailDomains
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesDisplayNameList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesDisplayNameList DisplayName
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesDisplayNameList>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emailTemplate", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesEmailTemplateList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesEmailTemplateList EmailTemplate
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesEmailTemplateList>()!;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "footerLogo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FooterLogo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "footerText", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesFooterTextList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesFooterTextList FooterText
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesFooterTextList>()!;
        }

        [JsiiProperty(name: "headerLogo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeaderLogo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "headerText", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesHeaderTextList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesHeaderTextList HeaderText
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesHeaderTextList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesMetaList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numberOfDaysRedirectUrlIsValid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfDaysRedirectUrlIsValid
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectUrl
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "showOnLoginPage", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShowOnLoginPage
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userAttributes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesUserAttributesList\"}")]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesUserAttributesList UserAttributes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfilesUserAttributesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSelfRegistrationProfiles.DataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfiles\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsSelfRegistrationProfiles.IDataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfiles? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSelfRegistrationProfiles.IDataOciIdentityDomainsSelfRegistrationProfilesSelfRegistrationProfiles?>();
            set => SetInstanceProperty(value);
        }
    }
}
