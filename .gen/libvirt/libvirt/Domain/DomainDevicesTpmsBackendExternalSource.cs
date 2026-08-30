using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesTpmsBackendExternalSource")]
    public class DomainDevicesTpmsBackendExternalSource : libvirt.Domain.IDomainDevicesTpmsBackendExternalSource
    {
        /// <summary>Configures a D-Bus based source for the EGD backend when using a D-Bus-capable entropy provider;</summary>
        /// <remarks>
        /// the value is user-provided and backend-specific.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dbus Domain#dbus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceDbus\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceDbus? Dbus
        {
            get;
            set;
        }

        /// <summary>Configures an EGD RNG backend that reads entropy from a host character device node.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceDev\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceDev? Dev
        {
            get;
            set;
        }

        /// <summary>Configures an EGD RNG backend that reads or writes entropy data via a regular host file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceFile\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceFile? File
        {
            get;
            set;
        }

        /// <summary>Configures an EGD RNG backend that uses a FreeBSD nmdm pseudo-serial pair as the entropy transport.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nmdm Domain#nmdm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceNmdm\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceNmdm? Nmdm
        {
            get;
            set;
        }

        private object? _null;

        /// <summary>Enables use of a null character device as the external TPM backend source;</summary>
        /// <remarks>
        /// when set (true), the TPM device discards all output and never provides input.
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
        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourcePipe\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSourcePipe? Pipe
        {
            get;
            set;
        }

        /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host pseudo-TTY device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pty Domain#pty}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourcePty\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSourcePty? Pty
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#qemu_vd_agent Domain#qemu_vd_agent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgent\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgent? QemuVdAgent
        {
            get;
            set;
        }

        /// <summary>Configures an RNG EGD backend that uses a SPICE port channel as the entropy source instead of direct host devices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spice_port Domain#spice_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceSpicePort\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceSpicePort? SpicePort
        {
            get;
            set;
        }

        private object? _spiceVmc;

        /// <summary>When true, enables a SPICE VMC (virtio‑serial SPICE management) channel as the backend connection for the external TPM;</summary>
        /// <remarks>
        /// omitting or setting false leaves this source disabled.
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

        /// <summary>When true, connects the external TPM emulator to the domain via the QEMU standard input/output streams instead of a separate device;</summary>
        /// <remarks>
        /// omitting or setting false disables this source.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
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
        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceTcp\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceTcp? Tcp
        {
            get;
            set;
        }

        /// <summary>Configures a UDP connection as the entropy source for the EGD RNG backend, with bind/connect endpoints defined by child elements.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#udp Domain#udp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceUdp\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceUdp? Udp
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
        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceUnix\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceUnix? Unix
        {
            get;
            set;
        }

        private object? _vc;

        /// <summary>Enables use of a TPM backend source type "VC" for the external TPM device;</summary>
        /// <remarks>
        /// setting this boolean to true emits the <VC xmlns="http://www.w3.org/1999/xhtml"></VC> element, while false or null omits it.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
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
