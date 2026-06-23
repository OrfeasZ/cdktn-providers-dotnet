using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesRom")]
    public class DomainDevicesInterfacesRom : libvirt.Domain.IDomainDevicesInterfacesRom
    {
        /// <summary>Controls whether the device’s ROM is exposed in PCI BAR space, typically "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#interface-rom-bios-configuration">https://libvirt.org/formatdomain.html#interface-rom-bios-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bar Domain#bar}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bar", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bar
        {
            get;
            set;
        }

        /// <summary>Enables or disables use of the ROM image for the host device, as a user-provided string flag (for example, "on"/"off" or "yes"/"no" depending on libvirt expectations).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#interface-rom-bios-configuration">https://libvirt.org/formatdomain.html#interface-rom-bios-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Enabled
        {
            get;
            set;
        }

        /// <summary>Specifies a path to a custom ROM file to use for the passthrough device (for example, "/usr/share/roms/nic.rom"); value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#interface-rom-bios-configuration">https://libvirt.org/formatdomain.html#interface-rom-bios-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? File
        {
            get;
            set;
        }
    }
}
