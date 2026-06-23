using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesGraphicsSpicePlayback")]
    public class DomainDevicesGraphicsSpicePlayback : libvirt.Domain.IDomainDevicesGraphicsSpicePlayback
    {
        /// <summary>Sets the audio compression mode for SPICE playback;</summary>
        /// <remarks>
        /// valid values are those supported by libvirt/QEMU (for example "on", "off", or codec-specific modes), and a value is required when the playback element is present.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#compression Domain#compression}
        /// </remarks>
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        public string Compression
        {
            get;
            set;
        }
    }
}
