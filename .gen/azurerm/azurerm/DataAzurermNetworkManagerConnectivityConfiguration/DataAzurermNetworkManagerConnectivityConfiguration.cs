using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkManagerConnectivityConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/network_manager_connectivity_configuration azurerm_network_manager_connectivity_configuration}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfiguration), fullyQualifiedName: "azurerm.dataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationConfig\"}}]")]
    public class DataAzurermNetworkManagerConnectivityConfiguration : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/network_manager_connectivity_configuration azurerm_network_manager_connectivity_configuration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermNetworkManagerConnectivityConfiguration(Constructs.Construct scope, string id, azurerm.DataAzurermNetworkManagerConnectivityConfiguration.IDataAzurermNetworkManagerConnectivityConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermNetworkManagerConnectivityConfiguration.IDataAzurermNetworkManagerConnectivityConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermNetworkManagerConnectivityConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermNetworkManagerConnectivityConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermNetworkManagerConnectivityConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermNetworkManagerConnectivityConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermNetworkManagerConnectivityConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermNetworkManagerConnectivityConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermNetworkManagerConnectivityConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/network_manager_connectivity_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermNetworkManagerConnectivityConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermNetworkManagerConnectivityConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermNetworkManagerConnectivityConfiguration.IDataAzurermNetworkManagerConnectivityConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermNetworkManagerConnectivityConfiguration.IDataAzurermNetworkManagerConnectivityConfigurationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfiguration))!;

        [JsiiProperty(name: "appliesToGroup", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationAppliesToGroupList\"}")]
        public virtual azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationAppliesToGroupList AppliesToGroup
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationAppliesToGroupList>()!;
        }

        [JsiiProperty(name: "connectedGroupAddressOverlapEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ConnectedGroupAddressOverlapEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "connectedGroupPrivateEndpointsScale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectedGroupPrivateEndpointsScale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectivityTopology", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectivityTopology
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteExistingPeeringEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteExistingPeeringEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "globalMeshEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable GlobalMeshEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "hub", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationHubList\"}")]
        public virtual azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationHubList Hub
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationHubList>()!;
        }

        [JsiiProperty(name: "peeringEnforcementEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PeeringEnforcementEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "networkManagerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkManagerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermNetworkManagerConnectivityConfiguration.IDataAzurermNetworkManagerConnectivityConfigurationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "networkManagerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkManagerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
