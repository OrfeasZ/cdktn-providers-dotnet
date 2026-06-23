using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkPortGroupsVirtualPortParamsOpenVSwitch")]
    public class NetworkPortGroupsVirtualPortParamsOpenVSwitch : libvirt.Network.INetworkPortGroupsVirtualPortParamsOpenVSwitch
    {
        /// <summary>Sets the Open vSwitch interface identifier (interfaceid) for ports in this portgroup;</summary>
        /// <remarks>
        /// value is user-provided and typically matches the UUID or name expected by the OVS integration on the host.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#interface_id Network#interface_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InterfaceId
        {
            get;
            set;
        }

        /// <summary>Sets the Open vSwitch profile identifier (profileid) for ports in this portgroup;</summary>
        /// <remarks>
        /// value is user-provided and used by OVS or higher-level controllers to apply a specific port profile.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#profile_id Network#profile_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProfileId
        {
            get;
            set;
        }
    }
}
