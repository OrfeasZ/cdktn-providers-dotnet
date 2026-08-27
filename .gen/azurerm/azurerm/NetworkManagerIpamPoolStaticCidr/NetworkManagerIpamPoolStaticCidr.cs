using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerIpamPoolStaticCidr
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/network_manager_ipam_pool_static_cidr azurerm_network_manager_ipam_pool_static_cidr}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.NetworkManagerIpamPoolStaticCidr.NetworkManagerIpamPoolStaticCidr), fullyQualifiedName: "azurerm.networkManagerIpamPoolStaticCidr.NetworkManagerIpamPoolStaticCidr", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.networkManagerIpamPoolStaticCidr.NetworkManagerIpamPoolStaticCidrConfig\"}}]")]
    public class NetworkManagerIpamPoolStaticCidr : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/network_manager_ipam_pool_static_cidr azurerm_network_manager_ipam_pool_static_cidr} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetworkManagerIpamPoolStaticCidr(Constructs.Construct scope, string id, azurerm.NetworkManagerIpamPoolStaticCidr.INetworkManagerIpamPoolStaticCidrConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.NetworkManagerIpamPoolStaticCidr.INetworkManagerIpamPoolStaticCidrConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkManagerIpamPoolStaticCidr(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkManagerIpamPoolStaticCidr(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NetworkManagerIpamPoolStaticCidr resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetworkManagerIpamPoolStaticCidr to import.</param>
        /// <param name="importFromId">The id of the existing NetworkManagerIpamPoolStaticCidr that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetworkManagerIpamPoolStaticCidr to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetworkManagerIpamPoolStaticCidr to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/network_manager_ipam_pool_static_cidr#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetworkManagerIpamPoolStaticCidr that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetworkManagerIpamPoolStaticCidr to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.NetworkManagerIpamPoolStaticCidr.NetworkManagerIpamPoolStaticCidr), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.networkManagerIpamPoolStaticCidr.NetworkManagerIpamPoolStaticCidrTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.NetworkManagerIpamPoolStaticCidr.INetworkManagerIpamPoolStaticCidrTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetworkManagerIpamPoolStaticCidr.INetworkManagerIpamPoolStaticCidrTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddressPrefixes")]
        public virtual void ResetAddressPrefixes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberOfIpAddressesToAllocate")]
        public virtual void ResetNumberOfIpAddressesToAllocate()
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
        = GetStaticProperty<string>(typeof(azurerm.NetworkManagerIpamPoolStaticCidr.NetworkManagerIpamPoolStaticCidr))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.networkManagerIpamPoolStaticCidr.NetworkManagerIpamPoolStaticCidrTimeoutsOutputReference\"}")]
        public virtual azurerm.NetworkManagerIpamPoolStaticCidr.NetworkManagerIpamPoolStaticCidrTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.NetworkManagerIpamPoolStaticCidr.NetworkManagerIpamPoolStaticCidrTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressPrefixesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AddressPrefixesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipamPoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpamPoolIdInput
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
        [JsiiProperty(name: "numberOfIpAddressesToAllocateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NumberOfIpAddressesToAllocateInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.NetworkManagerIpamPoolStaticCidr.INetworkManagerIpamPoolStaticCidrTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.networkManagerIpamPoolStaticCidr.NetworkManagerIpamPoolStaticCidrTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "addressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AddressPrefixes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipamPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpamPoolId
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

        [JsiiProperty(name: "numberOfIpAddressesToAllocate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NumberOfIpAddressesToAllocate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
