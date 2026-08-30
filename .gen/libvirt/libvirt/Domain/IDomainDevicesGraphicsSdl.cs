using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsSdl), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSdl")]
    public interface IDomainDevicesGraphicsSdl
    {
        /// <summary>Sets the SDL display identifier (for example, ":0.0") on which the SDL window is opened; the value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#display Domain#display}
        /// </remarks>
        [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Display
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the SDL window starts in fullscreen mode; accepts "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#full_screen Domain#full_screen}
        /// </remarks>
        [JsiiProperty(name: "fullScreen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FullScreen
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of OpenGL support for the SDL graphics backend; when present, it toggles SDL OpenGL rendering options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#gl Domain#gl}
        /// </remarks>
        [JsiiProperty(name: "gl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSdlGl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsSdlGl? Gl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the X11 authorization file or token used by SDL to connect to the X server;</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xauth Domain#xauth}
        /// </remarks>
        [JsiiProperty(name: "xauth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Xauth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsSdl), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSdl")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsSdl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the SDL display identifier (for example, ":0.0") on which the SDL window is opened; the value is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#display Domain#display}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Display
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the SDL window starts in fullscreen mode; accepts "yes" or "no".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#full_screen Domain#full_screen}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fullScreen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FullScreen
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables configuration of OpenGL support for the SDL graphics backend; when present, it toggles SDL OpenGL rendering options.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#gl Domain#gl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSdlGl\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsSdlGl? Gl
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsSdlGl?>();
            }

            /// <summary>Sets the X11 authorization file or token used by SDL to connect to the X server;</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xauth Domain#xauth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xauth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Xauth
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
