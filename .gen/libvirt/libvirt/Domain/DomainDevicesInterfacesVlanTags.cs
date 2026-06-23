using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesVlanTags")]
    public class DomainDevicesInterfacesVlanTags : libvirt.Domain.IDomainDevicesInterfacesVlanTags
    {
        /// <summary>Sets the VLAN ID associated with this tag;</summary>
        /// <remarks>
        /// value is user-provided and must be a valid VLAN tag for the interface configuration.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public double Id
        {
            get;
            set;
        }

        /// <summary>Sets how this VLAN tag is treated as the native (untagged) VLAN on the port, using user-provided values such as "tagged" or "untagged" depending on hypervisor support.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#native_mode Domain#native_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nativeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NativeMode
        {
            get;
            set;
        }
    }
}
