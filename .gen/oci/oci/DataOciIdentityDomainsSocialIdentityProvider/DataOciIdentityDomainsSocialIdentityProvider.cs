using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsSocialIdentityProvider
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_social_identity_provider oci_identity_domains_social_identity_provider}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProvider), fullyQualifiedName: "oci.dataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProvider", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderConfig\"}}]")]
    public class DataOciIdentityDomainsSocialIdentityProvider : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_social_identity_provider oci_identity_domains_social_identity_provider} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIdentityDomainsSocialIdentityProvider(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsSocialIdentityProvider.IDataOciIdentityDomainsSocialIdentityProviderConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsSocialIdentityProvider.IDataOciIdentityDomainsSocialIdentityProviderConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsSocialIdentityProvider(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsSocialIdentityProvider(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIdentityDomainsSocialIdentityProvider resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIdentityDomainsSocialIdentityProvider to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIdentityDomainsSocialIdentityProvider that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIdentityDomainsSocialIdentityProvider to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIdentityDomainsSocialIdentityProvider to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_social_identity_provider#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIdentityDomainsSocialIdentityProvider that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIdentityDomainsSocialIdentityProvider to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProvider), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProvider))!;

        [JsiiProperty(name: "accessTokenUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessTokenUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountLinkingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AccountLinkingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "adminScope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdminScope
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "authzUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthzUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoRedirectEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AutoRedirectEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clientCredentialInPayload", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ClientCredentialInPayload
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clockSkewInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClockSkewInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerSecret
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "discoveryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiscoveryUrl
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

        [JsiiProperty(name: "idAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "jitProvAssignedGroups", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderJitProvAssignedGroupsList\"}")]
        public virtual oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderJitProvAssignedGroupsList JitProvAssignedGroups
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderJitProvAssignedGroupsList>()!;
        }

        [JsiiProperty(name: "jitProvGroupStaticListEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable JitProvGroupStaticListEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderMetaList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profileUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshTokenUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshTokenUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "registrationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RegistrationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "relayIdpParamMappings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderRelayIdpParamMappingsList\"}")]
        public virtual oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderRelayIdpParamMappingsList RelayIdpParamMappings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderRelayIdpParamMappingsList>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scope
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "serviceProviderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceProviderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "showOnLogin", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShowOnLogin
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "socialJitProvisioningEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SocialJitProvisioningEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSocialIdentityProvider.DataOciIdentityDomainsSocialIdentityProviderTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
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
        [JsiiProperty(name: "socialIdentityProviderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SocialIdentityProviderIdInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "socialIdentityProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SocialIdentityProviderId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
