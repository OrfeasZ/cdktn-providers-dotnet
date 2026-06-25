using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsNvRamSourceNetwork), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceNetwork")]
    public interface IDomainOsNvRamSourceNetwork
    {
        /// <summary>Configures CHAP authentication parameters for the iSCSI source backing an assigned SCSI host device;</summary>
        /// <remarks>
        /// include this block only when the target requires authentication.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auth Domain#auth}
        /// </remarks>
        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkAuth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceNetworkAuth? Auth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Points to an external configuration source for the network backing store (for example, an RBD or Ceph config file) that libvirt passes to the backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#config Domain#config}
        /// </remarks>
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceNetworkConfig? Config
        {
            get
            {
                return null;
            }
        }

        /// <summary>Declares one or more network endpoints (hosts) for the backing store server, each with its own name/address and possibly additional attributes.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hosts Domain#hosts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsNvRamSourceNetworkHosts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "hosts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Hosts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures authentication/identity parameters used when accessing the mirrored backing store over a network, such as user, group, keyfile, or agent socket, depending on the protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#identity Domain#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceNetworkIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures initiator identity information (typically for iSCSI-like protocols) used when accessing the mirrored network backing store.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#initiator Domain#initiator}
        /// </remarks>
        [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkInitiator\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceNetworkInitiator? Initiator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables use of a known-hosts file to validate the remote host’s identity when connecting to the mirrored network backing store.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#known_hosts Domain#known_hosts}
        /// </remarks>
        [JsiiProperty(name: "knownHosts", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkKnownHosts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceNetworkKnownHosts? KnownHosts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets a name for the network source of the mirrored backing store, typically used by certain protocols (such as RBD pool or NBD export names);</summary>
        /// <remarks>
        /// value is user-provided and protocol-specific.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the network storage protocol used for the mirrored backing store;</summary>
        /// <remarks>
        /// value is user-provided but must be a protocol supported by libvirt for network disks (for example, rbd, sheepdog, gluster, nbd).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#protocol Domain#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets an optional query string or subresource specifier for the network storage URL of the mirrored backing store;</summary>
        /// <remarks>
        /// value is user-provided and protocol-specific.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#query Domain#query}
        /// </remarks>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Query
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures automatic reconnection behavior for the mirrored network backing store after a connection loss.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#reconnect Domain#reconnect}
        /// </remarks>
        [JsiiProperty(name: "reconnect", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkReconnect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceNetworkReconnect? Reconnect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures snapshot-related behavior for the network-based mirrored backing store, with semantics depending on the underlying protocol and storage implementation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#snapshot Domain#snapshot}
        /// </remarks>
        [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkSnapshot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceNetworkSnapshot? Snapshot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether TLS is used for the mirrored disk’s network backing-store connection;</summary>
        /// <remarks>
        /// value is user-provided and typically enabled only when the chosen protocol and backend support TLS.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tls Domain#tls}
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

        /// <summary>Sets the expected TLS hostname for the mirrored disk’s network backing-store connection, used for certificate verification;</summary>
        /// <remarks>
        /// value is user-provided and should match the server certificate’s hostname (for example, "storage.example.com").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tls_hostname Domain#tls_hostname}
        /// </remarks>
        [JsiiProperty(name: "tlsHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsHostname
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsNvRamSourceNetwork), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceNetwork")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsNvRamSourceNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures CHAP authentication parameters for the iSCSI source backing an assigned SCSI host device;</summary>
            /// <remarks>
            /// include this block only when the target requires authentication.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auth Domain#auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkAuth\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceNetworkAuth? Auth
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceNetworkAuth?>();
            }

            /// <summary>Points to an external configuration source for the network backing store (for example, an RBD or Ceph config file) that libvirt passes to the backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#config Domain#config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkConfig\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceNetworkConfig? Config
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceNetworkConfig?>();
            }

            /// <summary>Declares one or more network endpoints (hosts) for the backing store server, each with its own name/address and possibly additional attributes.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hosts Domain#hosts}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsNvRamSourceNetworkHosts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hosts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Hosts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures authentication/identity parameters used when accessing the mirrored backing store over a network, such as user, group, keyfile, or agent socket, depending on the protocol.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#identity Domain#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkIdentity\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceNetworkIdentity? Identity
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceNetworkIdentity?>();
            }

            /// <summary>Configures initiator identity information (typically for iSCSI-like protocols) used when accessing the mirrored network backing store.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#initiator Domain#initiator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkInitiator\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceNetworkInitiator? Initiator
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceNetworkInitiator?>();
            }

            /// <summary>Enables use of a known-hosts file to validate the remote host’s identity when connecting to the mirrored network backing store.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#known_hosts Domain#known_hosts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "knownHosts", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkKnownHosts\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceNetworkKnownHosts? KnownHosts
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceNetworkKnownHosts?>();
            }

            /// <summary>Sets a name for the network source of the mirrored backing store, typically used by certain protocols (such as RBD pool or NBD export names);</summary>
            /// <remarks>
            /// value is user-provided and protocol-specific.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the network storage protocol used for the mirrored backing store;</summary>
            /// <remarks>
            /// value is user-provided but must be a protocol supported by libvirt for network disks (for example, rbd, sheepdog, gluster, nbd).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#protocol Domain#protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets an optional query string or subresource specifier for the network storage URL of the mirrored backing store;</summary>
            /// <remarks>
            /// value is user-provided and protocol-specific.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#query Domain#query}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Query
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures automatic reconnection behavior for the mirrored network backing store after a connection loss.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#reconnect Domain#reconnect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reconnect", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkReconnect\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceNetworkReconnect? Reconnect
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceNetworkReconnect?>();
            }

            /// <summary>Configures snapshot-related behavior for the network-based mirrored backing store, with semantics depending on the underlying protocol and storage implementation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#snapshot Domain#snapshot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkSnapshot\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceNetworkSnapshot? Snapshot
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceNetworkSnapshot?>();
            }

            /// <summary>Controls whether TLS is used for the mirrored disk’s network backing-store connection;</summary>
            /// <remarks>
            /// value is user-provided and typically enabled only when the chosen protocol and backend support TLS.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tls Domain#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tls
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the expected TLS hostname for the mirrored disk’s network backing-store connection, used for certificate verification;</summary>
            /// <remarks>
            /// value is user-provided and should match the server certificate’s hostname (for example, "storage.example.com").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tls_hostname Domain#tls_hostname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tlsHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsHostname
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
