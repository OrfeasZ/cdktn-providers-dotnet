using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainCpuNumaInterconnects")]
    public class DomainCpuNumaInterconnects : libvirt.Domain.IDomainCpuNumaInterconnects
    {
        private object? _bandwidths;

        /// <summary>Defines one or more bandwidth descriptors for interconnect links between initiator and target NUMA cells.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bandwidths Domain#bandwidths}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bandwidths", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaInterconnectsBandwidths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Bandwidths
        {
            get => _bandwidths;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainCpuNumaInterconnectsBandwidths[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuNumaInterconnectsBandwidths).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bandwidths = value;
            }
        }

        private object? _latencies;

        /// <summary>Defines one or more latency descriptors for interconnect links between initiator and target NUMA cells.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#latencies Domain#latencies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "latencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaInterconnectsLatencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Latencies
        {
            get => _latencies;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainCpuNumaInterconnectsLatencies[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuNumaInterconnectsLatencies).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _latencies = value;
            }
        }
    }
}
