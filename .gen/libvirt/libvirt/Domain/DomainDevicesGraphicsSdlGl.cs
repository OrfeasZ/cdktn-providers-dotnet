using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesGraphicsSdlGl")]
    public class DomainDevicesGraphicsSdlGl : libvirt.Domain.IDomainDevicesGraphicsSdlGl
    {
        /// <summary>Controls whether OpenGL rendering is enabled for the SDL graphics backend; accepts "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
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
    }
}
