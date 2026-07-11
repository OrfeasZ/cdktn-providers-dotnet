using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppService
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/app_service azurerm_app_service}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermAppService.DataAzurermAppService), fullyQualifiedName: "azurerm.dataAzurermAppService.DataAzurermAppService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermAppService.DataAzurermAppServiceConfig\"}}]")]
    public class DataAzurermAppService : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/app_service azurerm_app_service} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermAppService(Constructs.Construct scope, string id, azurerm.DataAzurermAppService.IDataAzurermAppServiceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermAppService.IDataAzurermAppServiceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermAppService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermAppService(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermAppService resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermAppService to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermAppService that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermAppService to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermAppService to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/app_service#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermAppService that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermAppService to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermAppService.DataAzurermAppService), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermAppService.DataAzurermAppServiceTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermAppService.IDataAzurermAppServiceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermAppService.IDataAzurermAppServiceTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermAppService.DataAzurermAppService))!;

        [JsiiProperty(name: "appServicePlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppServicePlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "appSettings", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AppSettings
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "clientAffinityEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ClientAffinityEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clientCertEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ClientCertEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppService.DataAzurermAppServiceConnectionStringList\"}")]
        public virtual azurerm.DataAzurermAppService.DataAzurermAppServiceConnectionStringList ConnectionString
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppService.DataAzurermAppServiceConnectionStringList>()!;
        }

        [JsiiProperty(name: "customDomainVerificationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomDomainVerificationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultSiteHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSiteHostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "httpsOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HttpsOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppService.DataAzurermAppServiceSiteConfigList\"}")]
        public virtual azurerm.DataAzurermAppService.DataAzurermAppServiceSiteConfigList SiteConfig
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppService.DataAzurermAppServiceSiteConfigList>()!;
        }

        [JsiiProperty(name: "siteCredential", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppService.DataAzurermAppServiceSiteCredentialList\"}")]
        public virtual azurerm.DataAzurermAppService.DataAzurermAppServiceSiteCredentialList SiteCredential
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppService.DataAzurermAppServiceSiteCredentialList>()!;
        }

        [JsiiProperty(name: "sourceControl", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppService.DataAzurermAppServiceSourceControlList\"}")]
        public virtual azurerm.DataAzurermAppService.DataAzurermAppServiceSourceControlList SourceControl
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppService.DataAzurermAppServiceSourceControlList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppService.DataAzurermAppServiceTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermAppService.DataAzurermAppServiceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppService.DataAzurermAppServiceTimeoutsOutputReference>()!;
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermAppService.IDataAzurermAppServiceTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermAppService.DataAzurermAppServiceTimeouts\"}]}}", isOptional: true)]
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
