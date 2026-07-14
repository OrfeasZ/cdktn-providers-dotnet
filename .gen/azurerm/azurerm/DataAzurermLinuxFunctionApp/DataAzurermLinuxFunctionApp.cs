using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLinuxFunctionApp
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/linux_function_app azurerm_linux_function_app}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionApp), fullyQualifiedName: "azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionApp", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppConfig\"}}]")]
    public class DataAzurermLinuxFunctionApp : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/linux_function_app azurerm_linux_function_app} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermLinuxFunctionApp(Constructs.Construct scope, string id, azurerm.DataAzurermLinuxFunctionApp.IDataAzurermLinuxFunctionAppConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermLinuxFunctionApp.IDataAzurermLinuxFunctionAppConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermLinuxFunctionApp(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermLinuxFunctionApp(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermLinuxFunctionApp resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermLinuxFunctionApp to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermLinuxFunctionApp that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermLinuxFunctionApp to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermLinuxFunctionApp to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/linux_function_app#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermLinuxFunctionApp that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermLinuxFunctionApp to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionApp), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermLinuxFunctionApp.IDataAzurermLinuxFunctionAppTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermLinuxFunctionApp.IDataAzurermLinuxFunctionAppTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionApp))!;

        [JsiiProperty(name: "appSettings", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AppSettings
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "authSettings", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppAuthSettingsList\"}")]
        public virtual azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppAuthSettingsList AuthSettings
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppAuthSettingsList>()!;
        }

        [JsiiProperty(name: "authSettingsV2", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppAuthSettingsV2List\"}")]
        public virtual azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppAuthSettingsV2List AuthSettingsV2
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppAuthSettingsV2List>()!;
        }

        [JsiiProperty(name: "availability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Availability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backup", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppBackupList\"}")]
        public virtual azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppBackupList Backup
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppBackupList>()!;
        }

        [JsiiProperty(name: "builtinLoggingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BuiltinLoggingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clientCertificateEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ClientCertificateEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clientCertificateExclusionPaths", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateExclusionPaths
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppConnectionStringList\"}")]
        public virtual azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppConnectionStringList ConnectionString
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppConnectionStringList>()!;
        }

        [JsiiProperty(name: "contentShareForceDisabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ContentShareForceDisabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "customDomainVerificationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomDomainVerificationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dailyMemoryTimeQuota", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DailyMemoryTimeQuota
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "defaultHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultHostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ftpPublishBasicAuthenticationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FtpPublishBasicAuthenticationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "functionsExtensionVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionsExtensionVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostingEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostingEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpsOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HttpsOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppIdentityList\"}")]
        public virtual azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppIdentityList>()!;
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundIpAddresses", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundIpAddresses
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundIpAddressList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OutboundIpAddressList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "possibleOutboundIpAddresses", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PossibleOutboundIpAddresses
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "possibleOutboundIpAddressList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PossibleOutboundIpAddressList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PublicNetworkAccessEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "servicePlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppSiteConfigList\"}")]
        public virtual azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppSiteConfigList SiteConfig
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppSiteConfigList>()!;
        }

        [JsiiProperty(name: "siteCredential", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppSiteCredentialList\"}")]
        public virtual azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppSiteCredentialList SiteCredential
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppSiteCredentialList>()!;
        }

        [JsiiProperty(name: "stickySettings", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppStickySettingsList\"}")]
        public virtual azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppStickySettingsList StickySettings
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppStickySettingsList>()!;
        }

        [JsiiProperty(name: "storageAccountAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountAccessKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageKeyVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageKeyVaultSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageUsesManagedIdentity", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable StorageUsesManagedIdentity
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "usage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Usage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualNetworkBackupRestoreEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable VirtualNetworkBackupRestoreEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNetworkSubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable WebdeployPublishBasicAuthenticationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermLinuxFunctionApp.IDataAzurermLinuxFunctionAppTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
