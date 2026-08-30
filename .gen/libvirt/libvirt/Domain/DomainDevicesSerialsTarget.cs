using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesSerialsTarget")]
    public class DomainDevicesSerialsTarget : libvirt.Domain.IDomainDevicesSerialsTarget
    {
        /// <summary>Configures the hardware model of the serial port target, allowing selection of different emulated serial controller types where supported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsTargetModel\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesSerialsTargetModel? Model
        {
            get;
            set;
        }

        /// <summary>Sets the guest-visible serial port number starting from 0;</summary>
        /// <remarks>
        /// typically 0–3 depending on how many serial ports the guest OS supports.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#serial-port">https://libvirt.org/formatdomain.html#serial-port</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Selects the type of serial controller for this target;</summary>
        /// <remarks>
        /// valid values include "isa-serial", "pci-serial", "usb-serial", "spapr-vty", "sclp-serial", "sclplmconsole", and "system-serial".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#serial-port">https://libvirt.org/formatdomain.html#serial-port</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
