using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesControllers")]
    public class DomainDevicesControllers : libvirt.Domain.IDomainDevicesControllers
    {
        /// <summary>Sets the controller type for this entry;</summary>
        /// <remarks>
        /// must be one of the supported controller buses such as "pci", "usb", "virtio-serial", "scsi", "ide", "nvme", or "xenbus" depending on usage.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Configures driver-specific options for the controller, such as virtio transport features and queue parameters;</summary>
        /// <remarks>
        /// all child attributes are optional and user-defined within hypervisor constraints.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriver\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersDriver? Driver
        {
            get;
            set;
        }

        /// <summary>Sets the controller index number used to distinguish multiple controllers of the same type;</summary>
        /// <remarks>
        /// value is a non-negative integer and must be unique per controller type.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#index Domain#index}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Index
        {
            get;
            set;
        }

        /// <summary>Selects the controller model (for example "virtio-scsi", "pci-root", "pcie-root-port", "ide", "usb") as supported by the hypervisor and guest;</summary>
        /// <remarks>
        /// value is a user-provided model name that must be valid for the chosen controller type.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
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

        /// <summary>Configures an NVMe controller device for the guest, allowing you to add and customize an NVMe bus for NVMe disks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nvme Domain#nvme}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nvme", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersNvme\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersNvme? Nvme
        {
            get;
            set;
        }

        /// <summary>Configures a PCI or PCIe controller, controlling how PCI buses are exposed to the guest for attaching PCI devices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pci Domain#pci}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pci", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersPci\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersPci? Pci
        {
            get;
            set;
        }

        /// <summary>Configures a USB controller for the guest, defining how USB ports and hubs are exposed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#usb Domain#usb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usb", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersUsb\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersUsb? Usb
        {
            get;
            set;
        }

        /// <summary>Configures a virtio-serial controller, which provides multiple virtio-based serial or channel ports to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#virt_io_serial Domain#virt_io_serial}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtIoSerial", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersVirtIoSerial\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersVirtIoSerial? VirtIoSerial
        {
            get;
            set;
        }

        /// <summary>Configures a Xen bus controller, which provides bus resources for Xen paravirtualized devices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#xen_bus Domain#xen_bus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xenBus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersXenBus\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersXenBus? XenBus
        {
            get;
            set;
        }
    }
}
