using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualNetworkGateway
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway azurestack_virtual_network_gateway}.</summary>
    [JsiiClass(nativeType: typeof(azurestack.VirtualNetworkGateway.VirtualNetworkGateway), fullyQualifiedName: "azurestack.virtualNetworkGateway.VirtualNetworkGateway", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayConfig\"}}]")]
    public class VirtualNetworkGateway : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway azurestack_virtual_network_gateway} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VirtualNetworkGateway(Constructs.Construct scope, string id, azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualNetworkGateway(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualNetworkGateway(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a VirtualNetworkGateway resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VirtualNetworkGateway to import.</param>
        /// <param name="importFromId">The id of the existing VirtualNetworkGateway that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VirtualNetworkGateway to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VirtualNetworkGateway to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VirtualNetworkGateway that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VirtualNetworkGateway to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurestack.VirtualNetworkGateway.VirtualNetworkGateway), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBgpSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayBgpSettings\"}}]")]
        public virtual void PutBgpSettings(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayIpConfiguration" />)[]</param>
        [JsiiMethod(name: "putIpConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayIpConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIpConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayIpConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayIpConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayIpConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayTimeouts\"}}]")]
        public virtual void PutTimeouts(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpnClientConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfiguration\"}}]")]
        public virtual void PutVpnClientConfiguration(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveActive")]
        public virtual void ResetActiveActive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBgpSettings")]
        public virtual void ResetBgpSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultLocalNetworkGatewayId")]
        public virtual void ResetDefaultLocalNetworkGatewayId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableBgp")]
        public virtual void ResetEnableBgp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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

        [JsiiMethod(name: "resetVpnClientConfiguration")]
        public virtual void ResetVpnClientConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpnType")]
        public virtual void ResetVpnType()
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
        = GetStaticProperty<string>(typeof(azurestack.VirtualNetworkGateway.VirtualNetworkGateway))!;

        [JsiiProperty(name: "bgpSettings", typeJson: "{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayBgpSettingsOutputReference\"}")]
        public virtual azurestack.VirtualNetworkGateway.VirtualNetworkGatewayBgpSettingsOutputReference BgpSettings
        {
            get => GetInstanceProperty<azurestack.VirtualNetworkGateway.VirtualNetworkGatewayBgpSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "ipConfiguration", typeJson: "{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayIpConfigurationList\"}")]
        public virtual azurestack.VirtualNetworkGateway.VirtualNetworkGatewayIpConfigurationList IpConfiguration
        {
            get => GetInstanceProperty<azurestack.VirtualNetworkGateway.VirtualNetworkGatewayIpConfigurationList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayTimeoutsOutputReference\"}")]
        public virtual azurestack.VirtualNetworkGateway.VirtualNetworkGatewayTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurestack.VirtualNetworkGateway.VirtualNetworkGatewayTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpnClientConfiguration", typeJson: "{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationOutputReference\"}")]
        public virtual azurestack.VirtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationOutputReference VpnClientConfiguration
        {
            get => GetInstanceProperty<azurestack.VirtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeActiveInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ActiveActiveInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bgpSettingsInput", typeJson: "{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayBgpSettings\"}", isOptional: true)]
        public virtual azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings? BgpSettingsInput
        {
            get => GetInstanceProperty<azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultLocalNetworkGatewayIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultLocalNetworkGatewayIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableBgpInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableBgpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayIpConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayIpConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IpConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
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

        [JsiiOptional]
        [JsiiProperty(name: "skuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpnClientConfigurationInput", typeJson: "{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfiguration\"}", isOptional: true)]
        public virtual azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfiguration? VpnClientConfigurationInput
        {
            get => GetInstanceProperty<azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpnTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpnTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "activeActive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ActiveActive
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "defaultLocalNetworkGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultLocalNetworkGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableBgp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableBgp
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
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

        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sku
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpnType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpnType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
