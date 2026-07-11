using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadApplication
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/application azuread_application}.</summary>
    [JsiiClass(nativeType: typeof(azuread.DataAzureadApplication.DataAzureadApplication), fullyQualifiedName: "azuread.dataAzureadApplication.DataAzureadApplication", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationConfig\"}}]")]
    public class DataAzureadApplication : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/application azuread_application} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzureadApplication(Constructs.Construct scope, string id, azuread.DataAzureadApplication.IDataAzureadApplicationConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.DataAzureadApplication.IDataAzureadApplicationConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadApplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadApplication(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzureadApplication resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzureadApplication to import.</param>
        /// <param name="importFromId">The id of the existing DataAzureadApplication that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzureadApplication to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzureadApplication to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/application#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzureadApplication that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzureadApplication to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.DataAzureadApplication.DataAzureadApplication), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.DataAzureadApplication.IDataAzureadApplicationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.DataAzureadApplication.IDataAzureadApplicationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientId")]
        public virtual void ResetClientId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentifierUri")]
        public virtual void ResetIdentifierUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectId")]
        public virtual void ResetObjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azuread.DataAzureadApplication.DataAzureadApplication))!;

        [JsiiProperty(name: "api", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationApiList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationApiList Api
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationApiList>()!;
        }

        [JsiiProperty(name: "appRoleIds", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AppRoleIds
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "appRoles", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationAppRolesList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationAppRolesList AppRoles
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationAppRolesList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceOnlyAuthEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeviceOnlyAuthEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "disabledByMicrosoft", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisabledByMicrosoft
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fallbackPublicClientEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FallbackPublicClientEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "featureTags", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationFeatureTagsList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationFeatureTagsList FeatureTags
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationFeatureTagsList>()!;
        }

        [JsiiProperty(name: "groupMembershipClaims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GroupMembershipClaims
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "identifierUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdentifierUris
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "logoUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "marketingUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MarketingUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Notes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oauth2PermissionScopeIds", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Oauth2PermissionScopeIds
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "oauth2PostResponseRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Oauth2PostResponseRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "optionalClaims", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationOptionalClaimsList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationOptionalClaimsList OptionalClaims
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationOptionalClaimsList>()!;
        }

        [JsiiProperty(name: "owners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Owners
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "privacyStatementUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivacyStatementUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicClient", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationPublicClientList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationPublicClientList PublicClient
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationPublicClientList>()!;
        }

        [JsiiProperty(name: "publisherDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublisherDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requiredResourceAccess", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationRequiredResourceAccessList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationRequiredResourceAccessList RequiredResourceAccess
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationRequiredResourceAccessList>()!;
        }

        [JsiiProperty(name: "serviceManagementReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceManagementReference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signInAudience", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignInAudience
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "singlePageApplication", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationSinglePageApplicationList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationSinglePageApplicationList SinglePageApplication
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationSinglePageApplicationList>()!;
        }

        [JsiiProperty(name: "supportUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TermsOfServiceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationTimeoutsOutputReference\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "web", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationWebList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationWebList Web
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationWebList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identifierUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentifierUriInput
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
        [JsiiProperty(name: "objectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.DataAzureadApplication.IDataAzureadApplicationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "identifierUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentifierUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
