using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainNumaTune), fullyQualifiedName: "libvirt.domain.DomainNumaTune")]
    public interface IDomainNumaTune
    {
        /// <summary>Defines per-guest-NUMA-node memory policies, each entry specifying how a given guest cell maps to host NUMA nodes.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mem_nodes Domain#mem_nodes}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainNumaTuneMemNodes" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "memNodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainNumaTuneMemNodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MemNodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a global NUMA memory policy for the domain process, independent of per-cell mem_nodes settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory Domain#memory}
        /// </remarks>
        [JsiiProperty(name: "memory", typeJson: "{\"fqn\":\"libvirt.domain.DomainNumaTuneMemory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainNumaTuneMemory? Memory
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainNumaTune), fullyQualifiedName: "libvirt.domain.DomainNumaTune")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainNumaTune
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines per-guest-NUMA-node memory policies, each entry specifying how a given guest cell maps to host NUMA nodes.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mem_nodes Domain#mem_nodes}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainNumaTuneMemNodes" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memNodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainNumaTuneMemNodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MemNodes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures a global NUMA memory policy for the domain process, independent of per-cell mem_nodes settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory Domain#memory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memory", typeJson: "{\"fqn\":\"libvirt.domain.DomainNumaTuneMemory\"}", isOptional: true)]
            public libvirt.Domain.IDomainNumaTuneMemory? Memory
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainNumaTuneMemory?>();
            }
        }
    }
}
