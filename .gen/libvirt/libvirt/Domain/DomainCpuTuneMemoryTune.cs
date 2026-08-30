using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainCpuTuneMemoryTune")]
    public class DomainCpuTuneMemoryTune : libvirt.Domain.IDomainCpuTuneMemoryTune
    {
        /// <summary>Specifies which vCPUs are subject to the memory tuning configuration, using libvirt CPU set syntax (e.g. `0-1`, `1,3`); this is required when memory tuning is defined.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpus Domain#vcpus}
        /// </remarks>
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}")]
        public string Vcpus
        {
            get;
            set;
        }

        private object? _monitor;

        /// <summary>Configures which vCPUs are monitored for memory bandwidth usage and the hierarchy level at which libvirt tracks memory usage statistics.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#monitor Domain#monitor}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneMemoryTuneMonitor" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneMemoryTuneMonitor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Monitor
        {
            get => _monitor;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainCpuTuneMemoryTuneMonitor[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneMemoryTuneMonitor).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _monitor = value;
            }
        }

        private object? _nodes;

        /// <summary>Defines one or more NUMA memory nodes for which to apply memory bandwidth limits as part of memory tuning.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nodes Domain#nodes}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneMemoryTuneNodes" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneMemoryTuneNodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Nodes
        {
            get => _nodes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainCpuTuneMemoryTuneNodes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneMemoryTuneNodes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nodes = value;
            }
        }
    }
}
