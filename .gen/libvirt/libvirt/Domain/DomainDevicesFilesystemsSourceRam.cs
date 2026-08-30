using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsSourceRam")]
    public class DomainDevicesFilesystemsSourceRam : libvirt.Domain.IDomainDevicesFilesystemsSourceRam
    {
        /// <summary>Sets the size of the RAM-backed filesystem in the specified units (or libvirt default units);</summary>
        /// <remarks>
        /// value is user-provided and must be a positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#usage Domain#usage}
        /// </remarks>
        [JsiiProperty(name: "usage", typeJson: "{\"primitive\":\"number\"}")]
        public double Usage
        {
            get;
            set;
        }

        /// <summary>Sets the units for the RAM filesystem `usage` value, such as `KB`, `MB`, or `GB`;</summary>
        /// <remarks>
        /// if omitted, libvirt uses its default unit handling.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#units Domain#units}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "units", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Units
        {
            get;
            set;
        }
    }
}
