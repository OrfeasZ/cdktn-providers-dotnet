using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddressZpci")]
    public class DomainDevicesInterfacesSourceHostdevPciAddressZpci : libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddressZpci
    {
        /// <summary>Sets the function ID (fid) for a zPCI device on s390x, identifying the specific zPCI function to passthrough;</summary>
        /// <remarks>
        /// the value is user-provided and must match the host's zPCI configuration.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fid Domain#fid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Fid
        {
            get;
            set;
        }

        /// <summary>Sets the zPCI function UID for a passed-through PCI device on s390x, identifying the zPCI function within the guest;</summary>
        /// <remarks>
        /// the value is user-provided and must match the host zPCI configuration.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#uid Domain#uid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Uid
        {
            get;
            set;
        }
    }
}
