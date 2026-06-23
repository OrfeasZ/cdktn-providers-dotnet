using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesVideosModelAccel), fullyQualifiedName: "libvirt.domain.DomainDevicesVideosModelAccel")]
    public interface IDomainDevicesVideosModelAccel
    {
        /// <summary>Enables or disables 2D acceleration for the video device model;</summary>
        /// <remarks>
        /// values are typically <c>yes</c>/<c>no</c> or <c>on</c>/<c>off</c> depending on libvirt version.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#accel2d Domain#accel2d}
        /// </remarks>
        [JsiiProperty(name: "accel2D", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Accel2D
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures whether 3D acceleration is enabled for the video device model; accepts the string values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#accel3d Domain#accel3d}
        /// </remarks>
        [JsiiProperty(name: "accel3D", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Accel3D
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the render node path used for hardware-accelerated rendering by the video device (for example "/dev/dri/renderD128");</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#render_node Domain#render_node}
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesVideosModelAccel), fullyQualifiedName: "libvirt.domain.DomainDevicesVideosModelAccel")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesVideosModelAccel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables or disables 2D acceleration for the video device model;</summary>
            /// <remarks>
            /// values are typically <c>yes</c>/<c>no</c> or <c>on</c>/<c>off</c> depending on libvirt version.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#accel2d Domain#accel2d}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accel2D", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Accel2D
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures whether 3D acceleration is enabled for the video device model; accepts the string values "on" or "off".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#accel3d Domain#accel3d}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accel3D", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Accel3D
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the render node path used for hardware-accelerated rendering by the video device (for example "/dev/dri/renderD128");</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#render_node Domain#render_node}
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
