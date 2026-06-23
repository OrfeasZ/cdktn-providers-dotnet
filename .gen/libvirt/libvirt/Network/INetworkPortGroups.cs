using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkPortGroups), fullyQualifiedName: "libvirt.network.NetworkPortGroups")]
    public interface INetworkPortGroups
    {
        /// <summary>Marks this port group as the default when guests do not explicitly select a port group;</summary>
        /// <remarks>
        /// value is a yes/no style flag (typically "yes" or "no").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#default Network#default}
        /// </remarks>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the name of the port group, used by guest interfaces to select this group by reference;</summary>
        /// <remarks>
        /// value is user-provided and must be unique within the network.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#name Network#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the network trusts receive-filter programming from guests attached via this port group;</summary>
        /// <remarks>
        /// value is a yes/no style flag ("yes" to trust, "no" to ignore).
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#trust_guest_rx_filters Network#trust_guest_rx_filters}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#virtual_port Network#virtual_port}
        /// </remarks>
        [JsiiProperty(name: "virtualPort", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkPortGroupsVirtualPort? VirtualPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures VLAN tagging behavior for this portgroup, allowing one or more VLAN tags to be applied to guest connections when the underlying network supports VLAN offload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#vlan Network#vlan}
        /// </remarks>
        [JsiiProperty(name: "vlan", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVlan\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkPortGroupsVlan? Vlan
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkPortGroups), fullyQualifiedName: "libvirt.network.NetworkPortGroups")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkPortGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Marks this port group as the default when guests do not explicitly select a port group;</summary>
            /// <remarks>
            /// value is a yes/no style flag (typically "yes" or "no").
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#default Network#default}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the name of the port group, used by guest interfaces to select this group by reference;</summary>
            /// <remarks>
            /// value is user-provided and must be unique within the network.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#name Network#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the network trusts receive-filter programming from guests attached via this port group;</summary>
            /// <remarks>
            /// value is a yes/no style flag ("yes" to trust, "no" to ignore).
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#trust_guest_rx_filters Network#trust_guest_rx_filters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trustGuestRxFilters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustGuestRxFilters
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures virtual port profile information for this port group, enabling integration with external network switching or SDN systems.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#virtual_port Network#virtual_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualPort", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPort\"}", isOptional: true)]
            public libvirt.Network.INetworkPortGroupsVirtualPort? VirtualPort
            {
                get => GetInstanceProperty<libvirt.Network.INetworkPortGroupsVirtualPort?>();
            }

            /// <summary>Configures VLAN tagging behavior for this portgroup, allowing one or more VLAN tags to be applied to guest connections when the underlying network supports VLAN offload.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#vlan Network#vlan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vlan", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVlan\"}", isOptional: true)]
            public libvirt.Network.INetworkPortGroupsVlan? Vlan
            {
                get => GetInstanceProperty<libvirt.Network.INetworkPortGroupsVlan?>();
            }
        }
    }
}
