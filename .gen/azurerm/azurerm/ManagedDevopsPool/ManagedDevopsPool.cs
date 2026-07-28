using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool azurerm_managed_devops_pool}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ManagedDevopsPool.ManagedDevopsPool), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolConfig\"}}]")]
    public class ManagedDevopsPool : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool azurerm_managed_devops_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ManagedDevopsPool(Constructs.Construct scope, string id, azurerm.ManagedDevopsPool.IManagedDevopsPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ManagedDevopsPool.IManagedDevopsPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDevopsPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDevopsPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ManagedDevopsPool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ManagedDevopsPool to import.</param>
        /// <param name="importFromId">The id of the existing ManagedDevopsPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ManagedDevopsPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ManagedDevopsPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ManagedDevopsPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ManagedDevopsPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.ManagedDevopsPool.ManagedDevopsPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAzureDevopsOrganization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganization\"}}]")]
        public virtual void PutAzureDevopsOrganization(azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.ManagedDevopsPool.IManagedDevopsPoolIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStatefulAgent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgent\"}}]")]
        public virtual void PutStatefulAgent(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStatelessAgent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgent\"}}]")]
        public virtual void PutStatelessAgent(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ManagedDevopsPool.IManagedDevopsPoolTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVirtualMachineScaleSetFabric", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabric\"}}]")]
        public virtual void PutVirtualMachineScaleSetFabric(azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabric @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabric)}, new object[]{@value});
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

        [JsiiMethod(name: "resetStatefulAgent")]
        public virtual void ResetStatefulAgent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatelessAgent")]
        public virtual void ResetStatelessAgent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkFolder")]
        public virtual void ResetWorkFolder()
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
        = GetStaticProperty<string>(typeof(azurerm.ManagedDevopsPool.ManagedDevopsPool))!;

        [JsiiProperty(name: "azureDevopsOrganization", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOutputReference AzureDevopsOrganization
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolIdentityOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "statefulAgent", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentOutputReference StatefulAgent
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentOutputReference>()!;
        }

        [JsiiProperty(name: "statelessAgent", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentOutputReference StatelessAgent
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolTimeoutsOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "virtualMachineScaleSetFabric", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference VirtualMachineScaleSetFabric
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureDevopsOrganizationInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganization\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganization? AzureDevopsOrganizationInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganization?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devCenterProjectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DevCenterProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolIdentity\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumConcurrencyInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumConcurrencyInput
        {
            get => GetInstanceProperty<double?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "statefulAgentInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgent\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgent? StatefulAgentInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statelessAgentInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgent\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgent? StatelessAgentInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineScaleSetFabricInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabric\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabric? VirtualMachineScaleSetFabricInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabric?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workFolderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkFolderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "devCenterProjectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DevCenterProjectId
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumConcurrency", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumConcurrency
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workFolder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkFolder
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
