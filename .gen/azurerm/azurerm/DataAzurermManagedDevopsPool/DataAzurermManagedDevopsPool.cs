using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedDevopsPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/managed_devops_pool azurerm_managed_devops_pool}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPool), fullyQualifiedName: "azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolConfig\"}}]")]
    public class DataAzurermManagedDevopsPool : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/managed_devops_pool azurerm_managed_devops_pool} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermManagedDevopsPool(Constructs.Construct scope, string id, azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermManagedDevopsPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermManagedDevopsPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermManagedDevopsPool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermManagedDevopsPool to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermManagedDevopsPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermManagedDevopsPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermManagedDevopsPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/managed_devops_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermManagedDevopsPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermManagedDevopsPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPool))!;

        [JsiiProperty(name: "azureDevopsOrganization", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolAzureDevopsOrganizationList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolAzureDevopsOrganizationList AzureDevopsOrganization
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolAzureDevopsOrganizationList>()!;
        }

        [JsiiProperty(name: "devCenterProjectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DevCenterProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolIdentityList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolIdentityList>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maximumConcurrency", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumConcurrency
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "statefulAgent", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentList StatefulAgent
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentList>()!;
        }

        [JsiiProperty(name: "statelessAgent", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentList StatelessAgent
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "virtualMachineScaleSetFabric", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricList VirtualMachineScaleSetFabric
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolVirtualMachineScaleSetFabricList>()!;
        }

        [JsiiProperty(name: "workFolder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkFolder
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolTimeouts\"}]}}", isOptional: true)]
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
