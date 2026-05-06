using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsIdentityProviders
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsIdentityProvidersIdentityProvidersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsIdentityProvidersIdentityProvidersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsIdentityProvidersIdentityProvidersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsIdentityProvidersIdentityProvidersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "assertionAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssertionAttribute
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "authnRequestBinding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthnRequestBinding
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "correlationPolicy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersCorrelationPolicyList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersCorrelationPolicyList CorrelationPolicy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersCorrelationPolicyList>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "encryptionCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "iconUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IconUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "idpSsoUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdpSsoUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "includeSigningCertInSignature", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IncludeSigningCertInSignature
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jitUserProvAssignedGroups", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersJitUserProvAssignedGroupsList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersJitUserProvAssignedGroupsList JitUserProvAssignedGroups
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersJitUserProvAssignedGroupsList>()!;
        }

        [JsiiProperty(name: "jitUserProvAttributes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersJitUserProvAttributesList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersJitUserProvAttributesList JitUserProvAttributes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersJitUserProvAttributesList>()!;
        }

        [JsiiProperty(name: "jitUserProvAttributeUpdateEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable JitUserProvAttributeUpdateEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jitUserProvCreateUserEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable JitUserProvCreateUserEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jitUserProvEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable JitUserProvEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jitUserProvGroupAssertionAttributeEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable JitUserProvGroupAssertionAttributeEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jitUserProvGroupAssignmentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JitUserProvGroupAssignmentMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jitUserProvGroupMappingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JitUserProvGroupMappingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jitUserProvGroupMappings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersJitUserProvGroupMappingsList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersJitUserProvGroupMappingsList JitUserProvGroupMappings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersJitUserProvGroupMappingsList>()!;
        }

        [JsiiProperty(name: "jitUserProvGroupSamlAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JitUserProvGroupSamlAttributeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jitUserProvGroupStaticListEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable JitUserProvGroupStaticListEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jitUserProvIgnoreErrorOnAbsentGroups", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable JitUserProvIgnoreErrorOnAbsentGroups
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastNotificationSentTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastNotificationSentTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoutBinding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutBinding
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoutEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable LogoutEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logoutRequestUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutRequestUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoutResponseUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutResponseUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersMetaList>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Metadata
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameIdFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partnerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partnerProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerProviderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestedAuthenticationContext", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RequestedAuthenticationContext
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "requireForceAuthn", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequireForceAuthn
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "requiresEncryptedAssertion", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequiresEncryptedAssertion
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "samlHoKrequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SamlHoKrequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "serviceInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceInstanceIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shownOnLoginPage", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShownOnLoginPage
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "signatureHashAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignatureHashAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signingCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "succinctId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SuccinctId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenantProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantProviderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderList UrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionx509IdentityProvider", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderList Urnietfparamsscimschemasoracleidcsextensionx509IdentityProvider
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderList>()!;
        }

        [JsiiProperty(name: "userMappingMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserMappingMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userMappingStoreAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserMappingStoreAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProviders\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.IDataOciIdentityDomainsIdentityProvidersIdentityProviders? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.IDataOciIdentityDomainsIdentityProvidersIdentityProviders?>();
            set => SetInstanceProperty(value);
        }
    }
}
