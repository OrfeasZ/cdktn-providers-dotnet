using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainMemoryBacking), fullyQualifiedName: "libvirt.domain.DomainMemoryBacking")]
    public interface IDomainMemoryBacking
    {
        /// <summary>Controls the memory access policy for the guest’s backed memory (for example, NUMA-related access behavior) via a mode attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_access Domain#memory_access}
        /// </remarks>
        [JsiiProperty(name: "memoryAccess", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainMemoryBackingMemoryAccess? MemoryAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls the allocation behavior of the backing memory, such as whether memory is preallocated and on how many threads.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_allocation Domain#memory_allocation}
        /// </remarks>
        [JsiiProperty(name: "memoryAllocation", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryAllocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainMemoryBackingMemoryAllocation? MemoryAllocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables backing memory discard behavior when present;</summary>
        /// <remarks>
        /// as a presence-only flag, setting this to true emits the element, while false or null omits it.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_discard Domain#memory_discard}
        /// </remarks>
        [JsiiProperty(name: "memoryDiscard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MemoryDiscard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures the use of huge pages for guest memory, allowing one or more huge page size definitions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_huge_pages Domain#memory_huge_pages}
        /// </remarks>
        [JsiiProperty(name: "memoryHugePages", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryHugePages\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainMemoryBackingMemoryHugePages? MemoryHugePages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Requests that the guest’s memory be locked in host RAM (mlock) when present;</summary>
        /// <remarks>
        /// as a presence-only flag, true emits the element and false/null omits it.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_locked Domain#memory_locked}
        /// </remarks>
        [JsiiProperty(name: "memoryLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MemoryLocked
        {
            get
            {
                return null;
            }
        }

        /// <summary>Disables page sharing for the guest’s memory when present, preventing features like KSM from deduplicating pages;</summary>
        /// <remarks>
        /// as a presence-only flag, true emits the element and false/null omits it.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_nosharepages Domain#memory_nosharepages}
        /// </remarks>
        [JsiiProperty(name: "memoryNosharepages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MemoryNosharepages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the backing source type for guest memory (for example, anonymous, file-backed, or other hypervisor-supported sources).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_source Domain#memory_source}
        /// </remarks>
        [JsiiProperty(name: "memorySource", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemorySource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainMemoryBackingMemorySource? MemorySource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainMemoryBacking), fullyQualifiedName: "libvirt.domain.DomainMemoryBacking")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainMemoryBacking
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls the memory access policy for the guest’s backed memory (for example, NUMA-related access behavior) via a mode attribute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_access Domain#memory_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryAccess", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryAccess\"}", isOptional: true)]
            public libvirt.Domain.IDomainMemoryBackingMemoryAccess? MemoryAccess
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainMemoryBackingMemoryAccess?>();
            }

            /// <summary>Controls the allocation behavior of the backing memory, such as whether memory is preallocated and on how many threads.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_allocation Domain#memory_allocation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryAllocation", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryAllocation\"}", isOptional: true)]
            public libvirt.Domain.IDomainMemoryBackingMemoryAllocation? MemoryAllocation
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainMemoryBackingMemoryAllocation?>();
            }

            /// <summary>Enables backing memory discard behavior when present;</summary>
            /// <remarks>
            /// as a presence-only flag, setting this to true emits the element, while false or null omits it.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_discard Domain#memory_discard}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryDiscard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MemoryDiscard
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enables and configures the use of huge pages for guest memory, allowing one or more huge page size definitions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_huge_pages Domain#memory_huge_pages}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryHugePages", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryHugePages\"}", isOptional: true)]
            public libvirt.Domain.IDomainMemoryBackingMemoryHugePages? MemoryHugePages
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainMemoryBackingMemoryHugePages?>();
            }

            /// <summary>Requests that the guest’s memory be locked in host RAM (mlock) when present;</summary>
            /// <remarks>
            /// as a presence-only flag, true emits the element and false/null omits it.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_locked Domain#memory_locked}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MemoryLocked
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Disables page sharing for the guest’s memory when present, preventing features like KSM from deduplicating pages;</summary>
            /// <remarks>
            /// as a presence-only flag, true emits the element and false/null omits it.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_nosharepages Domain#memory_nosharepages}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryNosharepages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MemoryNosharepages
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Selects the backing source type for guest memory (for example, anonymous, file-backed, or other hypervisor-supported sources).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_source Domain#memory_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memorySource", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemorySource\"}", isOptional: true)]
            public libvirt.Domain.IDomainMemoryBackingMemorySource? MemorySource
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainMemoryBackingMemorySource?>();
            }
        }
    }
}
