using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksSourceReservationsSource), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceReservationsSource")]
    public interface IDomainDevicesDisksSourceReservationsSource
    {
        /// <summary>Configures a D-Bus based source for the EGD backend when using a D-Bus-capable entropy provider;</summary>
        /// <remarks>
        /// the value is user-provided and backend-specific.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dbus Domain#dbus}
        /// </remarks>
        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceDbus\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceDbus? Dbus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an EGD RNG backend that reads entropy from a host character device node.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceDev\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceDev? Dev
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an EGD RNG backend that reads or writes entropy data via a regular host file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceFile? File
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an EGD RNG backend that uses a FreeBSD nmdm pseudo-serial pair as the entropy transport.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nmdm Domain#nmdm}
        /// </remarks>
        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceNmdm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceNmdm? Nmdm
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#null Domain#null}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pipe Domain#pipe}
        /// </remarks>
        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourcePipe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceReservationsSourcePipe? Pipe
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host pseudo-TTY device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pty Domain#pty}
        /// </remarks>
        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourcePty\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceReservationsSourcePty? Pty
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_vd_agent Domain#qemu_vd_agent}.</summary>
        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceQemuVdAgent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceQemuVdAgent? QemuVdAgent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an RNG EGD backend that uses a SPICE port channel as the entropy source instead of direct host devices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#spice_port Domain#spice_port}
        /// </remarks>
        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceSpicePort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceSpicePort? SpicePort
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#spice_vmc Domain#spice_vmc}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#std_io Domain#std_io}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tcp Domain#tcp}
        /// </remarks>
        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceTcp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceTcp? Tcp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a UDP connection as the entropy source for the EGD RNG backend, with bind/connect endpoints defined by child elements.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#udp Domain#udp}
        /// </remarks>
        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceUdp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceUdp? Udp
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#unix Domain#unix}
        /// </remarks>
        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceUnix\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceUnix? Unix
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vc Domain#vc}
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksSourceReservationsSource), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceReservationsSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksSourceReservationsSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures a D-Bus based source for the EGD backend when using a D-Bus-capable entropy provider;</summary>
            /// <remarks>
            /// the value is user-provided and backend-specific.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dbus Domain#dbus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceDbus\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceDbus? Dbus
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceDbus?>();
            }

            /// <summary>Configures an EGD RNG backend that reads entropy from a host character device node.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceDev\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceDev? Dev
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceDev?>();
            }

            /// <summary>Configures an EGD RNG backend that reads or writes entropy data via a regular host file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#file Domain#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceFile\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceFile? File
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceFile?>();
            }

            /// <summary>Configures an EGD RNG backend that uses a FreeBSD nmdm pseudo-serial pair as the entropy transport.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nmdm Domain#nmdm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceNmdm\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceNmdm? Nmdm
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceNmdm?>();
            }

            /// <summary>Enables use of a null character device as the reservation backing source;</summary>
            /// <remarks>
            /// when this boolean is true, a Null source is emitted and all written data is discarded.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#null-device">https://libvirt.org/formatdomain.html#null-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#null Domain#null}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "null", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Null
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host named pipe (FIFO) rather than a socket or other backend types.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pipe Domain#pipe}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourcePipe\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourcePipe? Pipe
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceReservationsSourcePipe?>();
            }

            /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host pseudo-TTY device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pty Domain#pty}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourcePty\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourcePty? Pty
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceReservationsSourcePty?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_vd_agent Domain#qemu_vd_agent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceQemuVdAgent\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceQemuVdAgent? QemuVdAgent
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceQemuVdAgent?>();
            }

            /// <summary>Configures an RNG EGD backend that uses a SPICE port channel as the entropy source instead of direct host devices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#spice_port Domain#spice_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceSpicePort\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceSpicePort? SpicePort
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceSpicePort?>();
            }

            /// <summary>Enables a SPICE VMC (SPICE management channel) backend for this backing-store source;</summary>
            /// <remarks>
            /// when set true the element is emitted, when false or null it is omitted.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#spice-channel">https://libvirt.org/formatdomain.html#spice-channel</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#spice_vmc Domain#spice_vmc}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#std_io Domain#std_io}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tcp Domain#tcp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceTcp\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceTcp? Tcp
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceTcp?>();
            }

            /// <summary>Configures a UDP connection as the entropy source for the EGD RNG backend, with bind/connect endpoints defined by child elements.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#udp Domain#udp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceUdp\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceUdp? Udp
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceUdp?>();
            }

            /// <summary>Configures a UNIX domain socket as the entropy source for the EGD RNG backend;</summary>
            /// <remarks>
            /// child attributes specify the socket path, mode, and optional reconnect policy.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#unix Domain#unix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceUnix\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceUnix? Unix
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceUnix?>();
            }

            /// <summary>Enables use of a VC (virtual cluster or vendor-specific) reservation source when set;</summary>
            /// <remarks>
            /// since this is presence-based, setting it to true emits the element and false/null omits it.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vc Domain#vc}
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
