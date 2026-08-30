using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInputs")]
    public class DomainDevicesInputs : libvirt.Domain.IDomainDevicesInputs
    {
        /// <summary>Sets the type of input device attached to the guest (for example, tablet, mouse, keyboard);</summary>
        /// <remarks>
        /// value is user-provided and must be supported by the chosen hypervisor. Example: "tablet" for a USB graphics-tablet-style pointing device.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInputsAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInputsAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInputsAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInputsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInputsAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInputsAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Selects the bus on which the input device is exposed to the guest, such as "ps2", "usb", "virtio", or "xen" depending on the guest type and model.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bus Domain#bus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bus
        {
            get;
            set;
        }

        /// <summary>Configures optional driver-specific settings for this input device, including virtio transport options when using a virtio-based model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInputsDriver\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInputsDriver? Driver
        {
            get;
            set;
        }

        /// <summary>Selects the emulated input device model (for example, "ps2", "usb-tablet", "virtio-mouse", or "virtio-keyboard"), determining how the guest OS sees this input device.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
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

        /// <summary>Configures the host-side source backing this input device, such as an evdev device or passthrough from a host input device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInputsSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInputsSource? Source
        {
            get;
            set;
        }
    }
}
