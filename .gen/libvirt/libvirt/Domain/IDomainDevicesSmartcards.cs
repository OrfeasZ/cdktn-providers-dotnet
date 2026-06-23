using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesSmartcards), fullyQualifiedName: "libvirt.domain.DomainDevicesSmartcards")]
    public interface IDomainDevicesSmartcards
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSmartcardsAcpi? Acpi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSmartcardsAddress? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSmartcardsAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the NSS database directory used for the smartcard’s certificate store; value is a user-provided path such as `/etc/pki/nssdb`.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#database Domain#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Database
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables the host-certificates smartcard mode when set (element is present), so the guest uses certificates from the host’s smartcard database.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#host Domain#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lists one or more certificate files that should be exposed to the guest when using host-certificates smartcard mode.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#host_certs Domain#host_certs}
        /// </remarks>
        [JsiiProperty(name: "hostCerts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsHostCerts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HostCerts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#passthrough Domain#passthrough}
        /// </remarks>
        [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsPassthrough\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSmartcardsPassthrough? Passthrough
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the transport protocol used by the EGD backend connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#protocol Domain#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsProtocol\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSmartcardsProtocol? Protocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesSmartcards), fullyQualifiedName: "libvirt.domain.DomainDevicesSmartcards")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesSmartcards
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSmartcardsAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSmartcardsAcpi?>();
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSmartcardsAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSmartcardsAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSmartcardsAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSmartcardsAlias?>();
            }

            /// <summary>Sets the NSS database directory used for the smartcard’s certificate store; value is a user-provided path such as `/etc/pki/nssdb`.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#database Domain#database}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Database
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables the host-certificates smartcard mode when set (element is present), so the guest uses certificates from the host’s smartcard database.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#host Domain#host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Host
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Lists one or more certificate files that should be exposed to the guest when using host-certificates smartcard mode.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#host_certs Domain#host_certs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostCerts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsHostCerts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HostCerts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#passthrough Domain#passthrough}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsPassthrough\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSmartcardsPassthrough? Passthrough
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSmartcardsPassthrough?>();
            }

            /// <summary>Configures the transport protocol used by the EGD backend connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#protocol Domain#protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsProtocol\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSmartcardsProtocol? Protocol
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSmartcardsProtocol?>();
            }
        }
    }
}
