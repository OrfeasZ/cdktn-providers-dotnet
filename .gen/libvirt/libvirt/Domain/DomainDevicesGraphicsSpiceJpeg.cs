using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesGraphicsSpiceJpeg")]
    public class DomainDevicesGraphicsSpiceJpeg : libvirt.Domain.IDomainDevicesGraphicsSpiceJpeg
    {
        /// <summary>Sets the SPICE JPEG compression policy, typically one of `auto`, `never`, or `always`, controlling when JPEG is used for image encoding.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#compression Domain#compression}
        /// </remarks>
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        public string Compression
        {
            get;
            set;
        }
    }
}
