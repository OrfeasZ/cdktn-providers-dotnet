using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermArcMachine
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/arc_machine azurerm_arc_machine}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermArcMachine.DataAzurermArcMachine), fullyQualifiedName: "azurerm.dataAzurermArcMachine.DataAzurermArcMachine", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineConfig\"}}]")]
    public class DataAzurermArcMachine : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/arc_machine azurerm_arc_machine} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermArcMachine(Constructs.Construct scope, string id, azurerm.DataAzurermArcMachine.IDataAzurermArcMachineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermArcMachine.IDataAzurermArcMachineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermArcMachine(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermArcMachine(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermArcMachine resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermArcMachine to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermArcMachine that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermArcMachine to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermArcMachine to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/arc_machine#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermArcMachine that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermArcMachine to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermArcMachine.DataAzurermArcMachine), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermArcMachine.IDataAzurermArcMachineTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermArcMachine.IDataAzurermArcMachineTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermArcMachine.DataAzurermArcMachine))!;

        [JsiiProperty(name: "activeDirectoryFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActiveDirectoryFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "agent", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineAgentList\"}")]
        public virtual azurerm.DataAzurermArcMachine.DataAzurermArcMachineAgentList Agent
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.DataAzurermArcMachineAgentList>()!;
        }

        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientPublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudMetadata", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineCloudMetadataList\"}")]
        public virtual azurerm.DataAzurermArcMachine.DataAzurermArcMachineCloudMetadataList CloudMetadata
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.DataAzurermArcMachineCloudMetadataList>()!;
        }

        [JsiiProperty(name: "detectedProperties", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DetectedProperties
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineIdentityList\"}")]
        public virtual azurerm.DataAzurermArcMachine.DataAzurermArcMachineIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.DataAzurermArcMachineIdentityList>()!;
        }

        [JsiiProperty(name: "lastStatusChangeTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastStatusChangeTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locationData", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineLocationDataList\"}")]
        public virtual azurerm.DataAzurermArcMachine.DataAzurermArcMachineLocationDataList LocationData
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.DataAzurermArcMachineLocationDataList>()!;
        }

        [JsiiProperty(name: "machineFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MachineFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mssqlDiscovered", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable MssqlDiscovered
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "osName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osProfile", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineOsProfileList\"}")]
        public virtual azurerm.DataAzurermArcMachine.DataAzurermArcMachineOsProfileList OsProfile
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.DataAzurermArcMachineOsProfileList>()!;
        }

        [JsiiProperty(name: "osSku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsSku
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentClusterResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentClusterResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateLinkScopeResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateLinkScopeResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceStatus", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineServiceStatusList\"}")]
        public virtual azurerm.DataAzurermArcMachine.DataAzurermArcMachineServiceStatusList ServiceStatus
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.DataAzurermArcMachineServiceStatusList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermArcMachine.DataAzurermArcMachineTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.DataAzurermArcMachineTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vmId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmUuid
        {
            get => GetInstanceProperty<string>()!;
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermArcMachine.IDataAzurermArcMachineTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineTimeouts\"}]}}", isOptional: true)]
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
