using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainMemoryBackingMemoryAccess), fullyQualifiedName: "libvirt.domain.DomainMemoryBackingMemoryAccess")]
    public interface IDomainMemoryBackingMemoryAccess
    {
        /// <summary>Sets the memory access mode;</summary>
        /// <remarks>
        /// the value is user-provided and must be one of the modes supported by libvirt for memoryBacking access (for example, platform‑specific NUMA access modes).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainMemoryBackingMemoryAccess), fullyQualifiedName: "libvirt.domain.DomainMemoryBackingMemoryAccess")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainMemoryBackingMemoryAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the memory access mode;</summary>
            /// <remarks>
            /// the value is user-provided and must be one of the modes supported by libvirt for memoryBacking access (for example, platform‑specific NUMA access modes).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
