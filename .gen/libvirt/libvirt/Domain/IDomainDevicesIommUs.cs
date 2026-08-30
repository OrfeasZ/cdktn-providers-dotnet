using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesIommUs), fullyQualifiedName: "libvirt.domain.DomainDevicesIommUs")]
    public interface IDomainDevicesIommUs
    {
        /// <summary>Selects the IOMMU model to expose to the guest;</summary>
        /// <remarks>
        /// valid values include "intel", "smmuv3", and "virtio" depending on architecture and QEMU version.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        string Model
        {
            get;
        }

        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommUsAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesIommUsAcpi? Acpi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommUsAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesIommUsAddress? Address
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
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommUsAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesIommUsAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures model-specific driver options for the IOMMU, such as address width, interrupt remapping, and caching behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommUsDriver\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesIommUsDriver? Driver
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesIommUs), fullyQualifiedName: "libvirt.domain.DomainDevicesIommUs")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesIommUs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Selects the IOMMU model to expose to the guest;</summary>
            /// <remarks>
            /// valid values include "intel", "smmuv3", and "virtio" depending on architecture and QEMU version.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
            /// </remarks>
            [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
            public string Model
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommUsAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesIommUsAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesIommUsAcpi?>();
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommUsAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesIommUsAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesIommUsAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommUsAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesIommUsAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesIommUsAlias?>();
            }

            /// <summary>Configures model-specific driver options for the IOMMU, such as address width, interrupt remapping, and caching behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommUsDriver\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesIommUsDriver? Driver
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesIommUsDriver?>();
            }
        }
    }
}
