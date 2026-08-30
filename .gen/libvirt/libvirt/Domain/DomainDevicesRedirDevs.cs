using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesRedirDevs")]
    public class DomainDevicesRedirDevs : libvirt.Domain.IDomainDevicesRedirDevs
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRedirDevsAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRedirDevsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRedirDevsAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Enables boot-order control for this redirected device, allowing it to participate in the device boot sequence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#boot Domain#boot}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsBoot\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRedirDevsBoot? Boot
        {
            get;
            set;
        }

        /// <summary>Selects the bus type used by the redirected device, typically "usb" for USB redirection as required by libvirt;</summary>
        /// <remarks>
        /// other values are not supported for redirdev.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
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

        /// <summary>Configures the transport protocol used by the EGD backend connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#protocol Domain#protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsProtocol\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRedirDevsProtocol? Protocol
        {
            get;
            set;
        }

        /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRedirDevsSource? Source
        {
            get;
            set;
        }
    }
}
