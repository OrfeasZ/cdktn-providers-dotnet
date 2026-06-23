using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainCpuNuma")]
    public class DomainCpuNuma : libvirt.Domain.IDomainCpuNuma
    {
        private object? _cell;

        /// <summary>Defines a single NUMA cell in the guest, including its CPUs, memory, and optional memory-side cache configuration;</summary>
        /// <remarks>
        /// multiple cells can be specified for multi-node topologies.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cell Domain#cell}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cell", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaCell\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Cell
        {
            get => _cell;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainCpuNumaCell[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuNumaCell).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cell = value;
            }
        }

        /// <summary>Configures additional NUMA interconnect properties such as per‑pair bandwidth and latency between virtual NUMA cells.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#interconnects Domain#interconnects}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interconnects", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuNumaInterconnects\"}", isOptional: true)]
        public libvirt.Domain.IDomainCpuNumaInterconnects? Interconnects
        {
            get;
            set;
        }
    }
}
