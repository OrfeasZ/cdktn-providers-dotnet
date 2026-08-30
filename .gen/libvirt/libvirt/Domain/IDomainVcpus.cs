using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainVcpus), fullyQualifiedName: "libvirt.domain.DomainVcpus")]
    public interface IDomainVcpus
    {
        /// <summary>Defines a single vCPU entry in the vcpus list, typically identified by an id attribute and optionally configured for pinning or hotplug behavior;</summary>
        /// <remarks>
        /// the id and other attributes are user‑provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpu Domain#vcpu}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainVcpusVcpu" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "vcpu", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainVcpusVcpu\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Vcpu
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainVcpus), fullyQualifiedName: "libvirt.domain.DomainVcpus")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainVcpus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines a single vCPU entry in the vcpus list, typically identified by an id attribute and optionally configured for pinning or hotplug behavior;</summary>
            /// <remarks>
            /// the id and other attributes are user‑provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpu Domain#vcpu}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainVcpusVcpu" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcpu", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainVcpusVcpu\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Vcpu
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
