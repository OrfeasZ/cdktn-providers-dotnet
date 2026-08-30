using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesCrypto), fullyQualifiedName: "libvirt.domain.DomainDevicesCrypto")]
    public interface IDomainDevicesCrypto
    {
        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesCryptoAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesCryptoAddress? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesCryptoAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesCryptoAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the backend implementation details for the crypto device, such as whether it is built-in or uses the LKCF kernel framework.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#backend Domain#backend}
        /// </remarks>
        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesCryptoBackend\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesCryptoBackend? Backend
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the crypto device model;</summary>
        /// <remarks>
        /// for recent libvirt/QEMU this must be a virtio variant such as "virtio", "virtio-transitional", or "virtio-non-transitional".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the crypto device type/implementation, which currently supports "qemu";</summary>
        /// <remarks>
        /// the value is user-provided but must be supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesCrypto), fullyQualifiedName: "libvirt.domain.DomainDevicesCrypto")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesCrypto
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesCryptoAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesCryptoAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesCryptoAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesCryptoAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesCryptoAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesCryptoAlias?>();
            }

            /// <summary>Configures the backend implementation details for the crypto device, such as whether it is built-in or uses the LKCF kernel framework.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#backend Domain#backend}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesCryptoBackend\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesCryptoBackend? Backend
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesCryptoBackend?>();
            }

            /// <summary>Selects the crypto device model;</summary>
            /// <remarks>
            /// for recent libvirt/QEMU this must be a virtio variant such as "virtio", "virtio-transitional", or "virtio-non-transitional".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Model
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Selects the crypto device type/implementation, which currently supports "qemu";</summary>
            /// <remarks>
            /// the value is user-provided but must be supported by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
