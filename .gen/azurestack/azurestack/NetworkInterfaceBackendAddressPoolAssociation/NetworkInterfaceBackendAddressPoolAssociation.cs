using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.NetworkInterfaceBackendAddressPoolAssociation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/network_interface_backend_address_pool_association azurestack_network_interface_backend_address_pool_association}.</summary>
    [JsiiClass(nativeType: typeof(azurestack.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociation), fullyQualifiedName: "azurestack.networkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurestack.networkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociationConfig\"}}]")]
    public class NetworkInterfaceBackendAddressPoolAssociation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/network_interface_backend_address_pool_association azurestack_network_interface_backend_address_pool_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetworkInterfaceBackendAddressPoolAssociation(Constructs.Construct scope, string id, azurestack.NetworkInterfaceBackendAddressPoolAssociation.INetworkInterfaceBackendAddressPoolAssociationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurestack.NetworkInterfaceBackendAddressPoolAssociation.INetworkInterfaceBackendAddressPoolAssociationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkInterfaceBackendAddressPoolAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkInterfaceBackendAddressPoolAssociation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NetworkInterfaceBackendAddressPoolAssociation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetworkInterfaceBackendAddressPoolAssociation to import.</param>
        /// <param name="importFromId">The id of the existing NetworkInterfaceBackendAddressPoolAssociation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetworkInterfaceBackendAddressPoolAssociation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetworkInterfaceBackendAddressPoolAssociation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/network_interface_backend_address_pool_association#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetworkInterfaceBackendAddressPoolAssociation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetworkInterfaceBackendAddressPoolAssociation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurestack.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.networkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociationTimeouts\"}}]")]
        public virtual void PutTimeouts(azurestack.NetworkInterfaceBackendAddressPoolAssociation.INetworkInterfaceBackendAddressPoolAssociationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.NetworkInterfaceBackendAddressPoolAssociation.INetworkInterfaceBackendAddressPoolAssociationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurestack.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociation))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.networkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociationTimeoutsOutputReference\"}")]
        public virtual azurestack.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurestack.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendAddressPoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackendAddressPoolIdInput
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
        [JsiiProperty(name: "ipConfigurationNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpConfigurationNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkInterfaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurestack.NetworkInterfaceBackendAddressPoolAssociation.INetworkInterfaceBackendAddressPoolAssociationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurestack.networkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "backendAddressPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackendAddressPoolId
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

        [JsiiProperty(name: "ipConfigurationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpConfigurationName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkInterfaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
