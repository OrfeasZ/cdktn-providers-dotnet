using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuNumaCellDistances), fullyQualifiedName: "libvirt.domain.DomainCpuNumaCellDistances")]
    public interface IDomainCpuNumaCellDistances
    {
        /// <summary>Lists individual NUMA distance entries from this cell to sibling NUMA cells.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#siblings Domain#siblings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuNumaCellDistancesSiblings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "siblings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaCellDistancesSiblings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Siblings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuNumaCellDistances), fullyQualifiedName: "libvirt.domain.DomainCpuNumaCellDistances")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuNumaCellDistances
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Lists individual NUMA distance entries from this cell to sibling NUMA cells.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#siblings Domain#siblings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuNumaCellDistancesSiblings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "siblings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaCellDistancesSiblings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Siblings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
