using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuTuneMemoryTune), fullyQualifiedName: "libvirt.domain.DomainCpuTuneMemoryTune")]
    public interface IDomainCpuTuneMemoryTune
    {
        /// <summary>Specifies which vCPUs are subject to the memory tuning configuration, using libvirt CPU set syntax (e.g. `0-1`, `1,3`); this is required when memory tuning is defined.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpus Domain#vcpus}
        /// </remarks>
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}")]
        string Vcpus
        {
            get;
        }

        /// <summary>Configures which vCPUs are monitored for memory bandwidth usage and the hierarchy level at which libvirt tracks memory usage statistics.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#monitor Domain#monitor}
        /// </remarks>
        [JsiiProperty(name: "monitor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneMemoryTuneMonitor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Monitor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more NUMA memory nodes for which to apply memory bandwidth limits as part of memory tuning.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nodes Domain#nodes}
        /// </remarks>
        [JsiiProperty(name: "nodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneMemoryTuneNodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Nodes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuTuneMemoryTune), fullyQualifiedName: "libvirt.domain.DomainCpuTuneMemoryTune")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuTuneMemoryTune
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies which vCPUs are subject to the memory tuning configuration, using libvirt CPU set syntax (e.g. `0-1`, `1,3`); this is required when memory tuning is defined.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpus Domain#vcpus}
            /// </remarks>
            [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}")]
            public string Vcpus
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configures which vCPUs are monitored for memory bandwidth usage and the hierarchy level at which libvirt tracks memory usage statistics.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#monitor Domain#monitor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneMemoryTuneMonitor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Monitor
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines one or more NUMA memory nodes for which to apply memory bandwidth limits as part of memory tuning.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nodes Domain#nodes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneMemoryTuneNodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Nodes
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
