using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDashboardGrafana
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/dashboard_grafana azurerm_dashboard_grafana}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafana), fullyQualifiedName: "azurerm.dataAzurermDashboardGrafana.DataAzurermDashboardGrafana", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermDashboardGrafana.DataAzurermDashboardGrafanaConfig\"}}]")]
    public class DataAzurermDashboardGrafana : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/dashboard_grafana azurerm_dashboard_grafana} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermDashboardGrafana(Constructs.Construct scope, string id, azurerm.DataAzurermDashboardGrafana.IDataAzurermDashboardGrafanaConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermDashboardGrafana.IDataAzurermDashboardGrafanaConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermDashboardGrafana(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermDashboardGrafana(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermDashboardGrafana resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermDashboardGrafana to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermDashboardGrafana that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermDashboardGrafana to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermDashboardGrafana to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/dashboard_grafana#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermDashboardGrafana that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermDashboardGrafana to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafana), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermDashboardGrafana.DataAzurermDashboardGrafanaIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.DataAzurermDashboardGrafana.IDataAzurermDashboardGrafanaIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermDashboardGrafana.IDataAzurermDashboardGrafanaIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermDashboardGrafana.DataAzurermDashboardGrafanaTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermDashboardGrafana.IDataAzurermDashboardGrafanaTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermDashboardGrafana.IDataAzurermDashboardGrafanaTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafana))!;

        [JsiiProperty(name: "apiKeyEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ApiKeyEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "autoGeneratedDomainNameLabelScope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoGeneratedDomainNameLabelScope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azureMonitorWorkspaceIntegrations", typeJson: "{\"fqn\":\"azurerm.dataAzurermDashboardGrafana.DataAzurermDashboardGrafanaAzureMonitorWorkspaceIntegrationsList\"}")]
        public virtual azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafanaAzureMonitorWorkspaceIntegrationsList AzureMonitorWorkspaceIntegrations
        {
            get => GetInstanceProperty<azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafanaAzureMonitorWorkspaceIntegrationsList>()!;
        }

        [JsiiProperty(name: "deterministicOutboundIpEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeterministicOutboundIpEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grafanaMajorVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrafanaMajorVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grafanaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrafanaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermDashboardGrafana.DataAzurermDashboardGrafanaIdentityOutputReference\"}")]
        public virtual azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafanaIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafanaIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OutboundIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PublicNetworkAccessEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sku
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermDashboardGrafana.DataAzurermDashboardGrafanaTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafanaTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafanaTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "zoneRedundancyEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ZoneRedundancyEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.dataAzurermDashboardGrafana.DataAzurermDashboardGrafanaIdentity\"}", isOptional: true)]
        public virtual azurerm.DataAzurermDashboardGrafana.IDataAzurermDashboardGrafanaIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.DataAzurermDashboardGrafana.IDataAzurermDashboardGrafanaIdentity?>();
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermDashboardGrafana.IDataAzurermDashboardGrafanaTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermDashboardGrafana.DataAzurermDashboardGrafanaTimeouts\"}]}}", isOptional: true)]
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
