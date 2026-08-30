using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsVnc), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsVnc")]
    public interface IDomainDevicesGraphicsVnc
    {
        /// <summary>Controls whether the VNC server automatically chooses a TCP port;</summary>
        /// <remarks>
        /// this is a string-valued boolean where "yes" enables automatic port selection and "no" disables it.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#auto_port Domain#auto_port}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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

        /// <summary>Sets the initial connection policy for VNC (for example "keep", "fail", or "disconnect" as supported by libvirt) indicating how the guest should behave when a client is or is not connected.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#connected Domain#connected}
        /// </remarks>
        [JsiiProperty(name: "connected", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Connected
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the keymap layout used for keyboard input over VNC;</summary>
        /// <remarks>
        /// value is a user-provided keymap name such as "en-us" or "de".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#keymap Domain#keymap}
        /// </remarks>
        [JsiiProperty(name: "keymap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Keymap
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures how the VNC server listens for client connections, either as a simple address attribute or via child listener elements.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#listen Domain#listen}
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

        /// <summary>Provides one or more explicit VNC listen endpoints (address, network, or Unix socket) instead of a single listen address attribute.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#listeners Domain#listeners}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesGraphicsVncListeners" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "listeners", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListeners\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Listeners
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the VNC password required for clients to connect to this graphics device;</summary>
        /// <remarks>
        /// the value is user-provided and should follow any security policies you enforce for secrets. Example: "S3cr3tP@ss".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passwd Domain#passwd}
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

        /// <summary>Sets an absolute expiry time for the VNC password, after which the password is no longer valid;</summary>
        /// <remarks>
        /// the format is a user-provided timestamp string as expected by libvirt/qemu.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passwd_valid_to Domain#passwd_valid_to}
        /// </remarks>
        [JsiiProperty(name: "passwdValidTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswdValidTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the TCP port on which the VNC server listens;</summary>
        /// <remarks>
        /// use -1 or omit to let libvirt automatically choose an available port, or specify an integer port such as 5900.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
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

        /// <summary>Enables or disables guest power control over the VNC session; accepts "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#power_control Domain#power_control}
        /// </remarks>
        [JsiiProperty(name: "powerControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PowerControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls how VNC connections are shared between clients; valid values are "allow-exclusive", "force-shared", or "ignore".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#share_policy Domain#share_policy}
        /// </remarks>
        [JsiiProperty(name: "sharePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SharePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the path to a UNIX domain socket to use instead of a TCP port for the VNC server;</summary>
        /// <remarks>
        /// the value is a user-provided filesystem path (for example, "/var/run/libvirt/qemu-vnc.sock").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#socket Domain#socket}
        /// </remarks>
        [JsiiProperty(name: "socket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Socket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#wait Domain#wait}.</summary>
        [JsiiProperty(name: "wait", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Wait
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the TCP port for the VNC WebSocket proxy, allowing browser-based VNC clients to connect;</summary>
        /// <remarks>
        /// use -1 or omit to auto-assign, or specify an integer port.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#web_socket Domain#web_socket}
        /// </remarks>
        [JsiiProperty(name: "webSocket", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WebSocket
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsVnc), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsVnc")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsVnc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether the VNC server automatically chooses a TCP port;</summary>
            /// <remarks>
            /// this is a string-valued boolean where "yes" enables automatic port selection and "no" disables it.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#auto_port Domain#auto_port}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoPort", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoPort
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the initial connection policy for VNC (for example "keep", "fail", or "disconnect" as supported by libvirt) indicating how the guest should behave when a client is or is not connected.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#connected Domain#connected}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connected", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Connected
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the keymap layout used for keyboard input over VNC;</summary>
            /// <remarks>
            /// value is a user-provided keymap name such as "en-us" or "de".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#keymap Domain#keymap}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keymap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Keymap
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures how the VNC server listens for client connections, either as a simple address attribute or via child listener elements.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#listen Domain#listen}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "listen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Listen
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provides one or more explicit VNC listen endpoints (address, network, or Unix socket) instead of a single listen address attribute.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#listeners Domain#listeners}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesGraphicsVncListeners" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "listeners", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListeners\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Listeners
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the VNC password required for clients to connect to this graphics device;</summary>
            /// <remarks>
            /// the value is user-provided and should follow any security policies you enforce for secrets. Example: "S3cr3tP@ss".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passwd Domain#passwd}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Passwd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets an absolute expiry time for the VNC password, after which the password is no longer valid;</summary>
            /// <remarks>
            /// the format is a user-provided timestamp string as expected by libvirt/qemu.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passwd_valid_to Domain#passwd_valid_to}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwdValidTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswdValidTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the TCP port on which the VNC server listens;</summary>
            /// <remarks>
            /// use -1 or omit to let libvirt automatically choose an available port, or specify an integer port such as 5900.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Enables or disables guest power control over the VNC session; accepts "yes" or "no".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#power_control Domain#power_control}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "powerControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PowerControl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls how VNC connections are shared between clients; valid values are "allow-exclusive", "force-shared", or "ignore".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#share_policy Domain#share_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sharePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SharePolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the path to a UNIX domain socket to use instead of a TCP port for the VNC server;</summary>
            /// <remarks>
            /// the value is a user-provided filesystem path (for example, "/var/run/libvirt/qemu-vnc.sock").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#socket Domain#socket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "socket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Socket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#wait Domain#wait}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "wait", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Wait
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the TCP port for the VNC WebSocket proxy, allowing browser-based VNC clients to connect;</summary>
            /// <remarks>
            /// use -1 or omit to auto-assign, or specify an integer port.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#web_socket Domain#web_socket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webSocket", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WebSocket
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
