using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainQemuCapabilities), fullyQualifiedName: "libvirt.domain.DomainQemuCapabilities")]
    public interface IDomainQemuCapabilities
    {
        /// <summary>Lists QEMU capabilities to add explicitly for this domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#add Domain#add}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCapabilitiesAdd" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "add", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCapabilitiesAdd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Add
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lists QEMU capabilities to remove explicitly for this domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#del Domain#del}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCapabilitiesDel" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "del", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCapabilitiesDel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Del
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainQemuCapabilities), fullyQualifiedName: "libvirt.domain.DomainQemuCapabilities")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainQemuCapabilities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Lists QEMU capabilities to add explicitly for this domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#add Domain#add}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCapabilitiesAdd" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "add", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCapabilitiesAdd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Add
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Lists QEMU capabilities to remove explicitly for this domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#del Domain#del}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCapabilitiesDel" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "del", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCapabilitiesDel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Del
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
