using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesShmems")]
    public class DomainDevicesShmems : libvirt.Domain.IDomainDevicesShmems
    {
        /// <summary>Specifies the logical name of the shared memory region;</summary>
        /// <remarks>
        /// this must be unique across shmem devices and is used to match peers.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesShmemsAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesShmemsAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesShmemsAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesShmemsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesShmemsAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesShmemsAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Selects which shmem device model to use (e.g. "ivshmem-plain" or "ivshmem-doorbell") depending on the desired feature set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesShmemsModel\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesShmemsModel? Model
        {
            get;
            set;
        }

        /// <summary>Enables and configures MSI interrupt support for the shared memory device to signal events using MSI/MSI-X.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#msi Domain#msi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "msi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesShmemsMsi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesShmemsMsi? Msi
        {
            get;
            set;
        }

        /// <summary>Sets the device role in the shared memory configuration, typically "guest" or "host" style roles depending on model;</summary>
        /// <remarks>
        /// value is user-provided according to hypervisor support.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#role Domain#role}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Role
        {
            get;
            set;
        }

        /// <summary>Configures this shared memory device as a server endpoint, providing details about how the backing memory is hosted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#server Domain#server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "server", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesShmemsServer\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesShmemsServer? Server
        {
            get;
            set;
        }

        /// <summary>Sets the shared memory region size;</summary>
        /// <remarks>
        /// the value is user-provided and interpreted together with <c>size_unit</c> (for example, <c>1024</c> with unit <c>KiB</c>).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Size
        {
            get;
            set;
        }

        /// <summary>Sets the unit for the shared memory size (for example `B`, `KiB`, `MiB`, `GiB`);</summary>
        /// <remarks>
        /// if omitted, libvirt applies its own default unit.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size_unit Domain#size_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SizeUnit
        {
            get;
            set;
        }
    }
}
