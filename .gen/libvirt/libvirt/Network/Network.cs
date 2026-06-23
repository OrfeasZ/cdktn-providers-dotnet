using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network libvirt_network}.</summary>
    [JsiiClass(nativeType: typeof(libvirt.Network.Network), fullyQualifiedName: "libvirt.network.Network", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"libvirt.network.NetworkConfig\"}}]")]
    public class Network : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network libvirt_network} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Network(Constructs.Construct scope, string id, libvirt.Network.INetworkConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, libvirt.Network.INetworkConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Network(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Network(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Network resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Network to import.</param>
        /// <param name="importFromId">The id of the existing Network that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Network to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Network to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Network that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Network to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(libvirt.Network.Network), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBandwidth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkBandwidth\"}}]")]
        public virtual void PutBandwidth(libvirt.Network.INetworkBandwidth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkBandwidth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBridge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkBridge\"}}]")]
        public virtual void PutBridge(libvirt.Network.INetworkBridge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkBridge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkDns\"}}]")]
        public virtual void PutDns(libvirt.Network.INetworkDns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkDns)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDnsmasqOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkDnsmasqOptions\"}}]")]
        public virtual void PutDnsmasqOptions(libvirt.Network.INetworkDnsmasqOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkDnsmasqOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkDomain\"}}]")]
        public virtual void PutDomain(libvirt.Network.INetworkDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putForward", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkForward\"}}]")]
        public virtual void PutForward(libvirt.Network.INetworkForward @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkForward)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIps", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIps\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIps(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Network.INetworkIps[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkIps).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkIps).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMac", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkMac\"}}]")]
        public virtual void PutMac(libvirt.Network.INetworkMac @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkMac)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetadata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkMetadata\"}}]")]
        public virtual void PutMetadata(libvirt.Network.INetworkMetadata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkMetadata)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMtu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkMtu\"}}]")]
        public virtual void PutMtu(libvirt.Network.INetworkMtu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkMtu)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPortGroups", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkPortGroups\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPortGroups(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Network.INetworkPortGroups[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkPortGroups).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkPortGroups).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPortOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkPortOptions\"}}]")]
        public virtual void PutPortOptions(libvirt.Network.INetworkPortOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkPortOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoutes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkRoutes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRoutes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Network.INetworkRoutes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkRoutes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkRoutes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVirtualPort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkVirtualPort\"}}]")]
        public virtual void PutVirtualPort(libvirt.Network.INetworkVirtualPort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkVirtualPort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkVlan\"}}]")]
        public virtual void PutVlan(libvirt.Network.INetworkVlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkVlan)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutostart")]
        public virtual void ResetAutostart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBandwidth")]
        public virtual void ResetBandwidth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBridge")]
        public virtual void ResetBridge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDns")]
        public virtual void ResetDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsmasqOptions")]
        public virtual void ResetDnsmasqOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomain")]
        public virtual void ResetDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForward")]
        public virtual void ResetForward()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIps")]
        public virtual void ResetIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv6")]
        public virtual void ResetIpv6()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMac")]
        public virtual void ResetMac()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMtu")]
        public virtual void ResetMtu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPortGroups")]
        public virtual void ResetPortGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPortOptions")]
        public virtual void ResetPortOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutes")]
        public virtual void ResetRoutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustGuestRxFilters")]
        public virtual void ResetTrustGuestRxFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualPort")]
        public virtual void ResetVirtualPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVlan")]
        public virtual void ResetVlan()
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
        = GetStaticProperty<string>(typeof(libvirt.Network.Network))!;

        [JsiiProperty(name: "bandwidth", typeJson: "{\"fqn\":\"libvirt.network.NetworkBandwidthOutputReference\"}")]
        public virtual libvirt.Network.NetworkBandwidthOutputReference Bandwidth
        {
            get => GetInstanceProperty<libvirt.Network.NetworkBandwidthOutputReference>()!;
        }

        [JsiiProperty(name: "bridge", typeJson: "{\"fqn\":\"libvirt.network.NetworkBridgeOutputReference\"}")]
        public virtual libvirt.Network.NetworkBridgeOutputReference Bridge
        {
            get => GetInstanceProperty<libvirt.Network.NetworkBridgeOutputReference>()!;
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"libvirt.network.NetworkDnsOutputReference\"}")]
        public virtual libvirt.Network.NetworkDnsOutputReference Dns
        {
            get => GetInstanceProperty<libvirt.Network.NetworkDnsOutputReference>()!;
        }

        [JsiiProperty(name: "dnsmasqOptions", typeJson: "{\"fqn\":\"libvirt.network.NetworkDnsmasqOptionsOutputReference\"}")]
        public virtual libvirt.Network.NetworkDnsmasqOptionsOutputReference DnsmasqOptions
        {
            get => GetInstanceProperty<libvirt.Network.NetworkDnsmasqOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "domain", typeJson: "{\"fqn\":\"libvirt.network.NetworkDomainOutputReference\"}")]
        public virtual libvirt.Network.NetworkDomainOutputReference Domain
        {
            get => GetInstanceProperty<libvirt.Network.NetworkDomainOutputReference>()!;
        }

        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"libvirt.network.NetworkForwardOutputReference\"}")]
        public virtual libvirt.Network.NetworkForwardOutputReference Forward
        {
            get => GetInstanceProperty<libvirt.Network.NetworkForwardOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ips", typeJson: "{\"fqn\":\"libvirt.network.NetworkIpsList\"}")]
        public virtual libvirt.Network.NetworkIpsList Ips
        {
            get => GetInstanceProperty<libvirt.Network.NetworkIpsList>()!;
        }

        [JsiiProperty(name: "mac", typeJson: "{\"fqn\":\"libvirt.network.NetworkMacOutputReference\"}")]
        public virtual libvirt.Network.NetworkMacOutputReference Mac
        {
            get => GetInstanceProperty<libvirt.Network.NetworkMacOutputReference>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"libvirt.network.NetworkMetadataOutputReference\"}")]
        public virtual libvirt.Network.NetworkMetadataOutputReference Metadata
        {
            get => GetInstanceProperty<libvirt.Network.NetworkMetadataOutputReference>()!;
        }

        [JsiiProperty(name: "mtu", typeJson: "{\"fqn\":\"libvirt.network.NetworkMtuOutputReference\"}")]
        public virtual libvirt.Network.NetworkMtuOutputReference Mtu
        {
            get => GetInstanceProperty<libvirt.Network.NetworkMtuOutputReference>()!;
        }

        [JsiiProperty(name: "portGroups", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsList\"}")]
        public virtual libvirt.Network.NetworkPortGroupsList PortGroups
        {
            get => GetInstanceProperty<libvirt.Network.NetworkPortGroupsList>()!;
        }

        [JsiiProperty(name: "portOptions", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortOptionsOutputReference\"}")]
        public virtual libvirt.Network.NetworkPortOptionsOutputReference PortOptions
        {
            get => GetInstanceProperty<libvirt.Network.NetworkPortOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "routes", typeJson: "{\"fqn\":\"libvirt.network.NetworkRoutesList\"}")]
        public virtual libvirt.Network.NetworkRoutesList Routes
        {
            get => GetInstanceProperty<libvirt.Network.NetworkRoutesList>()!;
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualPort", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortOutputReference\"}")]
        public virtual libvirt.Network.NetworkVirtualPortOutputReference VirtualPort
        {
            get => GetInstanceProperty<libvirt.Network.NetworkVirtualPortOutputReference>()!;
        }

        [JsiiProperty(name: "vlan", typeJson: "{\"fqn\":\"libvirt.network.NetworkVlanOutputReference\"}")]
        public virtual libvirt.Network.NetworkVlanOutputReference Vlan
        {
            get => GetInstanceProperty<libvirt.Network.NetworkVlanOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autostartInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutostartInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bandwidthInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkBandwidth\"}]}}", isOptional: true)]
        public virtual object? BandwidthInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bridgeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkBridge\"}]}}", isOptional: true)]
        public virtual object? BridgeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkDns\"}]}}", isOptional: true)]
        public virtual object? DnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsmasqOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkDnsmasqOptions\"}]}}", isOptional: true)]
        public virtual object? DnsmasqOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkDomain\"}]}}", isOptional: true)]
        public virtual object? DomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkForward\"}]}}", isOptional: true)]
        public virtual object? ForwardInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IpsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ipv6Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "macInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkMac\"}]}}", isOptional: true)]
        public virtual object? MacInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkMetadata\"}]}}", isOptional: true)]
        public virtual object? MetadataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mtuInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkMtu\"}]}}", isOptional: true)]
        public virtual object? MtuInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portGroupsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkPortGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PortGroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkPortOptions\"}]}}", isOptional: true)]
        public virtual object? PortOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RoutesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustGuestRxFiltersInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrustGuestRxFiltersInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualPortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkVirtualPort\"}]}}", isOptional: true)]
        public virtual object? VirtualPortInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vlanInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkVlan\"}]}}", isOptional: true)]
        public virtual object? VlanInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "autostart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Autostart
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

        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6
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

        [JsiiProperty(name: "trustGuestRxFilters", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustGuestRxFilters
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
