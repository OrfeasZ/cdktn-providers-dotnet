using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.network.NetworkConfig")]
    public class NetworkConfig : libvirt.Network.INetworkConfig
    {
        /// <summary>Sets the network’s name, which must be unique on the host and consist of alphanumeric characters plus ‘_’ or ‘-’.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#general-metadata">https://libvirt.org/formatnetwork.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#name Network#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _autostart;

        /// <summary>Whether the network should be started automatically when the host boots.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#autostart Network#autostart}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autostart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Autostart
        {
            get => _autostart;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _autostart = value;
            }
        }

        /// <summary>Configures overall QoS bandwidth limits for the virtual network, enabling nested inbound/outbound rate settings when present.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#bandwidth Network#bandwidth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bandwidth", typeJson: "{\"fqn\":\"libvirt.network.NetworkBandwidth\"}", isOptional: true)]
        public libvirt.Network.INetworkBandwidth? Bandwidth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#bridge Network#bridge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bridge", typeJson: "{\"fqn\":\"libvirt.network.NetworkBridge\"}", isOptional: true)]
        public libvirt.Network.INetworkBridge? Bridge
        {
            get;
            set;
        }

        /// <summary>Enables configuration of DNS services for the virtual network, including forwarders and static records.</summary>
        /// <remarks>
        /// Presence of this block turns on DNS handling according to its child settings.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#dns Network#dns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"libvirt.network.NetworkDns\"}", isOptional: true)]
        public libvirt.Network.INetworkDns? Dns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#dnsmasq_options Network#dnsmasq_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsmasqOptions", typeJson: "{\"fqn\":\"libvirt.network.NetworkDnsmasqOptions\"}", isOptional: true)]
        public libvirt.Network.INetworkDnsmasqOptions? DnsmasqOptions
        {
            get;
            set;
        }

        /// <summary>Configures an optional DNS search domain block for the virtual network, controlling how guest hostnames are qualified and optionally whether they are registered only locally.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#domain Network#domain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "domain", typeJson: "{\"fqn\":\"libvirt.network.NetworkDomain\"}", isOptional: true)]
        public libvirt.Network.INetworkDomain? Domain
        {
            get;
            set;
        }

        /// <summary>Configures forwarding for the virtual network, defining how traffic is connected to external networks (e.g. NAT, routed, bridge, macvtap).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#forward Network#forward}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"libvirt.network.NetworkForward\"}", isOptional: true)]
        public libvirt.Network.INetworkForward? Forward
        {
            get;
            set;
        }

        private object? _ips;

        /// <summary>Defines one or more IP address configurations for the network, including address, DHCP, and related options for IPv4 and/or IPv6.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#ips Network#ips}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ips", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ips
        {
            get => _ips;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkIps[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkIps).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ips = value;
            }
        }

        /// <summary>Controls whether the network provides IPv6 support, as a boolean-like flag (`yes` or `no`).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#general-metadata">https://libvirt.org/formatnetwork.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#ipv6 Network#ipv6}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6
        {
            get;
            set;
        }

        /// <summary>Enables configuring a fixed MAC address for the network bridge device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#mac Network#mac}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mac", typeJson: "{\"fqn\":\"libvirt.network.NetworkMac\"}", isOptional: true)]
        public libvirt.Network.INetworkMac? Mac
        {
            get;
            set;
        }

        /// <summary>Provides an arbitrary metadata container for the virtual network, typically used by higher-level tools; content is user-defined XML.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#metadata Network#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"libvirt.network.NetworkMetadata\"}", isOptional: true)]
        public libvirt.Network.INetworkMetadata? Metadata
        {
            get;
            set;
        }

        /// <summary>Configures an MTU definition block for the virtual network;</summary>
        /// <remarks>
        /// include this block only when you need to override the default MTU.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#mtu Network#mtu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mtu", typeJson: "{\"fqn\":\"libvirt.network.NetworkMtu\"}", isOptional: true)]
        public libvirt.Network.INetworkMtu? Mtu
        {
            get;
            set;
        }

        private object? _portGroups;

        /// <summary>Defines one or more port groups that classify guest connections on this network, each with its own settings such as virtual port parameters or QoS.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#port_groups Network#port_groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkPortGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PortGroups
        {
            get => _portGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkPortGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkPortGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _portGroups = value;
            }
        }

        /// <summary>Configures default per-port options for this virtual network, such as isolating traffic between guests connected to the same network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#port_options Network#port_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portOptions", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortOptions\"}", isOptional: true)]
        public libvirt.Network.INetworkPortOptions? PortOptions
        {
            get;
            set;
        }

        private object? _routes;

        /// <summary>Configures one or more static routes associated with this virtual network, informing the host about networks reachable via guests.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#routes Network#routes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Routes
        {
            get => _routes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkRoutes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkRoutes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _routes = value;
            }
        }

        /// <summary>Controls whether the network as a whole trusts guests' receive-side filtering settings, corresponding to the yes/no trustGuestRxFilters flag on the network definition.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#general-metadata">https://libvirt.org/formatnetwork.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#trust_guest_rx_filters Network#trust_guest_rx_filters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustGuestRxFilters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustGuestRxFilters
        {
            get;
            set;
        }

        /// <summary>Configures virtual port profile information for this port group, enabling integration with external network switching or SDN systems.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#virtual_port Network#virtual_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualPort", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPort\"}", isOptional: true)]
        public libvirt.Network.INetworkVirtualPort? VirtualPort
        {
            get;
            set;
        }

        /// <summary>Configures VLAN tagging behavior for this portgroup, allowing one or more VLAN tags to be applied to guest connections when the underlying network supports VLAN offload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#vlan Network#vlan}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vlan", typeJson: "{\"fqn\":\"libvirt.network.NetworkVlan\"}", isOptional: true)]
        public libvirt.Network.INetworkVlan? Vlan
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
