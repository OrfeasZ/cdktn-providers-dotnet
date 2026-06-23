using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesVsock), fullyQualifiedName: "libvirt.domain.DomainDevicesVsock")]
    public interface IDomainDevicesVsock
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsockAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesVsockAcpi? Acpi
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
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsockAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesVsockAddress? Address
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
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsockAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesVsockAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the vsock context ID (CID) container, which holds either a fixed CID or indicates automatic assignment for the vsock device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cid Domain#cid}
        /// </remarks>
        [JsiiProperty(name: "cid", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsockCid\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesVsockCid? Cid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures virtio transport–specific options for the vsock device driver, such as IOMMU and ATS usage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsockDriver\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesVsockDriver? Driver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the vsock device model, typically one of "virtio", "virtio-transitional", or "virtio-non-transitional";</summary>
        /// <remarks>
        /// if omitted, libvirt uses its default vsock model.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#vsock">https://libvirt.org/formatdomain.html#vsock</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesVsock), fullyQualifiedName: "libvirt.domain.DomainDevicesVsock")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesVsock
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsockAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesVsockAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesVsockAcpi?>();
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsockAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesVsockAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesVsockAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsockAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesVsockAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesVsockAlias?>();
            }

            /// <summary>Configures the vsock context ID (CID) container, which holds either a fixed CID or indicates automatic assignment for the vsock device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cid Domain#cid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cid", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsockCid\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesVsockCid? Cid
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesVsockCid?>();
            }

            /// <summary>Configures virtio transport–specific options for the vsock device driver, such as IOMMU and ATS usage.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsockDriver\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesVsockDriver? Driver
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesVsockDriver?>();
            }

            /// <summary>Sets the vsock device model, typically one of "virtio", "virtio-transitional", or "virtio-non-transitional";</summary>
            /// <remarks>
            /// if omitted, libvirt uses its default vsock model.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#vsock">https://libvirt.org/formatdomain.html#vsock</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Model
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
