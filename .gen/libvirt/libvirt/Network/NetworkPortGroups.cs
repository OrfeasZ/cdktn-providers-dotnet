using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkPortGroups")]
    public class NetworkPortGroups : libvirt.Network.INetworkPortGroups
    {
        /// <summary>Marks this port group as the default when guests do not explicitly select a port group;</summary>
        /// <remarks>
        /// value is a yes/no style flag (typically "yes" or "no").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#default Network#default}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }

        /// <summary>Sets the name of the port group, used by guest interfaces to select this group by reference;</summary>
        /// <remarks>
        /// value is user-provided and must be unique within the network.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#name Network#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Controls whether the network trusts receive-filter programming from guests attached via this port group;</summary>
        /// <remarks>
        /// value is a yes/no style flag ("yes" to trust, "no" to ignore).
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#trust_guest_rx_filters Network#trust_guest_rx_filters}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#virtual_port Network#virtual_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualPort", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPort\"}", isOptional: true)]
        public libvirt.Network.INetworkPortGroupsVirtualPort? VirtualPort
        {
            get;
            set;
        }

        /// <summary>Configures VLAN tagging behavior for this portgroup, allowing one or more VLAN tags to be applied to guest connections when the underlying network supports VLAN offload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#vlan Network#vlan}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vlan", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVlan\"}", isOptional: true)]
        public libvirt.Network.INetworkPortGroupsVlan? Vlan
        {
            get;
            set;
        }
    }
}
