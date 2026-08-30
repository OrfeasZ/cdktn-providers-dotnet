using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsNvRamSourceVhostUser), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceVhostUser")]
    public interface IDomainOsNvRamSourceVhostUser
    {
        /// <summary>Configures a D-Bus based source for the EGD backend when using a D-Bus-capable entropy provider;</summary>
        /// <remarks>
        /// the value is user-provided and backend-specific.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dbus Domain#dbus}
        /// </remarks>
        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserDbus\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceVhostUserDbus? Dbus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an EGD RNG backend that reads entropy from a host character device node.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserDev\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceVhostUserDev? Dev
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an EGD RNG backend that reads or writes entropy data via a regular host file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceVhostUserFile? File
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an EGD RNG backend that uses a FreeBSD nmdm pseudo-serial pair as the entropy transport.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nmdm Domain#nmdm}
        /// </remarks>
        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserNmdm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceVhostUserNmdm? Nmdm
        {
            get
            {
                return null;
            }
        }

        /// <summary>When set to true, uses a null character device as the vhost-user backing-store source, discarding all output and providing no input;</summary>
        /// <remarks>
        /// when false or unset, the null device is not used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#null-device">https://libvirt.org/formatdomain.html#null-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#null Domain#null}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "null", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Null
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host named pipe (FIFO) rather than a socket or other backend types.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pipe Domain#pipe}
        /// </remarks>
        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserPipe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceVhostUserPipe? Pipe
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host pseudo-TTY device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pty Domain#pty}
        /// </remarks>
        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserPty\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceVhostUserPty? Pty
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#qemu_vd_agent Domain#qemu_vd_agent}.</summary>
        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserQemuVdAgent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceVhostUserQemuVdAgent? QemuVdAgent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an RNG EGD backend that uses a SPICE port channel as the entropy source instead of direct host devices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spice_port Domain#spice_port}
        /// </remarks>
        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserSpicePort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceVhostUserSpicePort? SpicePort
        {
            get
            {
                return null;
            }
        }

        /// <summary>When set to true, exposes the vhost-user backing through a SPICE virtio-serial management channel (SpiceVMC);</summary>
        /// <remarks>
        /// when false or unset, the element is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#spice-channel">https://libvirt.org/formatdomain.html#spice-channel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spice_vmc Domain#spice_vmc}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "spiceVmc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SpiceVmc
        {
            get
            {
                return null;
            }
        }

        /// <summary>When set to true, connects the vhost-user backing to the domain’s standard I/O character device;</summary>
        /// <remarks>
        /// when false or unset, the StdIO element is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-interface">https://libvirt.org/formatdomain.html#host-interface</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#std_io Domain#std_io}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "stdIo", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StdIo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a TCP connection as the entropy source for the EGD RNG backend;</summary>
        /// <remarks>
        /// child attributes define host, port, mode, TLS, and optional reconnect behavior.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tcp Domain#tcp}
        /// </remarks>
        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserTcp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceVhostUserTcp? Tcp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a UDP connection as the entropy source for the EGD RNG backend, with bind/connect endpoints defined by child elements.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#udp Domain#udp}
        /// </remarks>
        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserUdp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceVhostUserUdp? Udp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a UNIX domain socket as the entropy source for the EGD RNG backend;</summary>
        /// <remarks>
        /// child attributes specify the socket path, mode, and optional reconnect policy.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unix Domain#unix}
        /// </remarks>
        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserUnix\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceVhostUserUnix? Unix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables use of a vhost-user communication mechanism compatible with a VC-style (versioned capability) endpoint for the disk mirror backing store;</summary>
        /// <remarks>
        /// when set true the VC element is emitted, when false or null it is omitted.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vc Domain#vc}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "vc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Vc
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsNvRamSourceVhostUser), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceVhostUser")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsNvRamSourceVhostUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures a D-Bus based source for the EGD backend when using a D-Bus-capable entropy provider;</summary>
            /// <remarks>
            /// the value is user-provided and backend-specific.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dbus Domain#dbus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserDbus\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceVhostUserDbus? Dbus
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceVhostUserDbus?>();
            }

            /// <summary>Configures an EGD RNG backend that reads entropy from a host character device node.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserDev\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceVhostUserDev? Dev
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceVhostUserDev?>();
            }

            /// <summary>Configures an EGD RNG backend that reads or writes entropy data via a regular host file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserFile\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceVhostUserFile? File
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceVhostUserFile?>();
            }

            /// <summary>Configures an EGD RNG backend that uses a FreeBSD nmdm pseudo-serial pair as the entropy transport.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nmdm Domain#nmdm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserNmdm\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceVhostUserNmdm? Nmdm
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceVhostUserNmdm?>();
            }

            /// <summary>When set to true, uses a null character device as the vhost-user backing-store source, discarding all output and providing no input;</summary>
            /// <remarks>
            /// when false or unset, the null device is not used.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#null-device">https://libvirt.org/formatdomain.html#null-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#null Domain#null}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "null", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Null
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host named pipe (FIFO) rather than a socket or other backend types.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pipe Domain#pipe}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserPipe\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceVhostUserPipe? Pipe
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceVhostUserPipe?>();
            }

            /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host pseudo-TTY device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pty Domain#pty}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserPty\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceVhostUserPty? Pty
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceVhostUserPty?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#qemu_vd_agent Domain#qemu_vd_agent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserQemuVdAgent\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceVhostUserQemuVdAgent? QemuVdAgent
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceVhostUserQemuVdAgent?>();
            }

            /// <summary>Configures an RNG EGD backend that uses a SPICE port channel as the entropy source instead of direct host devices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spice_port Domain#spice_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserSpicePort\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceVhostUserSpicePort? SpicePort
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceVhostUserSpicePort?>();
            }

            /// <summary>When set to true, exposes the vhost-user backing through a SPICE virtio-serial management channel (SpiceVMC);</summary>
            /// <remarks>
            /// when false or unset, the element is omitted.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#spice-channel">https://libvirt.org/formatdomain.html#spice-channel</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spice_vmc Domain#spice_vmc}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spiceVmc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SpiceVmc
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When set to true, connects the vhost-user backing to the domain’s standard I/O character device;</summary>
            /// <remarks>
            /// when false or unset, the StdIO element is omitted.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#host-interface">https://libvirt.org/formatdomain.html#host-interface</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#std_io Domain#std_io}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stdIo", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? StdIo
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures a TCP connection as the entropy source for the EGD RNG backend;</summary>
            /// <remarks>
            /// child attributes define host, port, mode, TLS, and optional reconnect behavior.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tcp Domain#tcp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserTcp\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceVhostUserTcp? Tcp
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceVhostUserTcp?>();
            }

            /// <summary>Configures a UDP connection as the entropy source for the EGD RNG backend, with bind/connect endpoints defined by child elements.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#udp Domain#udp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserUdp\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceVhostUserUdp? Udp
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceVhostUserUdp?>();
            }

            /// <summary>Configures a UNIX domain socket as the entropy source for the EGD RNG backend;</summary>
            /// <remarks>
            /// child attributes specify the socket path, mode, and optional reconnect policy.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unix Domain#unix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserUnix\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceVhostUserUnix? Unix
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceVhostUserUnix?>();
            }

            /// <summary>Enables use of a vhost-user communication mechanism compatible with a VC-style (versioned capability) endpoint for the disk mirror backing store;</summary>
            /// <remarks>
            /// when set true the VC element is emitted, when false or null it is omitted.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vc Domain#vc}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Vc
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
