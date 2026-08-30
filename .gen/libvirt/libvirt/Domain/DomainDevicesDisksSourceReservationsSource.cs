using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksSourceReservationsSource")]
    public class DomainDevicesDisksSourceReservationsSource : libvirt.Domain.IDomainDevicesDisksSourceReservationsSource
    {
        /// <summary>Configures a D-Bus based source for the EGD backend when using a D-Bus-capable entropy provider;</summary>
        /// <remarks>
        /// the value is user-provided and backend-specific.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dbus Domain#dbus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceDbus\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceDbus? Dbus
        {
            get;
            set;
        }

        /// <summary>Configures an EGD RNG backend that reads entropy from a host character device node.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceDev\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceDev? Dev
        {
            get;
            set;
        }

        /// <summary>Configures an EGD RNG backend that reads or writes entropy data via a regular host file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceFile\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceFile? File
        {
            get;
            set;
        }

        /// <summary>Configures an EGD RNG backend that uses a FreeBSD nmdm pseudo-serial pair as the entropy transport.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nmdm Domain#nmdm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceNmdm\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceNmdm? Nmdm
        {
            get;
            set;
        }

        private object? _null;

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
            get => _null;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _null = value;
            }
        }

        /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host named pipe (FIFO) rather than a socket or other backend types.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pipe Domain#pipe}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourcePipe\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourcePipe? Pipe
        {
            get;
            set;
        }

        /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host pseudo-TTY device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pty Domain#pty}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourcePty\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourcePty? Pty
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#qemu_vd_agent Domain#qemu_vd_agent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceQemuVdAgent\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceQemuVdAgent? QemuVdAgent
        {
            get;
            set;
        }

        /// <summary>Configures an RNG EGD backend that uses a SPICE port channel as the entropy source instead of direct host devices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spice_port Domain#spice_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceSpicePort\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceSpicePort? SpicePort
        {
            get;
            set;
        }

        private object? _spiceVmc;

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
            get => _spiceVmc;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _spiceVmc = value;
            }
        }

        private object? _stdIo;

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
            get => _stdIo;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stdIo = value;
            }
        }

        /// <summary>Configures a TCP connection as the entropy source for the EGD RNG backend;</summary>
        /// <remarks>
        /// child attributes define host, port, mode, TLS, and optional reconnect behavior.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tcp Domain#tcp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceTcp\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceTcp? Tcp
        {
            get;
            set;
        }

        /// <summary>Configures a UDP connection as the entropy source for the EGD RNG backend, with bind/connect endpoints defined by child elements.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#udp Domain#udp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceUdp\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceUdp? Udp
        {
            get;
            set;
        }

        /// <summary>Configures a UNIX domain socket as the entropy source for the EGD RNG backend;</summary>
        /// <remarks>
        /// child attributes specify the socket path, mode, and optional reconnect policy.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unix Domain#unix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsSourceUnix\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceReservationsSourceUnix? Unix
        {
            get;
            set;
        }

        private object? _vc;

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
            get => _vc;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vc = value;
            }
        }
    }
}
