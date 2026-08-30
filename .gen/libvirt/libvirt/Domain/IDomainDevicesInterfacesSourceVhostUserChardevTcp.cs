using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceVhostUserChardevTcp), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceVhostUserChardevTcp")]
    public interface IDomainDevicesInterfacesSourceVhostUserChardevTcp
    {
        /// <summary>Sets the remote hostname or IP address for the TCP-based EGD entropy source;</summary>
        /// <remarks>
        /// the value is user-provided (for example, "rng.example.com" or "192.0.2.10").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#host Domain#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the TCP connection mode for the EGD entropy source;</summary>
        /// <remarks>
        /// valid values are user-provided but typically "client" or "server" depending on whether QEMU connects out or listens.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures automatic reconnection behavior for a UNIX socket–based EGD entropy source;</summary>
        /// <remarks>
        /// the content and attributes are user-provided according to desired policy.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#reconnect Domain#reconnect}
        /// </remarks>
        [JsiiProperty(name: "reconnect", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVhostUserChardevTcpReconnect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesSourceVhostUserChardevTcpReconnect? Reconnect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the TCP service or port number for the EGD entropy source (for example, "egdsock" or "7040");</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#service Domain#service}
        /// </remarks>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Service
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables TLS for the TCP-based EGD entropy source;</summary>
        /// <remarks>
        /// the value is user-provided, typically "yes" or "no" depending on desired encryption.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tls Domain#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceVhostUserChardevTcp), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceVhostUserChardevTcp")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceVhostUserChardevTcp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the remote hostname or IP address for the TCP-based EGD entropy source;</summary>
            /// <remarks>
            /// the value is user-provided (for example, "rng.example.com" or "192.0.2.10").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#host Domain#host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Host
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the TCP connection mode for the EGD entropy source;</summary>
            /// <remarks>
            /// valid values are user-provided but typically "client" or "server" depending on whether QEMU connects out or listens.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables and configures automatic reconnection behavior for a UNIX socket–based EGD entropy source;</summary>
            /// <remarks>
            /// the content and attributes are user-provided according to desired policy.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#reconnect Domain#reconnect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reconnect", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVhostUserChardevTcpReconnect\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesSourceVhostUserChardevTcpReconnect? Reconnect
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesSourceVhostUserChardevTcpReconnect?>();
            }

            /// <summary>Sets the TCP service or port number for the EGD entropy source (for example, "egdsock" or "7040");</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#service Domain#service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Service
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables or disables TLS for the TCP-based EGD entropy source;</summary>
            /// <remarks>
            /// the value is user-provided, typically "yes" or "no" depending on desired encryption.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tls Domain#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tls
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
