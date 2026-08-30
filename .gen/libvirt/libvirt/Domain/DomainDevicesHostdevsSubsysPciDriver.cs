using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysPciDriver")]
    public class DomainDevicesHostdevsSubsysPciDriver : libvirt.Domain.IDomainDevicesHostdevsSubsysPciDriver
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iommu_fd Domain#iommu_fd}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iommuFd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IommuFd
        {
            get;
            set;
        }

        /// <summary>Sets the model of the guest-side driver used for this PCI hostdev;</summary>
        /// <remarks>
        /// the value is user-provided and must be a model supported by the hypervisor for PCI passthrough.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Model
        {
            get;
            set;
        }

        /// <summary>Specifies the host-side kernel driver name to bind for this PCI device (for example, "vfio-pci");</summary>
        /// <remarks>
        /// the value is user-provided and must match a valid driver on the host.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
