using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesGraphicsSpiceZlib")]
    public class DomainDevicesGraphicsSpiceZlib : libvirt.Domain.IDomainDevicesGraphicsSpiceZlib
    {
        /// <summary>Sets the zlib compression policy for SPICE image data (for example "always", "never", or "auto", depending on hypervisor support);</summary>
        /// <remarks>
        /// a value is required when the zlib element is present.
        ///
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
