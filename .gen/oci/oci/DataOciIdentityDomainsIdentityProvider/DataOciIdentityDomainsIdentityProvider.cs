using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsIdentityProvider
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_identity_provider oci_identity_domains_identity_provider}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProvider), fullyQualifiedName: "oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProvider", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderConfig\"}}]")]
    public class DataOciIdentityDomainsIdentityProvider : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_identity_provider oci_identity_domains_identity_provider} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIdentityDomainsIdentityProvider(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsIdentityProvider.IDataOciIdentityDomainsIdentityProviderConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsIdentityProvider.IDataOciIdentityDomainsIdentityProviderConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsIdentityProvider(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsIdentityProvider(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIdentityDomainsIdentityProvider resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIdentityDomainsIdentityProvider to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIdentityDomainsIdentityProvider that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIdentityDomainsIdentityProvider to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIdentityDomainsIdentityProvider to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_identity_provider#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIdentityDomainsIdentityProvider that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIdentityDomainsIdentityProvider to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProvider), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProvider))!;

        [JsiiProperty(name: "assertionAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssertionAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authnRequestBinding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthnRequestBinding
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "correlationPolicy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderCorrelationPolicyList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderCorrelationPolicyList CorrelationPolicy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderCorrelationPolicyList>()!;
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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "jitUserProvAssignedGroups", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderJitUserProvAssignedGroupsList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderJitUserProvAssignedGroupsList JitUserProvAssignedGroups
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderJitUserProvAssignedGroupsList>()!;
        }

        [JsiiProperty(name: "jitUserProvAttributes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderJitUserProvAttributesList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderJitUserProvAttributesList JitUserProvAttributes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderJitUserProvAttributesList>()!;
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

        [JsiiProperty(name: "jitUserProvGroupMappings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderJitUserProvGroupMappingsList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderJitUserProvGroupMappingsList JitUserProvGroupMappings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderJitUserProvGroupMappingsList>()!;
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

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderMetaList>()!;
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderTagsList>()!;
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

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderList UrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionx509IdentityProvider", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderList Urnietfparamsscimschemasoracleidcsextensionx509IdentityProvider
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderList>()!;
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
        [JsiiProperty(name: "identityProviderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityProviderIdInput
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

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityProviderId
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
