using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesMemorydevsSource), fullyQualifiedName: "libvirt.domain.DomainDevicesMemorydevsSource")]
    public interface IDomainDevicesMemorydevsSource
    {
        /// <summary>Sets the alignment size value for the backing storage or mapping of this memory device, together with align_size_unit forming a size with units;</summary>
        /// <remarks>
        /// the numeric value is user‑provided (for example, 2 or 1024).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#align_size Domain#align_size}
        /// </remarks>
        [JsiiProperty(name: "alignSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AlignSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the unit for source.align_size (for example, "B", "KiB", "MiB", "GiB"), encoded via the pagesize/alignsize attribute; the value is user‑provided but must be a valid libvirt size unit.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#align_size_unit Domain#align_size_unit}
        /// </remarks>
        [JsiiProperty(name: "alignSizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AlignSizeUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Constrains the backing of this memory device to a given host NUMA node set, using a nodemask string (for example, "0-1" or "1,3").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#node_mask Domain#node_mask}
        /// </remarks>
        [JsiiProperty(name: "nodeMask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeMask
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the page size used for backing this memory device, as a numeric value combined with page_size_unit (for example, 2048 or 1048576).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#page_size Domain#page_size}
        /// </remarks>
        [JsiiProperty(name: "pageSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PageSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the unit for source.page_size (for example, "B", "KiB", "MiB"), encoded via the pagesize attribute; the value is user‑provided but must be a valid libvirt size unit.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#page_size_unit Domain#page_size_unit}
        /// </remarks>
        [JsiiProperty(name: "pageSizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PageSizeUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides the host path to the backing object for this memory device, such as a file or special device node (for example, "/dev/dax0.0" or "/mem/pool0").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables persistent memory mode for the source when set (presence-only), indicating that the backing is treated as persistent (PMEM);</summary>
        /// <remarks>
        /// omitting or setting false leaves PMEM mode disabled.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pmem Domain#pmem}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "pmem", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Pmem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesMemorydevsSource), fullyQualifiedName: "libvirt.domain.DomainDevicesMemorydevsSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesMemorydevsSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the alignment size value for the backing storage or mapping of this memory device, together with align_size_unit forming a size with units;</summary>
            /// <remarks>
            /// the numeric value is user‑provided (for example, 2 or 1024).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#align_size Domain#align_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alignSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AlignSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Specifies the unit for source.align_size (for example, "B", "KiB", "MiB", "GiB"), encoded via the pagesize/alignsize attribute; the value is user‑provided but must be a valid libvirt size unit.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#align_size_unit Domain#align_size_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alignSizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AlignSizeUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Constrains the backing of this memory device to a given host NUMA node set, using a nodemask string (for example, "0-1" or "1,3").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#node_mask Domain#node_mask}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeMask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeMask
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the page size used for backing this memory device, as a numeric value combined with page_size_unit (for example, 2048 or 1048576).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#page_size Domain#page_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pageSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PageSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Specifies the unit for source.page_size (for example, "B", "KiB", "MiB"), encoded via the pagesize attribute; the value is user‑provided but must be a valid libvirt size unit.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#page_size_unit Domain#page_size_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pageSizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PageSizeUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provides the host path to the backing object for this memory device, such as a file or special device node (for example, "/dev/dax0.0" or "/mem/pool0").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables persistent memory mode for the source when set (presence-only), indicating that the backing is treated as persistent (PMEM);</summary>
            /// <remarks>
            /// omitting or setting false leaves PMEM mode disabled.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pmem Domain#pmem}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pmem", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Pmem
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
