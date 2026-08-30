using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsEglHeadlessGl), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsEglHeadlessGl")]
    public interface IDomainDevicesGraphicsEglHeadlessGl
    {
        /// <summary>Sets the DRM render node path to use for EGL/GL rendering with egl-headless (for example, "/dev/dri/renderD128");</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#render_node Domain#render_node}
        /// </remarks>
        [JsiiProperty(name: "renderNode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RenderNode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsEglHeadlessGl), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsEglHeadlessGl")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsEglHeadlessGl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the DRM render node path to use for EGL/GL rendering with egl-headless (for example, "/dev/dri/renderD128");</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#render_node Domain#render_node}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renderNode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RenderNode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
