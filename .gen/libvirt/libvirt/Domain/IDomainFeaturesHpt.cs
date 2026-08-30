using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesHpt), fullyQualifiedName: "libvirt.domain.DomainFeaturesHpt")]
    public interface IDomainFeaturesHpt
    {
        /// <summary>Sets the maximum page size used by the guest hashed page table;</summary>
        /// <remarks>
        /// value is a number interpreted together with max_page_size_unit (for example, 16 with unit "MiB").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_page_size Domain#max_page_size}
        /// </remarks>
        [JsiiProperty(name: "maxPageSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxPageSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the unit for hpt.max_page_size (for example "KiB", "MiB", or "GiB"); this is a string unit indicator used in combination with the numeric value.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_page_size_unit Domain#max_page_size_unit}
        /// </remarks>
        [JsiiProperty(name: "maxPageSizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxPageSizeUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether hashed page table resizing is allowed at runtime;</summary>
        /// <remarks>
        /// valid values are user-provided strings such as "on", "off", or similar policy keywords as supported by libvirt.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#resizing Domain#resizing}
        /// </remarks>
        [JsiiProperty(name: "resizing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Resizing
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesHpt), fullyQualifiedName: "libvirt.domain.DomainFeaturesHpt")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesHpt
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the maximum page size used by the guest hashed page table;</summary>
            /// <remarks>
            /// value is a number interpreted together with max_page_size_unit (for example, 16 with unit "MiB").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_page_size Domain#max_page_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxPageSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxPageSize
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the unit for hpt.max_page_size (for example "KiB", "MiB", or "GiB"); this is a string unit indicator used in combination with the numeric value.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_page_size_unit Domain#max_page_size_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxPageSizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxPageSizeUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether hashed page table resizing is allowed at runtime;</summary>
            /// <remarks>
            /// valid values are user-provided strings such as "on", "off", or similar policy keywords as supported by libvirt.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#resizing Domain#resizing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resizing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Resizing
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
