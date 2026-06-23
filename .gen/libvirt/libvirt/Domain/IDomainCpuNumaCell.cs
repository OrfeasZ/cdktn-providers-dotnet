using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuNumaCell), fullyQualifiedName: "libvirt.domain.DomainCpuNumaCell")]
    public interface IDomainCpuNumaCell
    {
        /// <summary>Sets the amount of memory assigned to this NUMA cell;</summary>
        /// <remarks>
        /// value is required and given as a numeric quantity interpreted according to the associated unit.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory Domain#memory}
        /// </remarks>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        double Memory
        {
            get;
        }

        /// <summary>Lists one or more memory-side cache definitions associated with a NUMA cell, describing cache levels and characteristics for heterogeneous memory.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#caches Domain#caches}
        /// </remarks>
        [JsiiProperty(name: "caches", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaCellCaches\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Caches
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies which vCPUs belong to a NUMA cell using a CPU list or range syntax accepted by libvirt (e.g. "0-3,8").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cpus Domain#cpus}
        /// </remarks>
        [JsiiProperty(name: "cpus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cpus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets whether pages from this NUMA cell’s memory can be discarded (hinting to the hypervisor that the memory is reclaimable);</summary>
        /// <remarks>
        /// value is user‑provided, typically a yes/no style flag if supported.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#discard Domain#discard}
        /// </remarks>
        [JsiiProperty(name: "discard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Discard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures per‑cell NUMA distance information for this virtual NUMA cell, defining relative access costs to other cells.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#distances Domain#distances}
        /// </remarks>
        [JsiiProperty(name: "distances", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuNumaCellDistances\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainCpuNumaCellDistances? Distances
        {
            get
            {
                return null;
            }
        }

        /// <summary>Reports the index of this virtual NUMA cell within the domain; it is assigned by libvirt and not user‑configurable.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the memory access policy for this NUMA cell (for example, whether memory is preferred, interleaved, or restricted to this node);</summary>
        /// <remarks>
        /// value is user‑provided according to hypervisor‑supported policies.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mem_access Domain#mem_access}
        /// </remarks>
        [JsiiProperty(name: "memAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MemAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the unit for the NUMA cell memory value (for example "KiB", "MiB", or "GiB");</summary>
        /// <remarks>
        /// value is user‑provided and must be a libvirt‑supported memory unit.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
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

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuNumaCell), fullyQualifiedName: "libvirt.domain.DomainCpuNumaCell")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuNumaCell
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the amount of memory assigned to this NUMA cell;</summary>
            /// <remarks>
            /// value is required and given as a numeric quantity interpreted according to the associated unit.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory Domain#memory}
            /// </remarks>
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
            public double Memory
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Lists one or more memory-side cache definitions associated with a NUMA cell, describing cache levels and characteristics for heterogeneous memory.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#caches Domain#caches}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "caches", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaCellCaches\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Caches
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specifies which vCPUs belong to a NUMA cell using a CPU list or range syntax accepted by libvirt (e.g. "0-3,8").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cpus Domain#cpus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cpus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets whether pages from this NUMA cell’s memory can be discarded (hinting to the hypervisor that the memory is reclaimable);</summary>
            /// <remarks>
            /// value is user‑provided, typically a yes/no style flag if supported.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#discard Domain#discard}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Discard
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures per‑cell NUMA distance information for this virtual NUMA cell, defining relative access costs to other cells.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#distances Domain#distances}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "distances", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuNumaCellDistances\"}", isOptional: true)]
            public libvirt.Domain.IDomainCpuNumaCellDistances? Distances
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainCpuNumaCellDistances?>();
            }

            /// <summary>Reports the index of this virtual NUMA cell within the domain; it is assigned by libvirt and not user‑configurable.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id Domain#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Id
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the memory access policy for this NUMA cell (for example, whether memory is preferred, interleaved, or restricted to this node);</summary>
            /// <remarks>
            /// value is user‑provided according to hypervisor‑supported policies.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mem_access Domain#mem_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MemAccess
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the unit for the NUMA cell memory value (for example "KiB", "MiB", or "GiB");</summary>
            /// <remarks>
            /// value is user‑provided and must be a libvirt‑supported memory unit.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
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
