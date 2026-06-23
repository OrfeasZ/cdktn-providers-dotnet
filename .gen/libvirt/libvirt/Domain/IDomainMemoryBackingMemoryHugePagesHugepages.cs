using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainMemoryBackingMemoryHugePagesHugepages), fullyQualifiedName: "libvirt.domain.DomainMemoryBackingMemoryHugePagesHugepages")]
    public interface IDomainMemoryBackingMemoryHugePagesHugepages
    {
        /// <summary>Sets the huge page size for this entry as a required positive integer, interpreted together with the unit field (for example, 2048 with unit "KiB" for 2 MiB pages).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>Restricts use of this huge page size to a specific NUMA node set;</summary>
        /// <remarks>
        /// the value is user-provided and follows libvirt nodeset syntax (e.g. "0-1,3").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nodeset Domain#nodeset}
        /// </remarks>
        [JsiiProperty(name: "nodeset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Nodeset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the unit for the huge page size;</summary>
        /// <remarks>
        /// the value is user-provided and must be one of the libvirt-supported size units (such as "B", "KiB", "MiB", "GiB").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#unit Domain#unit}
        /// </remarks>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Unit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainMemoryBackingMemoryHugePagesHugepages), fullyQualifiedName: "libvirt.domain.DomainMemoryBackingMemoryHugePagesHugepages")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainMemoryBackingMemoryHugePagesHugepages
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the huge page size for this entry as a required positive integer, interpreted together with the unit field (for example, 2048 with unit "KiB" for 2 MiB pages).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size Domain#size}
            /// </remarks>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Restricts use of this huge page size to a specific NUMA node set;</summary>
            /// <remarks>
            /// the value is user-provided and follows libvirt nodeset syntax (e.g. "0-1,3").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nodeset Domain#nodeset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Nodeset
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the unit for the huge page size;</summary>
            /// <remarks>
            /// the value is user-provided and must be one of the libvirt-supported size units (such as "B", "KiB", "MiB", "GiB").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#unit Domain#unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Unit
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
