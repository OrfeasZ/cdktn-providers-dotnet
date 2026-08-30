using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuNumaCellCachesLine), fullyQualifiedName: "libvirt.domain.DomainCpuNumaCellCachesLine")]
    public interface IDomainCpuNumaCellCachesLine
    {
        /// <summary>Sets the unit for the cache line size, typically "bytes" or another libvirt-supported unit string.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unit Domain#unit}
        /// </remarks>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        string Unit
        {
            get;
        }

        /// <summary>Sets the numeric cache line size in the given unit, as a user-provided positive integer (for example 64 or 128).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuNumaCellCachesLine), fullyQualifiedName: "libvirt.domain.DomainCpuNumaCellCachesLine")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuNumaCellCachesLine
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the unit for the cache line size, typically "bytes" or another libvirt-supported unit string.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unit Domain#unit}
            /// </remarks>
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
            public string Unit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the numeric cache line size in the given unit, as a user-provided positive integer (for example 64 or 128).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
