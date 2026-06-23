using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesGraphicsSpiceGl")]
    public class DomainDevicesGraphicsSpiceGl : libvirt.Domain.IDomainDevicesGraphicsSpiceGl
    {
        /// <summary>Controls whether OpenGL/3D rendering is enabled for SPICE (for example, via virgl); accepts "yes" or "no".</summary>
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

        /// <summary>Sets the host render node device path that SPICE should use for OpenGL rendering when GL is enabled (user-provided path such as `/dev/dri/renderD128`).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#render_node Domain#render_node}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renderNode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RenderNode
        {
            get;
            set;
        }
    }
}
