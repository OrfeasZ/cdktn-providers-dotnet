using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainXenCommandline), fullyQualifiedName: "libvirt.domain.DomainXenCommandline")]
    public interface IDomainXenCommandline
    {
        /// <summary>Lists additional command-line arguments to pass to the Xen qemu device model in order.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/drvxen.html">https://libvirt.org/drvxen.html</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#args Domain#args}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainXenCommandlineArgs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainXenCommandlineArgs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Args
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainXenCommandline), fullyQualifiedName: "libvirt.domain.DomainXenCommandline")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainXenCommandline
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Lists additional command-line arguments to pass to the Xen qemu device model in order.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/drvxen.html">https://libvirt.org/drvxen.html</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#args Domain#args}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainXenCommandlineArgs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainXenCommandlineArgs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Args
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
