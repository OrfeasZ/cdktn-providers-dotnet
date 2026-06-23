using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsAcpiTables), fullyQualifiedName: "libvirt.domain.DomainOsAcpiTables")]
    public interface IDomainOsAcpiTables
    {
        /// <summary>Sets the fully-qualified path on the host to the ACPI table file that will be injected into the guest;</summary>
        /// <remarks>
        /// the value is user-provided and must reference an accessible file. Example: "/usr/share/acpi/my_dsdt.bin".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#common-os-element-configuration">https://libvirt.org/formatdomain.html#common-os-element-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>Sets the ACPI table type corresponding to the content of the referenced file (for example "dsdt" or another ACPI table identifier);</summary>
        /// <remarks>
        /// the value is required and user-provided. Libvirt expects it to match the table contents.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#common-os-element-configuration">https://libvirt.org/formatdomain.html#common-os-element-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsAcpiTables), fullyQualifiedName: "libvirt.domain.DomainOsAcpiTables")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsAcpiTables
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the fully-qualified path on the host to the ACPI table file that will be injected into the guest;</summary>
            /// <remarks>
            /// the value is user-provided and must reference an accessible file. Example: "/usr/share/acpi/my_dsdt.bin".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#common-os-element-configuration">https://libvirt.org/formatdomain.html#common-os-element-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the ACPI table type corresponding to the content of the referenced file (for example "dsdt" or another ACPI table identifier);</summary>
            /// <remarks>
            /// the value is required and user-provided. Libvirt expects it to match the table contents.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#common-os-element-configuration">https://libvirt.org/formatdomain.html#common-os-element-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
