using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsApp
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_app oci_identity_domains_app}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsApp), fullyQualifiedName: "oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsApp", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppConfig\"}}]")]
    public class DataOciIdentityDomainsApp : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_app oci_identity_domains_app} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIdentityDomainsApp(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsApp.IDataOciIdentityDomainsAppConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsApp.IDataOciIdentityDomainsAppConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsApp(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsApp(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIdentityDomainsApp resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIdentityDomainsApp to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIdentityDomainsApp that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIdentityDomainsApp to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIdentityDomainsApp to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_app#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIdentityDomainsApp that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIdentityDomainsApp to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsApp), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsApp))!;

        [JsiiProperty(name: "accessTokenExpiry", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AccessTokenExpiry
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "accounts", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppAccountsList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAccountsList Accounts
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAccountsList>()!;
        }

        [JsiiProperty(name: "active", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Active
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "adminRoles", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppAdminRolesList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAdminRolesList AdminRoles
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAdminRolesList>()!;
        }

        [JsiiProperty(name: "aliasApps", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppAliasAppsList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAliasAppsList AliasApps
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAliasAppsList>()!;
        }

        [JsiiProperty(name: "allowAccessControl", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowAccessControl
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "allowedGrants", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedGrants
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowedScopes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppAllowedScopesList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAllowedScopesList AllowedScopes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAllowedScopesList>()!;
        }

        [JsiiProperty(name: "allowedTags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppAllowedTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAllowedTagsList AllowedTags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAllowedTagsList>()!;
        }

        [JsiiProperty(name: "allowOffline", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowOffline
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "allUrlSchemesAllowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllUrlSchemesAllowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "appIcon", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppIcon
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "appSignonPolicy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppAppSignonPolicyList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAppSignonPolicyList AppSignonPolicy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAppSignonPolicyList>()!;
        }

        [JsiiProperty(name: "appsNetworkPerimeters", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppAppsNetworkPerimetersList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAppsNetworkPerimetersList AppsNetworkPerimeters
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAppsNetworkPerimetersList>()!;
        }

        [JsiiProperty(name: "appThumbnail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppThumbnail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "asOpcService", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppAsOpcServiceList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAsOpcServiceList AsOpcService
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAsOpcServiceList>()!;
        }

        [JsiiProperty(name: "attrRenderingMetadata", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppAttrRenderingMetadataList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAttrRenderingMetadataList AttrRenderingMetadata
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppAttrRenderingMetadataList>()!;
        }

        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Audience
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "basedOnTemplate", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppBasedOnTemplateList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppBasedOnTemplateList BasedOnTemplate
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppBasedOnTemplateList>()!;
        }

        [JsiiProperty(name: "bypassConsent", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BypassConsent
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "callbackServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CallbackServiceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificates", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppCertificatesList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppCertificatesList Certificates
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppCertificatesList>()!;
        }

        [JsiiProperty(name: "clientIpChecking", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientIpChecking
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudControlProperties", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppCloudControlPropertiesList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppCloudControlPropertiesList CloudControlProperties
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppCloudControlPropertiesList>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contactEmailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContactEmailAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "delegatedServiceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DelegatedServiceNames
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "disableKmsiTokenAuthentication", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DisableKmsiTokenAuthentication
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "editableAttributes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppEditableAttributesList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppEditableAttributesList EditableAttributes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppEditableAttributesList>()!;
        }

        [JsiiProperty(name: "errorPageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorPageUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "forceDelete", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ForceDelete
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "grantedAppRoles", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppGrantedAppRolesList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppGrantedAppRolesList GrantedAppRoles
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppGrantedAppRolesList>()!;
        }

        [JsiiProperty(name: "grants", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppGrantsList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppGrantsList Grants
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppGrantsList>()!;
        }

        [JsiiProperty(name: "hashedClientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashedClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "homePageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomePageUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "icon", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Icon
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "identityProviders", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdentityProvidersList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdentityProvidersList IdentityProviders
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdentityProvidersList>()!;
        }

        [JsiiProperty(name: "idpPolicy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdpPolicyList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdpPolicyList IdpPolicy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppIdpPolicyList>()!;
        }

        [JsiiProperty(name: "idTokenEncAlgo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdTokenEncAlgo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infrastructure", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Infrastructure
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isAliasApp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAliasApp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDatabaseService", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDatabaseService
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isEnterpriseApp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnterpriseApp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isFormFill", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFormFill
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isKerberosRealm", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsKerberosRealm
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLoginTarget", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLoginTarget
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isManagedApp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsManagedApp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMobileTarget", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMobileTarget
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMulticloudServiceApp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMulticloudServiceApp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isOauthClient", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOauthClient
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isOauthResource", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOauthResource
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isObligationCapable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsObligationCapable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isOpcService", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOpcService
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRadiusApp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRadiusApp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSamlServiceProvider", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSamlServiceProvider
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isUnmanagedApp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsUnmanagedApp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isWebTierPolicy", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsWebTierPolicy
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "landingPageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LandingPageUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "linkingCallbackUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LinkingCallbackUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loginMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoginMechanism
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loginPageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoginPageUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoutPageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutPageUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoutUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppMetaList>()!;
        }

        [JsiiProperty(name: "meterAsOpcService", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable MeterAsOpcService
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "migrated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Migrated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "postLogoutRedirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PostLogoutRedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "privacyPolicyUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivacyPolicyUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productLogoUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductLogoUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "protectableSecondaryAudiences", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppProtectableSecondaryAudiencesList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppProtectableSecondaryAudiencesList ProtectableSecondaryAudiences
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppProtectableSecondaryAudiencesList>()!;
        }

        [JsiiProperty(name: "radiusPolicy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppRadiusPolicyList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppRadiusPolicyList RadiusPolicy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppRadiusPolicyList>()!;
        }

        [JsiiProperty(name: "readyToUpgrade", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReadyToUpgrade
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "refreshTokenExpiry", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RefreshTokenExpiry
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "samlServiceProvider", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppSamlServiceProviderList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppSamlServiceProviderList SamlServiceProvider
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppSamlServiceProviderList>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppScopesList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppScopesList Scopes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppScopesList>()!;
        }

        [JsiiProperty(name: "secondaryAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecondaryAudiences
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "serviceParams", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppServiceParamsList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppServiceParamsList ServiceParams
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppServiceParamsList>()!;
        }

        [JsiiProperty(name: "serviceTypeUrn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceTypeUrn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceTypeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceTypeVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "showInMyApps", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShowInMyApps
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "signonPolicy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppSignonPolicyList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppSignonPolicyList SignonPolicy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppSignonPolicyList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TermsOfServiceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "termsOfUse", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppTermsOfUseList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppTermsOfUseList TermsOfUse
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppTermsOfUseList>()!;
        }

        [JsiiProperty(name: "trustPolicies", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppTrustPoliciesList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppTrustPoliciesList TrustPolicies
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppTrustPoliciesList>()!;
        }

        [JsiiProperty(name: "trustScope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustScope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbcsApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsAppList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsAppList UrnietfparamsscimschemasoracleidcsextensiondbcsApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsAppList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionenterpriseAppApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppList UrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppList UrnietfparamsscimschemasoracleidcsextensionformFillAppApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateList UrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionkerberosRealmApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmAppList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmAppList UrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmAppList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmanagedappApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppList UrnietfparamsscimschemasoracleidcsextensionmanagedappApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppList UrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTagsList UrnietfparamsscimschemasoracleidcsextensionOciTags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTagsList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionopcServiceApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceAppList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceAppList UrnietfparamsscimschemasoracleidcsextensionopcServiceApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceAppList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionradiusAppApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppList UrnietfparamsscimschemasoracleidcsextensionradiusAppApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionrequestableApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableAppList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableAppList UrnietfparamsscimschemasoracleidcsextensionrequestableApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableAppList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppList UrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyAppList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyAppList UrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyAppList>()!;
        }

        [JsiiProperty(name: "userRoles", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUserRolesList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUserRolesList UserRoles
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUserRolesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppIdInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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
    }
}
