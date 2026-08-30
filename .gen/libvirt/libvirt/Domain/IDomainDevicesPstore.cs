using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesPstore), fullyQualifiedName: "libvirt.domain.DomainDevicesPstore")]
    public interface IDomainDevicesPstore
    {
        /// <summary>Selects the pstore backend implementation used by the guest (currently "acpi-erst" is supported); this attribute is required.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#backend Domain#backend}
        /// </remarks>
        [JsiiProperty(name: "backend", typeJson: "{\"primitive\":\"string\"}")]
        string Backend
        {
            get;
        }

        /// <summary>Sets the host path (file or block device) used as the persistent storage area for pstore logs (for example "/var/lib/libvirt/pstore.img").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>Defines the capacity of the pstore log storage, as a numeric value interpreted together with size_unit (for example 16 with size_unit="MiB").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesPstoreAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesPstoreAcpi? Acpi
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
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesPstoreAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesPstoreAddress? Address
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
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesPstoreAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesPstoreAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the unit for the pstore size value (for example "KiB", "MiB", or "GiB");</summary>
        /// <remarks>
        /// if omitted, libvirt applies its default unit handling.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size_unit Domain#size_unit}
        /// </remarks>
        [JsiiProperty(name: "sizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SizeUnit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesPstore), fullyQualifiedName: "libvirt.domain.DomainDevicesPstore")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesPstore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Selects the pstore backend implementation used by the guest (currently "acpi-erst" is supported); this attribute is required.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#backend Domain#backend}
            /// </remarks>
            [JsiiProperty(name: "backend", typeJson: "{\"primitive\":\"string\"}")]
            public string Backend
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the host path (file or block device) used as the persistent storage area for pstore logs (for example "/var/lib/libvirt/pstore.img").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Defines the capacity of the pstore log storage, as a numeric value interpreted together with size_unit (for example 16 with size_unit="MiB").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size Domain#size}
            /// </remarks>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesPstoreAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesPstoreAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesPstoreAcpi?>();
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesPstoreAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesPstoreAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesPstoreAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesPstoreAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesPstoreAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesPstoreAlias?>();
            }

            /// <summary>Specifies the unit for the pstore size value (for example "KiB", "MiB", or "GiB");</summary>
            /// <remarks>
            /// if omitted, libvirt applies its default unit handling.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size_unit Domain#size_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SizeUnit
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
