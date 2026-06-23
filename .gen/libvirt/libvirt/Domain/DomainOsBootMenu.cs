using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainOsBootMenu")]
    public class DomainOsBootMenu : libvirt.Domain.IDomainOsBootMenu
    {
        /// <summary>Controls whether the firmware boot menu is enabled;</summary>
        /// <remarks>
        /// the value is a "yes"/"no" string flag. Example: "yes" to show the boot menu at startup.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enable Domain#enable}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Enable
        {
            get;
            set;
        }

        /// <summary>Sets the boot menu timeout in milliseconds before the firmware automatically continues boot;</summary>
        /// <remarks>
        /// the value is a non-negative integer. Example: 3000.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#timeout Domain#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timeout
        {
            get;
            set;
        }
    }
}
