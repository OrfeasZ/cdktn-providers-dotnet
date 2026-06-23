using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphics), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphics")]
    public interface IDomainDevicesGraphics
    {
        /// <summary>Configures an audio backend association for this graphics device, linking it to a specific &lt;audio&gt; definition by id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#audio Domain#audio}
        /// </remarks>
        [JsiiProperty(name: "audio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsAudio\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsAudio? Audio
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables a DBus-based display backend for the graphics device, allowing the display to be exported over DBus instead of a traditional VNC/SPICE socket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dbus Domain#dbus}
        /// </remarks>
        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDbus\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsDbus? Dbus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures desktop integration for the graphics device, such as exposing the guest window as a desktop surface on the host;</summary>
        /// <remarks>
        /// the specific value is user-provided according to the chosen graphics type.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#desktop Domain#desktop}
        /// </remarks>
        [JsiiProperty(name: "desktop", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDesktop\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsDesktop? Desktop
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables the egl-headless graphics backend, which provides a headless OpenGL-capable display surface without a visible window.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#egl_headless Domain#egl_headless}
        /// </remarks>
        [JsiiProperty(name: "eglHeadless", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsEglHeadless\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsEglHeadless? EglHeadless
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables an RDP graphics server for the guest and configures its RDP-specific options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rdp Domain#rdp}
        /// </remarks>
        [JsiiProperty(name: "rdp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsRdp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsRdp? Rdp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures an SDL graphics backend for the guest display;</summary>
        /// <remarks>
        /// when present, an SDL graphics device is attached to the domain.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sdl Domain#sdl}
        /// </remarks>
        [JsiiProperty(name: "sdl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSdl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsSdl? Sdl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures a SPICE graphics backend for the guest display;</summary>
        /// <remarks>
        /// when present, a SPICE graphics device is attached to the domain.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#spice Domain#spice}
        /// </remarks>
        [JsiiProperty(name: "spice", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpice\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsSpice? Spice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables a VNC graphics device for the guest and groups all VNC-specific options such as port, listeners, keyboard mapping, and connection policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vnc Domain#vnc}
        /// </remarks>
        [JsiiProperty(name: "vnc", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVnc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsVnc? Vnc
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphics), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphics")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures an audio backend association for this graphics device, linking it to a specific &lt;audio&gt; definition by id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#audio Domain#audio}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsAudio\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsAudio? Audio
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsAudio?>();
            }

            /// <summary>Enables a DBus-based display backend for the graphics device, allowing the display to be exported over DBus instead of a traditional VNC/SPICE socket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dbus Domain#dbus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDbus\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsDbus? Dbus
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsDbus?>();
            }

            /// <summary>Configures desktop integration for the graphics device, such as exposing the guest window as a desktop surface on the host;</summary>
            /// <remarks>
            /// the specific value is user-provided according to the chosen graphics type.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#desktop Domain#desktop}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "desktop", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDesktop\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsDesktop? Desktop
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsDesktop?>();
            }

            /// <summary>Enables the egl-headless graphics backend, which provides a headless OpenGL-capable display surface without a visible window.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#egl_headless Domain#egl_headless}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eglHeadless", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsEglHeadless\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsEglHeadless? EglHeadless
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsEglHeadless?>();
            }

            /// <summary>Enables an RDP graphics server for the guest and configures its RDP-specific options.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rdp Domain#rdp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rdp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsRdp\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsRdp? Rdp
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsRdp?>();
            }

            /// <summary>Enables and configures an SDL graphics backend for the guest display;</summary>
            /// <remarks>
            /// when present, an SDL graphics device is attached to the domain.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sdl Domain#sdl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sdl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSdl\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsSdl? Sdl
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsSdl?>();
            }

            /// <summary>Enables and configures a SPICE graphics backend for the guest display;</summary>
            /// <remarks>
            /// when present, a SPICE graphics device is attached to the domain.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#spice Domain#spice}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spice", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpice\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsSpice? Spice
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsSpice?>();
            }

            /// <summary>Enables a VNC graphics device for the guest and groups all VNC-specific options such as port, listeners, keyboard mapping, and connection policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vnc Domain#vnc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vnc", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVnc\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsVnc? Vnc
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsVnc?>();
            }
        }
    }
}
