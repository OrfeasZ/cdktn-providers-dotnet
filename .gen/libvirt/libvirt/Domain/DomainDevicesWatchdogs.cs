using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesWatchdogs")]
    public class DomainDevicesWatchdogs : libvirt.Domain.IDomainDevicesWatchdogs
    {
        /// <summary>Specifies the watchdog hardware model to emulate (for example, "i6300esb"), and is required when defining a watchdog device.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#watchdog-devices">https://libvirt.org/formatdomain.html#watchdog-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        public string Model
        {
            get;
            set;
        }

        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesWatchdogsAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesWatchdogsAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Selects the action to take when the watchdog fires, such as "reset", "poweroff", "dump", or "none", depending on hypervisor support.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#watchdog-devices">https://libvirt.org/formatdomain.html#watchdog-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#action Domain#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesWatchdogsAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesWatchdogsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesWatchdogsAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesWatchdogsAlias? Alias
        {
            get;
            set;
        }
    }
}
