using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadServicePrincipal
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/service_principal azuread_service_principal}.</summary>
    [JsiiClass(nativeType: typeof(azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipal), fullyQualifiedName: "azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipal", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipalConfig\"}}]")]
    public class DataAzureadServicePrincipal : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/service_principal azuread_service_principal} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzureadServicePrincipal(Constructs.Construct scope, string id, azuread.DataAzureadServicePrincipal.IDataAzureadServicePrincipalConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.DataAzureadServicePrincipal.IDataAzureadServicePrincipalConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadServicePrincipal(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadServicePrincipal(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzureadServicePrincipal resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzureadServicePrincipal to import.</param>
        /// <param name="importFromId">The id of the existing DataAzureadServicePrincipal that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzureadServicePrincipal to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzureadServicePrincipal to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/service_principal#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzureadServicePrincipal that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzureadServicePrincipal to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipal), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipalTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.DataAzureadServicePrincipal.IDataAzureadServicePrincipalTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.DataAzureadServicePrincipal.IDataAzureadServicePrincipalTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipal))!;

        [JsiiProperty(name: "accountEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AccountEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "alternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AlternativeNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "applicationTenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationTenantId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "appRoleAssignmentRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AppRoleAssignmentRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "appRoleIds", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AppRoleIds
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "appRoles", typeJson: "{\"fqn\":\"azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipalAppRolesList\"}")]
        public virtual azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalAppRolesList AppRoles
        {
            get => GetInstanceProperty<azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalAppRolesList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipalFeaturesList\"}")]
        public virtual azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalFeaturesList Features
        {
            get => GetInstanceProperty<azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalFeaturesList>()!;
        }

        [JsiiProperty(name: "featureTags", typeJson: "{\"fqn\":\"azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipalFeatureTagsList\"}")]
        public virtual azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalFeatureTagsList FeatureTags
        {
            get => GetInstanceProperty<azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalFeatureTagsList>()!;
        }

        [JsiiProperty(name: "homepageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomepageUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loginUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoginUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoutUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Notes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationEmailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NotificationEmailAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "oauth2PermissionScopeIds", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Oauth2PermissionScopeIds
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "oauth2PermissionScopes", typeJson: "{\"fqn\":\"azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipalOauth2PermissionScopesList\"}")]
        public virtual azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalOauth2PermissionScopesList Oauth2PermissionScopes
        {
            get => GetInstanceProperty<azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalOauth2PermissionScopesList>()!;
        }

        [JsiiProperty(name: "preferredSingleSignOnMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredSingleSignOnMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "samlMetadataUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SamlMetadataUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "samlSingleSignOn", typeJson: "{\"fqn\":\"azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipalSamlSingleSignOnList\"}")]
        public virtual azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalSamlSingleSignOnList SamlSingleSignOn
        {
            get => GetInstanceProperty<azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalSamlSingleSignOnList>()!;
        }

        [JsiiProperty(name: "servicePrincipalNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ServicePrincipalNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "signInAudience", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignInAudience
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipalTimeoutsOutputReference\"}")]
        public virtual azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.DataAzureadServicePrincipal.DataAzureadServicePrincipalTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.DataAzureadServicePrincipal.IDataAzureadServicePrincipalTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipalTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
