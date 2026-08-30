using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainOsBios")]
    public class DomainOsBios : libvirt.Domain.IDomainOsBios
    {
        /// <summary>Sets the time in seconds that firmware waits in the boot menu before automatically rebooting or continuing boot;</summary>
        /// <remarks>
        /// the value is a non-negative integer. Example: 5000.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#reboot_timeout Domain#reboot_timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rebootTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RebootTimeout
        {
            get;
            set;
        }

        /// <summary>Controls whether the BIOS uses the serial console for input/output;</summary>
        /// <remarks>
        /// the value is a "yes"/"no" string flag. If unset, the hypervisor default is used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#use_serial Domain#use_serial}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useSerial", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UseSerial
        {
            get;
            set;
        }
    }
}
