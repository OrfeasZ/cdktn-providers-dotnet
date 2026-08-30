using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainQemuCommandline), fullyQualifiedName: "libvirt.domain.DomainQemuCommandline")]
    public interface IDomainQemuCommandline
    {
        /// <summary>Lists additional QEMU command-line arguments to append in order;</summary>
        /// <remarks>
        /// each item represents one argument token rather than a shell-joined string.
        ///
        /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#args Domain#args}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCommandlineArgs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCommandlineArgs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Args
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lists environment variables to expose to the QEMU process when starting the domain.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#envs Domain#envs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCommandlineEnvs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "envs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCommandlineEnvs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Envs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainQemuCommandline), fullyQualifiedName: "libvirt.domain.DomainQemuCommandline")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainQemuCommandline
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Lists additional QEMU command-line arguments to append in order;</summary>
            /// <remarks>
            /// each item represents one argument token rather than a shell-joined string.
            ///
            /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#args Domain#args}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCommandlineArgs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCommandlineArgs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Args
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Lists environment variables to expose to the QEMU process when starting the domain.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#envs Domain#envs}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCommandlineEnvs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "envs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCommandlineEnvs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Envs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
