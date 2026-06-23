using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceHostdevPci")]
    public class DomainDevicesInterfacesSourceHostdevPci : libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPci
    {
        /// <summary>Defines the host PCI address of the device to passthrough, typically via domain, bus, slot, and function (and optional zPCI info on s390x).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddress? Address
        {
            get;
            set;
        }

        /// <summary>Controls whether write filtering is enabled for a PCI passthrough device, typically to restrict or filter MMIO/PCI configuration writes;</summary>
        /// <remarks>
        /// accepts user-provided value as defined by libvirt (for example "on" or "off").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#write_filtering Domain#write_filtering}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "writeFiltering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WriteFiltering
        {
            get;
            set;
        }
    }
}
