using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsOpenVSwitch")]
    public class DomainDevicesInterfacesVirtualPortParamsOpenVSwitch : libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsOpenVSwitch
    {
        /// <summary>Sets the Open vSwitch interface identifier for this NIC, typically matching the external port identifier known to OVS (for example, a UUID string).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#interface_id Domain#interface_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InterfaceId
        {
            get;
            set;
        }

        /// <summary>Sets the Open vSwitch profile identifier for this virtual port, used by OVS or its controller;</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#profile_id Domain#profile_id}
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
