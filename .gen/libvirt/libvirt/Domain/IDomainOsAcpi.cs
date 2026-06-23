using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsAcpi), fullyQualifiedName: "libvirt.domain.DomainOsAcpi")]
    public interface IDomainOsAcpi
    {
        /// <summary>Declares one or more custom ACPI tables to load into the guest, each with a required type and path specifying the table file.</summary>
        /// <remarks>
        /// Multiple entries are allowed.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#common-os-element-configuration">https://libvirt.org/formatdomain.html#common-os-element-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tables Domain#tables}
        /// </remarks>
        [JsiiProperty(name: "tables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsAcpiTables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tables
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsAcpi), fullyQualifiedName: "libvirt.domain.DomainOsAcpi")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsAcpi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Declares one or more custom ACPI tables to load into the guest, each with a required type and path specifying the table file.</summary>
            /// <remarks>
            /// Multiple entries are allowed.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#common-os-element-configuration">https://libvirt.org/formatdomain.html#common-os-element-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tables Domain#tables}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsAcpiTables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tables
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
