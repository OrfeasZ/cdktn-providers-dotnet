using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesRngs), fullyQualifiedName: "libvirt.domain.DomainDevicesRngs")]
    public interface IDomainDevicesRngs
    {
        /// <summary>Sets the RNG device model, for example "virtio" for a paravirtual RNG;</summary>
        /// <remarks>
        /// the value is required and must be a model supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
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
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesRngsAcpi? Acpi
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
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesRngsAddress? Address
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
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesRngsAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the entropy backend that the RNG device uses, such as a built-in source or an external EGD-compatible source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#backend Domain#backend}
        /// </remarks>
        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsBackend\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesRngsBackend? Backend
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures virtio transport–specific driver options for the RNG device, such as IOMMU and ATS behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsDriver\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesRngsDriver? Driver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures optional rate limiting for the RNG device, constraining how much entropy is delivered to the guest over time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#rate Domain#rate}
        /// </remarks>
        [JsiiProperty(name: "rate", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsRate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesRngsRate? Rate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesRngs), fullyQualifiedName: "libvirt.domain.DomainDevicesRngs")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesRngs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the RNG device model, for example "virtio" for a paravirtual RNG;</summary>
            /// <remarks>
            /// the value is required and must be a model supported by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
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
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesRngsAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesRngsAcpi?>();
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesRngsAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesRngsAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesRngsAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesRngsAlias?>();
            }

            /// <summary>Configures the entropy backend that the RNG device uses, such as a built-in source or an external EGD-compatible source.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#backend Domain#backend}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsBackend\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesRngsBackend? Backend
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesRngsBackend?>();
            }

            /// <summary>Configures virtio transport–specific driver options for the RNG device, such as IOMMU and ATS behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsDriver\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesRngsDriver? Driver
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesRngsDriver?>();
            }

            /// <summary>Configures optional rate limiting for the RNG device, constraining how much entropy is delivered to the guest over time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#rate Domain#rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rate", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsRate\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesRngsRate? Rate
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesRngsRate?>();
            }
        }
    }
}
