using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksMirrorSourceNetwork")]
    public class DomainDevicesDisksMirrorSourceNetwork : libvirt.Domain.IDomainDevicesDisksMirrorSourceNetwork
    {
        /// <summary>Configures CHAP authentication parameters for the iSCSI source backing an assigned SCSI host device;</summary>
        /// <remarks>
        /// include this block only when the target requires authentication.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auth Domain#auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkAuth\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkAuth? Auth
        {
            get;
            set;
        }

        /// <summary>Points to an external configuration source for the network backing store (for example, an RBD or Ceph config file) that libvirt passes to the backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#config Domain#config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkConfig\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkConfig? Config
        {
            get;
            set;
        }

        private object? _hosts;

        /// <summary>Declares one or more network endpoints (hosts) for the backing store server, each with its own name/address and possibly additional attributes.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hosts Domain#hosts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkHosts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hosts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Hosts
        {
            get => _hosts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkHosts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkHosts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hosts = value;
            }
        }

        /// <summary>Configures authentication/identity parameters used when accessing the mirrored backing store over a network, such as user, group, keyfile, or agent socket, depending on the protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#identity Domain#identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkIdentity\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkIdentity? Identity
        {
            get;
            set;
        }

        /// <summary>Configures initiator identity information (typically for iSCSI-like protocols) used when accessing the mirrored network backing store.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#initiator Domain#initiator}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkInitiator\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkInitiator? Initiator
        {
            get;
            set;
        }

        /// <summary>Enables use of a known-hosts file to validate the remote host’s identity when connecting to the mirrored network backing store.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#known_hosts Domain#known_hosts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "knownHosts", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkKnownHosts\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkKnownHosts? KnownHosts
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Configures automatic reconnection behavior for the mirrored network backing store after a connection loss.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#reconnect Domain#reconnect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reconnect", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkReconnect\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkReconnect? Reconnect
        {
            get;
            set;
        }

        /// <summary>Configures snapshot-related behavior for the network-based mirrored backing store, with semantics depending on the underlying protocol and storage implementation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#snapshot Domain#snapshot}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkSnapshot\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkSnapshot? Snapshot
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }
    }
}
