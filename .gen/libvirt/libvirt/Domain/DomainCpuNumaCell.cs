using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainCpuNumaCell")]
    public class DomainCpuNumaCell : libvirt.Domain.IDomainCpuNumaCell
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
        public double Memory
        {
            get;
            set;
        }

        private object? _caches;

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
            get => _caches;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainCpuNumaCellCaches[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuNumaCellCaches).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _caches = value;
            }
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
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Configures per‑cell NUMA distance information for this virtual NUMA cell, defining relative access costs to other cells.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#distances Domain#distances}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "distances", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuNumaCellDistances\"}", isOptional: true)]
        public libvirt.Domain.IDomainCpuNumaCellDistances? Distances
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }
    }
}
