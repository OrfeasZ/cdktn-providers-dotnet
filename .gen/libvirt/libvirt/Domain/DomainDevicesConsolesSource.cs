using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesConsolesSource")]
    public class DomainDevicesConsolesSource : libvirt.Domain.IDomainDevicesConsolesSource
    {
        /// <summary>Configures a D-Bus based source for the EGD backend when using a D-Bus-capable entropy provider;</summary>
        /// <remarks>
        /// the value is user-provided and backend-specific.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dbus Domain#dbus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceDbus\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourceDbus? Dbus
        {
            get;
            set;
        }

        /// <summary>Configures an EGD RNG backend that reads entropy from a host character device node.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceDev\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourceDev? Dev
        {
            get;
            set;
        }

        /// <summary>Configures an EGD RNG backend that reads or writes entropy data via a regular host file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceFile\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourceFile? File
        {
            get;
            set;
        }

        /// <summary>Configures an EGD RNG backend that uses a FreeBSD nmdm pseudo-serial pair as the entropy transport.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nmdm Domain#nmdm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceNmdm\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourceNmdm? Nmdm
        {
            get;
            set;
        }

        private object? _null;

        /// <summary>Enables use of a null backend for the EGD RNG source, discarding all data written and providing no entropy;</summary>
        /// <remarks>
        /// when this boolean is true the &lt;Null&gt; source is emitted, and when false or unset it is omitted.
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
        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourcePipe\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourcePipe? Pipe
        {
            get;
            set;
        }

        /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host pseudo-TTY device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pty Domain#pty}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourcePty\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourcePty? Pty
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#qemu_vd_agent Domain#qemu_vd_agent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceQemuVdAgent\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourceQemuVdAgent? QemuVdAgent
        {
            get;
            set;
        }

        /// <summary>Configures an RNG EGD backend that uses a SPICE port channel as the entropy source instead of direct host devices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spice_port Domain#spice_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceSpicePort\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourceSpicePort? SpicePort
        {
            get;
            set;
        }

        private object? _spiceVmc;

        /// <summary>Enables using a SPICE virtio serial management channel (spicevmc) as the entropy source for the EGD RNG backend when set to true;</summary>
        /// <remarks>
        /// when false or unset, the element is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
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

        /// <summary>Enables using the QEMU process standard I/O stream as the entropy source for the EGD RNG backend when set to true;</summary>
        /// <remarks>
        /// when false or unset, the element is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
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
        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceTcp\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourceTcp? Tcp
        {
            get;
            set;
        }

        /// <summary>Configures a UDP connection as the entropy source for the EGD RNG backend, with bind/connect endpoints defined by child elements.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#udp Domain#udp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceUdp\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourceUdp? Udp
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
        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceUnix\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourceUnix? Unix
        {
            get;
            set;
        }

        private object? _vc;

        /// <summary>Enables use of a virtual console device as the entropy source for the EGD RNG backend when set (presence-only element;</summary>
        /// <remarks>
        /// omitting it disables this source).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
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
