using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuNumaInterconnects), fullyQualifiedName: "libvirt.domain.DomainCpuNumaInterconnects")]
    public interface IDomainCpuNumaInterconnects
    {
        /// <summary>Defines one or more bandwidth descriptors for interconnect links between initiator and target NUMA cells.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bandwidths Domain#bandwidths}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuNumaInterconnectsBandwidths" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "bandwidths", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaInterconnectsBandwidths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Bandwidths
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more latency descriptors for interconnect links between initiator and target NUMA cells.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#latencies Domain#latencies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuNumaInterconnectsLatencies" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "latencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaInterconnectsLatencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Latencies
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuNumaInterconnects), fullyQualifiedName: "libvirt.domain.DomainCpuNumaInterconnects")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuNumaInterconnects
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines one or more bandwidth descriptors for interconnect links between initiator and target NUMA cells.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bandwidths Domain#bandwidths}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuNumaInterconnectsBandwidths" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bandwidths", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaInterconnectsBandwidths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Bandwidths
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines one or more latency descriptors for interconnect links between initiator and target NUMA cells.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#latencies Domain#latencies}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuNumaInterconnectsLatencies" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "latencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaInterconnectsLatencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Latencies
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
