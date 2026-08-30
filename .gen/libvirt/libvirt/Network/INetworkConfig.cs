using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkConfig), fullyQualifiedName: "libvirt.network.NetworkConfig")]
    public interface INetworkConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Sets the network’s name, which must be unique on the host and consist of alphanumeric characters plus ‘_’ or ‘-’.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#general-metadata">https://libvirt.org/formatnetwork.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#name Network#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Whether the network should be started automatically when the host boots.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#autostart Network#autostart}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autostart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Autostart
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures overall QoS bandwidth limits for the virtual network, enabling nested inbound/outbound rate settings when present.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#bandwidth Network#bandwidth}
        /// </remarks>
        [JsiiProperty(name: "bandwidth", typeJson: "{\"fqn\":\"libvirt.network.NetworkBandwidth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkBandwidth? Bandwidth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#bridge Network#bridge}.</summary>
        [JsiiProperty(name: "bridge", typeJson: "{\"fqn\":\"libvirt.network.NetworkBridge\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkBridge? Bridge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of DNS services for the virtual network, including forwarders and static records.</summary>
        /// <remarks>
        /// Presence of this block turns on DNS handling according to its child settings.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#dns Network#dns}
        /// </remarks>
        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"libvirt.network.NetworkDns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkDns? Dns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#dnsmasq_options Network#dnsmasq_options}.</summary>
        [JsiiProperty(name: "dnsmasqOptions", typeJson: "{\"fqn\":\"libvirt.network.NetworkDnsmasqOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkDnsmasqOptions? DnsmasqOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an optional DNS search domain block for the virtual network, controlling how guest hostnames are qualified and optionally whether they are registered only locally.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#domain Network#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"fqn\":\"libvirt.network.NetworkDomain\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkDomain? Domain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures forwarding for the virtual network, defining how traffic is connected to external networks (e.g. NAT, routed, bridge, macvtap).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#forward Network#forward}
        /// </remarks>
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"libvirt.network.NetworkForward\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkForward? Forward
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more IP address configurations for the network, including address, DHCP, and related options for IPv4 and/or IPv6.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#ips Network#ips}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkIps" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ips", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ips
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the network provides IPv6 support, as a boolean-like flag (`yes` or `no`).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#general-metadata">https://libvirt.org/formatnetwork.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#ipv6 Network#ipv6}
        /// </remarks>
        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuring a fixed MAC address for the network bridge device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#mac Network#mac}
        /// </remarks>
        [JsiiProperty(name: "mac", typeJson: "{\"fqn\":\"libvirt.network.NetworkMac\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkMac? Mac
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides an arbitrary metadata container for the virtual network, typically used by higher-level tools; content is user-defined XML.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#metadata Network#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"libvirt.network.NetworkMetadata\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkMetadata? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an MTU definition block for the virtual network;</summary>
        /// <remarks>
        /// include this block only when you need to override the default MTU.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#mtu Network#mtu}
        /// </remarks>
        [JsiiProperty(name: "mtu", typeJson: "{\"fqn\":\"libvirt.network.NetworkMtu\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkMtu? Mtu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more port groups that classify guest connections on this network, each with its own settings such as virtual port parameters or QoS.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#port_groups Network#port_groups}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkPortGroups" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "portGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkPortGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PortGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures default per-port options for this virtual network, such as isolating traffic between guests connected to the same network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#port_options Network#port_options}
        /// </remarks>
        [JsiiProperty(name: "portOptions", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkPortOptions? PortOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more static routes associated with this virtual network, informing the host about networks reachable via guests.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#routes Network#routes}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkRoutes" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Routes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the network as a whole trusts guests' receive-side filtering settings, corresponding to the yes/no trustGuestRxFilters flag on the network definition.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#general-metadata">https://libvirt.org/formatnetwork.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#trust_guest_rx_filters Network#trust_guest_rx_filters}
        /// </remarks>
        [JsiiProperty(name: "trustGuestRxFilters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustGuestRxFilters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures virtual port profile information for this port group, enabling integration with external network switching or SDN systems.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#virtual_port Network#virtual_port}
        /// </remarks>
        [JsiiProperty(name: "virtualPort", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkVirtualPort? VirtualPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures VLAN tagging behavior for this portgroup, allowing one or more VLAN tags to be applied to guest connections when the underlying network supports VLAN offload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#vlan Network#vlan}
        /// </remarks>
        [JsiiProperty(name: "vlan", typeJson: "{\"fqn\":\"libvirt.network.NetworkVlan\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkVlan? Vlan
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkConfig), fullyQualifiedName: "libvirt.network.NetworkConfig")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the network’s name, which must be unique on the host and consist of alphanumeric characters plus ‘_’ or ‘-’.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#general-metadata">https://libvirt.org/formatnetwork.html#general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#name Network#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether the network should be started automatically when the host boots.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#autostart Network#autostart}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autostart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Autostart
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures overall QoS bandwidth limits for the virtual network, enabling nested inbound/outbound rate settings when present.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#bandwidth Network#bandwidth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bandwidth", typeJson: "{\"fqn\":\"libvirt.network.NetworkBandwidth\"}", isOptional: true)]
            public libvirt.Network.INetworkBandwidth? Bandwidth
            {
                get => GetInstanceProperty<libvirt.Network.INetworkBandwidth?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#bridge Network#bridge}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bridge", typeJson: "{\"fqn\":\"libvirt.network.NetworkBridge\"}", isOptional: true)]
            public libvirt.Network.INetworkBridge? Bridge
            {
                get => GetInstanceProperty<libvirt.Network.INetworkBridge?>();
            }

            /// <summary>Enables configuration of DNS services for the virtual network, including forwarders and static records.</summary>
            /// <remarks>
            /// Presence of this block turns on DNS handling according to its child settings.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#dns Network#dns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"libvirt.network.NetworkDns\"}", isOptional: true)]
            public libvirt.Network.INetworkDns? Dns
            {
                get => GetInstanceProperty<libvirt.Network.INetworkDns?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#dnsmasq_options Network#dnsmasq_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsmasqOptions", typeJson: "{\"fqn\":\"libvirt.network.NetworkDnsmasqOptions\"}", isOptional: true)]
            public libvirt.Network.INetworkDnsmasqOptions? DnsmasqOptions
            {
                get => GetInstanceProperty<libvirt.Network.INetworkDnsmasqOptions?>();
            }

            /// <summary>Configures an optional DNS search domain block for the virtual network, controlling how guest hostnames are qualified and optionally whether they are registered only locally.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#domain Network#domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domain", typeJson: "{\"fqn\":\"libvirt.network.NetworkDomain\"}", isOptional: true)]
            public libvirt.Network.INetworkDomain? Domain
            {
                get => GetInstanceProperty<libvirt.Network.INetworkDomain?>();
            }

            /// <summary>Configures forwarding for the virtual network, defining how traffic is connected to external networks (e.g. NAT, routed, bridge, macvtap).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#forward Network#forward}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"libvirt.network.NetworkForward\"}", isOptional: true)]
            public libvirt.Network.INetworkForward? Forward
            {
                get => GetInstanceProperty<libvirt.Network.INetworkForward?>();
            }

            /// <summary>Defines one or more IP address configurations for the network, including address, DHCP, and related options for IPv4 and/or IPv6.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#ips Network#ips}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkIps" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ips", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ips
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls whether the network provides IPv6 support, as a boolean-like flag (`yes` or `no`).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#general-metadata">https://libvirt.org/formatnetwork.html#general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#ipv6 Network#ipv6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables configuring a fixed MAC address for the network bridge device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#mac Network#mac}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mac", typeJson: "{\"fqn\":\"libvirt.network.NetworkMac\"}", isOptional: true)]
            public libvirt.Network.INetworkMac? Mac
            {
                get => GetInstanceProperty<libvirt.Network.INetworkMac?>();
            }

            /// <summary>Provides an arbitrary metadata container for the virtual network, typically used by higher-level tools; content is user-defined XML.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#metadata Network#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"libvirt.network.NetworkMetadata\"}", isOptional: true)]
            public libvirt.Network.INetworkMetadata? Metadata
            {
                get => GetInstanceProperty<libvirt.Network.INetworkMetadata?>();
            }

            /// <summary>Configures an MTU definition block for the virtual network;</summary>
            /// <remarks>
            /// include this block only when you need to override the default MTU.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#mtu Network#mtu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mtu", typeJson: "{\"fqn\":\"libvirt.network.NetworkMtu\"}", isOptional: true)]
            public libvirt.Network.INetworkMtu? Mtu
            {
                get => GetInstanceProperty<libvirt.Network.INetworkMtu?>();
            }

            /// <summary>Defines one or more port groups that classify guest connections on this network, each with its own settings such as virtual port parameters or QoS.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#port_groups Network#port_groups}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkPortGroups" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkPortGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PortGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures default per-port options for this virtual network, such as isolating traffic between guests connected to the same network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#port_options Network#port_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portOptions", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortOptions\"}", isOptional: true)]
            public libvirt.Network.INetworkPortOptions? PortOptions
            {
                get => GetInstanceProperty<libvirt.Network.INetworkPortOptions?>();
            }

            /// <summary>Configures one or more static routes associated with this virtual network, informing the host about networks reachable via guests.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#routes Network#routes}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkRoutes" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Routes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls whether the network as a whole trusts guests' receive-side filtering settings, corresponding to the yes/no trustGuestRxFilters flag on the network definition.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#general-metadata">https://libvirt.org/formatnetwork.html#general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#trust_guest_rx_filters Network#trust_guest_rx_filters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trustGuestRxFilters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustGuestRxFilters
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures virtual port profile information for this port group, enabling integration with external network switching or SDN systems.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#virtual_port Network#virtual_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualPort", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPort\"}", isOptional: true)]
            public libvirt.Network.INetworkVirtualPort? VirtualPort
            {
                get => GetInstanceProperty<libvirt.Network.INetworkVirtualPort?>();
            }

            /// <summary>Configures VLAN tagging behavior for this portgroup, allowing one or more VLAN tags to be applied to guest connections when the underlying network supports VLAN offload.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#vlan Network#vlan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vlan", typeJson: "{\"fqn\":\"libvirt.network.NetworkVlan\"}", isOptional: true)]
            public libvirt.Network.INetworkVlan? Vlan
            {
                get => GetInstanceProperty<libvirt.Network.INetworkVlan?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
