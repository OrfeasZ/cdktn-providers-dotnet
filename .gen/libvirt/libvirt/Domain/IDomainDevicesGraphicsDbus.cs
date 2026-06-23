using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsDbus), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsDbus")]
    public interface IDomainDevicesGraphicsDbus
    {
        /// <summary>Sets the DBus address (bus or endpoint string) that the graphics device uses for its DBus display connection;</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures OpenGL acceleration options for the DBus graphics backend, including whether GL is enabled and which render node to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gl Domain#gl}
        /// </remarks>
        [JsiiProperty(name: "gl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDbusGl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsDbusGl? Gl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether peer-to-peer DBus connections are used for the graphics device; valid values are "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#p2p Domain#p2p}
        /// </remarks>
        [JsiiProperty(name: "p2P", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? P2P
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsDbus), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsDbus")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsDbus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the DBus address (bus or endpoint string) that the graphics device uses for its DBus display connection;</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures OpenGL acceleration options for the DBus graphics backend, including whether GL is enabled and which render node to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gl Domain#gl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDbusGl\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsDbusGl? Gl
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsDbusGl?>();
            }

            /// <summary>Controls whether peer-to-peer DBus connections are used for the graphics device; valid values are "yes" or "no".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#p2p Domain#p2p}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "p2P", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? P2P
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
