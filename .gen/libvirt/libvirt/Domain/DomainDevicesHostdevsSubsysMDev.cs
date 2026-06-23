using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysMDev")]
    public class DomainDevicesHostdevsSubsysMDev : libvirt.Domain.IDomainDevicesHostdevsSubsysMDev
    {
        /// <summary>Sets how display output of a mediated (mdev) device is exposed to the guest;</summary>
        /// <remarks>
        /// the value is user-provided and backend-specific (for example, selecting a particular vGPU display mode).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#display Domain#display}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Display
        {
            get;
            set;
        }

        /// <summary>Sets the mediated device (mdev) model for this hostdev, identifying which virtual function or vGPU type is exposed to the guest;</summary>
        /// <remarks>
        /// the value is user-provided and must match a model supported by the host driver (for example, an NVIDIA vGPU type name).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Model
        {
            get;
            set;
        }

        /// <summary>Controls whether a frame buffer (ramfb) is created for this mediated device;</summary>
        /// <remarks>
        /// accepts "on"/"off" as yes/no flags when supported by the host driver.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ram_fb Domain#ram_fb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ramFb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RamFb
        {
            get;
            set;
        }

        /// <summary>Groups the source configuration for the mediated device passed through to the guest, such as its unique address on the host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysMDevSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysMDevSource? Source
        {
            get;
            set;
        }
    }
}
