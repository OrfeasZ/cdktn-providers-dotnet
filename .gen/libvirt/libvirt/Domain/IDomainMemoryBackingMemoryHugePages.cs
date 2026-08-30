using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainMemoryBackingMemoryHugePages), fullyQualifiedName: "libvirt.domain.DomainMemoryBackingMemoryHugePages")]
    public interface IDomainMemoryBackingMemoryHugePages
    {
        /// <summary>Defines a single huge page configuration, including page size, optional unit, and optional NUMA node set.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hugepages Domain#hugepages}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainMemoryBackingMemoryHugePagesHugepages" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "hugepages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryHugePagesHugepages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Hugepages
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainMemoryBackingMemoryHugePages), fullyQualifiedName: "libvirt.domain.DomainMemoryBackingMemoryHugePages")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainMemoryBackingMemoryHugePages
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines a single huge page configuration, including page size, optional unit, and optional NUMA node set.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hugepages Domain#hugepages}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainMemoryBackingMemoryHugePagesHugepages" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hugepages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryHugePagesHugepages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Hugepages
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
