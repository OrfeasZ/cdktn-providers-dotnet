using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksSourceVhostUser), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceVhostUser")]
    public interface IDomainDevicesDisksSourceVhostUser
    {
        /// <summary>Configures a D-Bus based source for the EGD backend when using a D-Bus-capable entropy provider;</summary>
        /// <remarks>
        /// the value is user-provided and backend-specific.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dbus Domain#dbus}
        /// </remarks>
        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserDbus\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceVhostUserDbus? Dbus
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
        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserDev\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceVhostUserDev? Dev
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
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceVhostUserFile? File
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
        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserNmdm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceVhostUserNmdm? Nmdm
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
        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserPipe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceVhostUserPipe? Pipe
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
        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserPty\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceVhostUserPty? Pty
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_vd_agent Domain#qemu_vd_agent}.</summary>
        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserQemuVdAgent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgent? QemuVdAgent
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
        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserSpicePort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceVhostUserSpicePort? SpicePort
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

        /// <summary>When set to true, connects the vhost-user backing to the domain’s standard I/O character device;</summary>
        /// <remarks>
        /// when false or unset, the StdIO element is omitted.
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
        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserTcp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceVhostUserTcp? Tcp
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
        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserUdp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceVhostUserUdp? Udp
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
        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserUnix\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSourceVhostUserUnix? Unix
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksSourceVhostUser), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceVhostUser")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksSourceVhostUser
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
            [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserDbus\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceVhostUserDbus? Dbus
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceVhostUserDbus?>();
            }

            /// <summary>Configures an EGD RNG backend that reads entropy from a host character device node.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserDev\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceVhostUserDev? Dev
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceVhostUserDev?>();
            }

            /// <summary>Configures an EGD RNG backend that reads or writes entropy data via a regular host file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#file Domain#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserFile\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceVhostUserFile? File
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceVhostUserFile?>();
            }

            /// <summary>Configures an EGD RNG backend that uses a FreeBSD nmdm pseudo-serial pair as the entropy transport.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nmdm Domain#nmdm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserNmdm\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceVhostUserNmdm? Nmdm
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceVhostUserNmdm?>();
            }

            /// <summary>When set to true, uses a null character device as the vhost-user backing-store source, discarding all output and providing no input;</summary>
            /// <remarks>
            /// when false or unset, the null device is not used.
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
            [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserPipe\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceVhostUserPipe? Pipe
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceVhostUserPipe?>();
            }

            /// <summary>Configures an RNG EGD backend that connects to an entropy source via a host pseudo-TTY device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pty Domain#pty}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserPty\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceVhostUserPty? Pty
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceVhostUserPty?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_vd_agent Domain#qemu_vd_agent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserQemuVdAgent\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgent? QemuVdAgent
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgent?>();
            }

            /// <summary>Configures an RNG EGD backend that uses a SPICE port channel as the entropy source instead of direct host devices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#spice_port Domain#spice_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserSpicePort\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceVhostUserSpicePort? SpicePort
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceVhostUserSpicePort?>();
            }

            /// <summary>When set to true, exposes the vhost-user backing through a SPICE virtio-serial management channel (SpiceVMC);</summary>
            /// <remarks>
            /// when false or unset, the element is omitted.
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

            /// <summary>When set to true, connects the vhost-user backing to the domain’s standard I/O character device;</summary>
            /// <remarks>
            /// when false or unset, the StdIO element is omitted.
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
            [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserTcp\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceVhostUserTcp? Tcp
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceVhostUserTcp?>();
            }

            /// <summary>Configures a UDP connection as the entropy source for the EGD RNG backend, with bind/connect endpoints defined by child elements.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#udp Domain#udp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserUdp\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceVhostUserUdp? Udp
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceVhostUserUdp?>();
            }

            /// <summary>Configures a UNIX domain socket as the entropy source for the EGD RNG backend;</summary>
            /// <remarks>
            /// child attributes specify the socket path, mode, and optional reconnect policy.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#unix Domain#unix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserUnix\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSourceVhostUserUnix? Unix
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSourceVhostUserUnix?>();
            }

            /// <summary>Enables use of a vhost-user communication mechanism compatible with a VC-style (versioned capability) endpoint for the disk mirror backing store;</summary>
            /// <remarks>
            /// when set true the VC element is emitted, when false or null it is omitted.
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
