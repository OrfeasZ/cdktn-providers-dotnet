using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsNvRamSourceReservationsSource), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceReservationsSource")]
    public interface IDomainOsNvRamSourceReservationsSource
    {
        /// <summary>Configures a D-Bus based source for the EGD backend when using a D-Bus-capable entropy provider;</summary>
        /// <remarks>
        /// the value is user-provided and backend-specific.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dbus Domain#dbus}
        /// </remarks>
        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceDbus\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourceDbus? Dbus
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
        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceDev\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourceDev? Dev
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
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourceFile? File
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
        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceNmdm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourceNmdm? Nmdm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables use of a null character device as the reservation backing source;</summary>
        /// <remarks>
        /// when this boolean is true, a Null source is emitted and all written data is discarded.
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
        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourcePipe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourcePipe? Pipe
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
        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourcePty\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourcePty? Pty
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#qemu_vd_agent Domain#qemu_vd_agent}.</summary>
        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceQemuVdAgent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgent? QemuVdAgent
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
        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceSpicePort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourceSpicePort? SpicePort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables a SPICE VMC (SPICE management channel) backend for this backing-store source;</summary>
        /// <remarks>
        /// when set true the element is emitted, when false or null it is omitted.
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

        /// <summary>Connects the backing-store source’s character channel to the domain’s standard I/O (stdin/stdout/stderr);</summary>
        /// <remarks>
        /// when true the element is emitted, when false or null it is omitted.
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
        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceTcp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourceTcp? Tcp
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
        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceUdp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourceUdp? Udp
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
        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceUnix\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourceUnix? Unix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables use of a VC (virtual cluster or vendor-specific) reservation source when set;</summary>
        /// <remarks>
        /// since this is presence-based, setting it to true emits the element and false/null omits it.
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

        [JsiiTypeProxy(nativeType: typeof(IDomainOsNvRamSourceReservationsSource), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceReservationsSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsNvRamSourceReservationsSource
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
            [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceDbus\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceDbus? Dbus
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourceDbus?>();
            }

            /// <summary>Configures an EGD RNG backend that reads entropy from a host character device node.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceDev\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceDev? Dev
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourceDev?>();
            }

            /// <summary>Configures an EGD RNG backend that reads or writes entropy data via a regular host file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceFile\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceFile? File
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourceFile?>();
            }

            /// <summary>Configures an EGD RNG backend that uses a FreeBSD nmdm pseudo-serial pair as the entropy transport.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nmdm Domain#nmdm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceNmdm\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceNmdm? Nmdm
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourceNmdm?>();
            }

            /// <summary>Enables use of a null character device as the reservation backing source;</summary>
            /// <remarks>
            /// when this boolean is true, a Null source is emitted and all written data is discarded.
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
            [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourcePipe\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourcePipe? Pipe
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourcePipe?>();
            }

            /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host pseudo-TTY device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pty Domain#pty}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourcePty\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourcePty? Pty
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourcePty?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#qemu_vd_agent Domain#qemu_vd_agent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceQemuVdAgent\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgent? QemuVdAgent
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgent?>();
            }

            /// <summary>Configures an RNG EGD backend that uses a SPICE port channel as the entropy source instead of direct host devices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spice_port Domain#spice_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceSpicePort\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceSpicePort? SpicePort
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourceSpicePort?>();
            }

            /// <summary>Enables a SPICE VMC (SPICE management channel) backend for this backing-store source;</summary>
            /// <remarks>
            /// when set true the element is emitted, when false or null it is omitted.
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

            /// <summary>Connects the backing-store source’s character channel to the domain’s standard I/O (stdin/stdout/stderr);</summary>
            /// <remarks>
            /// when true the element is emitted, when false or null it is omitted.
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
            [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceTcp\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceTcp? Tcp
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourceTcp?>();
            }

            /// <summary>Configures a UDP connection as the entropy source for the EGD RNG backend, with bind/connect endpoints defined by child elements.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#udp Domain#udp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceUdp\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceUdp? Udp
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourceUdp?>();
            }

            /// <summary>Configures a UNIX domain socket as the entropy source for the EGD RNG backend;</summary>
            /// <remarks>
            /// child attributes specify the socket path, mode, and optional reconnect policy.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unix Domain#unix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceUnix\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceUnix? Unix
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourceUnix?>();
            }

            /// <summary>Enables use of a VC (virtual cluster or vendor-specific) reservation source when set;</summary>
            /// <remarks>
            /// since this is presence-based, setting it to true emits the element and false/null omits it.
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
