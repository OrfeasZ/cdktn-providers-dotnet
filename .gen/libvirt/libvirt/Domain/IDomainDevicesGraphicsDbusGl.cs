using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsDbusGl), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsDbusGl")]
    public interface IDomainDevicesGraphicsDbusGl
    {
        /// <summary>Controls whether OpenGL acceleration is enabled for the DBus graphics backend; valid values are "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enable Domain#enable}
        /// </remarks>
        [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Enable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the host render node device path used for GL rendering (for example, "/dev/dri/renderD128");</summary>
        /// <remarks>
        /// the value is user-provided and must refer to an existing render node.
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsDbusGl), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsDbusGl")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsDbusGl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether OpenGL acceleration is enabled for the DBus graphics backend; valid values are "yes" or "no".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enable Domain#enable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Enable
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the host render node device path used for GL rendering (for example, "/dev/dri/renderD128");</summary>
            /// <remarks>
            /// the value is user-provided and must refer to an existing render node.
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
