using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainKeyWrap), fullyQualifiedName: "libvirt.domain.DomainKeyWrap")]
    public interface IDomainKeyWrap
    {
        /// <summary>Defines one or more ciphers that can be used for s390 key-wrapping operations, each with its own name and enable/disable state.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#key-wrap">https://libvirt.org/formatdomain.html#key-wrap</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ciphers Domain#ciphers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainKeyWrapCiphers" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ciphers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainKeyWrapCiphers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ciphers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainKeyWrap), fullyQualifiedName: "libvirt.domain.DomainKeyWrap")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainKeyWrap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines one or more ciphers that can be used for s390 key-wrapping operations, each with its own name and enable/disable state.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#key-wrap">https://libvirt.org/formatdomain.html#key-wrap</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ciphers Domain#ciphers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainKeyWrapCiphers" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ciphers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainKeyWrapCiphers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ciphers
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
