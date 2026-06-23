using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainMemoryBackingMemorySource), fullyQualifiedName: "libvirt.domain.DomainMemoryBackingMemorySource")]
    public interface IDomainMemoryBackingMemorySource
    {
        /// <summary>Specifies the memory source type;</summary>
        /// <remarks>
        /// the value is user-provided and must be one of the libvirt-supported types for memoryBacking source (e.g. platform-specific values like "anonymous" or "file").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainMemoryBackingMemorySource), fullyQualifiedName: "libvirt.domain.DomainMemoryBackingMemorySource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainMemoryBackingMemorySource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the memory source type;</summary>
            /// <remarks>
            /// the value is user-provided and must be one of the libvirt-supported types for memoryBacking source (e.g. platform-specific values like "anonymous" or "file").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
