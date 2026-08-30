using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesMemorydevs")]
    public class DomainDevicesMemorydevs : libvirt.Domain.IDomainDevicesMemorydevs
    {
        /// <summary>Selects the memory device model, such as "dimm", "nvdimm", "virtio-mem", or "virtio-pmem", determining how the guest sees and manages this memory;</summary>
        /// <remarks>
        /// the value must be one of the models supported by libvirt/QEMU.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        public string Model
        {
            get;
            set;
        }

        /// <summary>Sets the access mode for the memory device (for example, "shared" or "private") controlling whether memory can be shared between guests/host;</summary>
        /// <remarks>
        /// value must be one of the access modes supported by libvirt for memory devices.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#access Domain#access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Access
        {
            get;
            set;
        }

        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemorydevsAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesMemorydevsAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemorydevsAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesMemorydevsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemorydevsAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesMemorydevsAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Controls whether discarded/trimmed guest memory for this device is actually discarded (e.g. "yes"/"no" depending on model); the exact accepted values are model‑specific and user‑provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#discard Domain#discard}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "discard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Discard
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemorydevsDriver\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesMemorydevsDriver? Driver
        {
            get;
            set;
        }

        /// <summary>Defines the source backing for the memory device, such as a file, block device, or host NUMA configuration, depending on the chosen model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemorydevsSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesMemorydevsSource? Source
        {
            get;
            set;
        }

        /// <summary>Describes how the memory device is presented to the guest, including label/namespace, size, and NUMA placement depending on model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemorydevsTarget\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesMemorydevsTarget? Target
        {
            get;
            set;
        }

        /// <summary>Exposes the libvirt-assigned UUID of the memory device;</summary>
        /// <remarks>
        /// this value is computed by libvirt and cannot be set by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#uuid Domain#uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }
    }
}
