using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesGraphicsSpiceStreaming")]
    public class DomainDevicesGraphicsSpiceStreaming : libvirt.Domain.IDomainDevicesGraphicsSpiceStreaming
    {
        /// <summary>Sets the SPICE display streaming mode (for example "filter", "all", or "off", depending on hypervisor support);</summary>
        /// <remarks>
        /// a mode value is required when streaming is configured.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }
    }
}
