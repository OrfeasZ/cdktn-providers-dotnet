using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesBackend), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesBackend")]
    public interface IDomainDevicesInterfacesBackend
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fqdn Domain#fqdn}.</summary>
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Fqdn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hostname Domain#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Hostname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets a path to a host log file where backend-related messages for this interface are written;</summary>
        /// <remarks>
        /// value is a user-provided filesystem path.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#log_file Domain#log_file}
        /// </remarks>
        [JsiiProperty(name: "logFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the tap device to be used by the backend instead of one automatically created (for example, "tap0");</summary>
        /// <remarks>
        /// value is a user-provided interface name.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-network-backend-specific-options">https://libvirt.org/formatdomain.html#setting-network-backend-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tap Domain#tap}
        /// </remarks>
        [JsiiProperty(name: "tap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tap
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the backend implementation type (for example, "passt" for a passt userspace backend);</summary>
        /// <remarks>
        /// value must match a backend type supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Overrides the default vhost device path for this interface’s backend (for example, "/dev/vhost-net"); value is a user-provided path.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-network-backend-specific-options">https://libvirt.org/formatdomain.html#setting-network-backend-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vhost Domain#vhost}
        /// </remarks>
        [JsiiProperty(name: "vhost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Vhost
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesBackend), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesBackend")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesBackend
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fqdn Domain#fqdn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Fqdn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hostname Domain#hostname}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hostname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets a path to a host log file where backend-related messages for this interface are written;</summary>
            /// <remarks>
            /// value is a user-provided filesystem path.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#log_file Domain#log_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the tap device to be used by the backend instead of one automatically created (for example, "tap0");</summary>
            /// <remarks>
            /// value is a user-provided interface name.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#setting-network-backend-specific-options">https://libvirt.org/formatdomain.html#setting-network-backend-specific-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tap Domain#tap}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tap
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Selects the backend implementation type (for example, "passt" for a passt userspace backend);</summary>
            /// <remarks>
            /// value must match a backend type supported by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Overrides the default vhost device path for this interface’s backend (for example, "/dev/vhost-net"); value is a user-provided path.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#setting-network-backend-specific-options">https://libvirt.org/formatdomain.html#setting-network-backend-specific-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vhost Domain#vhost}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vhost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Vhost
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
