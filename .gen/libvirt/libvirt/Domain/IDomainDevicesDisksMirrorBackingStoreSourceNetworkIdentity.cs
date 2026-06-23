using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceNetworkIdentity), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkIdentity")]
    public interface IDomainDevicesDisksMirrorBackingStoreSourceNetworkIdentity
    {
        /// <summary>Sets the path to a local agent socket used for external authentication (for example, SASL or SSH agent) when connecting to the network backing store;</summary>
        /// <remarks>
        /// value is a user-provided Unix socket path.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#agent_sock Domain#agent_sock}
        /// </remarks>
        [JsiiProperty(name: "agentSock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentSock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the group name to use for authentication or access control when connecting to the network backing store;</summary>
        /// <remarks>
        /// value is user-provided and protocol-specific.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#group Domain#group}
        /// </remarks>
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the path to a private key file used for authenticating to the network backing store (for example, an SSH or TLS key);</summary>
        /// <remarks>
        /// value is a user-provided filesystem path.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#keyfile Domain#keyfile}
        /// </remarks>
        [JsiiProperty(name: "keyfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Keyfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the user identifier used for authentication to the network backing store;</summary>
        /// <remarks>
        /// value is user-provided and typically matches a remote account name.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#user Domain#user}
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? User
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets an explicit username string used for authentication to the network backing store, separate from any other user identity settings;</summary>
        /// <remarks>
        /// value is user-provided (for example, "backupuser").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#user_name Domain#user_name}
        /// </remarks>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceNetworkIdentity), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkIdentity")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the path to a local agent socket used for external authentication (for example, SASL or SSH agent) when connecting to the network backing store;</summary>
            /// <remarks>
            /// value is a user-provided Unix socket path.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#agent_sock Domain#agent_sock}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agentSock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentSock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the group name to use for authentication or access control when connecting to the network backing store;</summary>
            /// <remarks>
            /// value is user-provided and protocol-specific.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#group Domain#group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Group
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the path to a private key file used for authenticating to the network backing store (for example, an SSH or TLS key);</summary>
            /// <remarks>
            /// value is a user-provided filesystem path.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#keyfile Domain#keyfile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Keyfile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the user identifier used for authentication to the network backing store;</summary>
            /// <remarks>
            /// value is user-provided and typically matches a remote account name.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#user Domain#user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? User
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets an explicit username string used for authentication to the network backing store, separate from any other user identity settings;</summary>
            /// <remarks>
            /// value is user-provided (for example, "backupuser").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#user_name Domain#user_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
