using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsRdp), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsRdp")]
    public interface IDomainDevicesGraphicsRdp
    {
        /// <summary>Controls whether the RDP server port is chosen automatically ("yes") or must be specified explicitly ("no");</summary>
        /// <remarks>
        /// this is a string-to-boolean flag.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auto_port Domain#auto_port}
        /// </remarks>
        [JsiiProperty(name: "autoPort", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets a single listen address or special value (such as "0.0.0.0") for the RDP server; value is user-provided and used when listener sub-elements are not used.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#listen Domain#listen}
        /// </remarks>
        [JsiiProperty(name: "listen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Listen
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more listener endpoints for the RDP server (by address, network, or UNIX socket), overriding the simple listen attribute when present.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#listeners Domain#listeners}
        /// </remarks>
        [JsiiProperty(name: "listeners", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsRdpListeners\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Listeners
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the RDP server allows multiple simultaneous clients ("yes") or restricts access to a single client ("no");</summary>
        /// <remarks>
        /// the value is user-provided as "yes"/"no".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#multi_user Domain#multi_user}
        /// </remarks>
        [JsiiProperty(name: "multiUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MultiUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the password required to connect to the RDP server;</summary>
        /// <remarks>
        /// the value is user-provided and may be empty to allow passwordless access, depending on hypervisor policy.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#passwd Domain#passwd}
        /// </remarks>
        [JsiiProperty(name: "passwd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Passwd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the TCP port number on which the RDP server listens (for example, 3389);</summary>
        /// <remarks>
        /// must be a valid unused TCP port when auto_port is "no".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether a new RDP client connection replaces the currently connected user ("yes") or is refused when a client is already connected ("no");</summary>
        /// <remarks>
        /// value is user-provided as "yes"/"no".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#replace_user Domain#replace_user}
        /// </remarks>
        [JsiiProperty(name: "replaceUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplaceUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the username used by the RDP graphics backend for client authentication; the value is user-provided and backend-specific.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#username Domain#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsRdp), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsRdp")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsRdp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether the RDP server port is chosen automatically ("yes") or must be specified explicitly ("no");</summary>
            /// <remarks>
            /// this is a string-to-boolean flag.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auto_port Domain#auto_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoPort", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoPort
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets a single listen address or special value (such as "0.0.0.0") for the RDP server; value is user-provided and used when listener sub-elements are not used.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#listen Domain#listen}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "listen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Listen
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines one or more listener endpoints for the RDP server (by address, network, or UNIX socket), overriding the simple listen attribute when present.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#listeners Domain#listeners}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "listeners", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsRdpListeners\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Listeners
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls whether the RDP server allows multiple simultaneous clients ("yes") or restricts access to a single client ("no");</summary>
            /// <remarks>
            /// the value is user-provided as "yes"/"no".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#multi_user Domain#multi_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "multiUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MultiUser
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the password required to connect to the RDP server;</summary>
            /// <remarks>
            /// the value is user-provided and may be empty to allow passwordless access, depending on hypervisor policy.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#passwd Domain#passwd}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Passwd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the TCP port number on which the RDP server listens (for example, 3389);</summary>
            /// <remarks>
            /// must be a valid unused TCP port when auto_port is "no".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port Domain#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Controls whether a new RDP client connection replaces the currently connected user ("yes") or is refused when a client is already connected ("no");</summary>
            /// <remarks>
            /// value is user-provided as "yes"/"no".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#replace_user Domain#replace_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replaceUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplaceUser
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the username used by the RDP graphics backend for client authentication; the value is user-provided and backend-specific.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#username Domain#username}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
