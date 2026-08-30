using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesConsoles")]
    public class DomainDevicesConsoles : libvirt.Domain.IDomainDevicesConsoles
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Enables logging of data sent through the channel to a host file and configures how that logging behaves.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#log Domain#log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "log", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesLog\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesLog? Log
        {
            get;
            set;
        }

        /// <summary>Configures the transport protocol used by the EGD backend connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#protocol Domain#protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesProtocol\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesProtocol? Protocol
        {
            get;
            set;
        }

        /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSource? Source
        {
            get;
            set;
        }

        /// <summary>Configures how the console appears inside the guest (e.g. which guest console/serial port it is attached to).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesTarget\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesTarget? Target
        {
            get;
            set;
        }

        /// <summary>Records or overrides the host-side TTY or device path associated with this console (for example "/dev/pts/3"); value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pseudo-tty">https://libvirt.org/formatdomain.html#pseudo-tty</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tty Domain#tty}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tty", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tty
        {
            get;
            set;
        }
    }
}
