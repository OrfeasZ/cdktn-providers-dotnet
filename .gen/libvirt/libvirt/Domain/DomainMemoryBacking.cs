using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainMemoryBacking")]
    public class DomainMemoryBacking : libvirt.Domain.IDomainMemoryBacking
    {
        /// <summary>Controls the memory access policy for the guest’s backed memory (for example, NUMA-related access behavior) via a mode attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_access Domain#memory_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryAccess", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryAccess\"}", isOptional: true)]
        public libvirt.Domain.IDomainMemoryBackingMemoryAccess? MemoryAccess
        {
            get;
            set;
        }

        /// <summary>Controls the allocation behavior of the backing memory, such as whether memory is preallocated and on how many threads.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_allocation Domain#memory_allocation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryAllocation", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryAllocation\"}", isOptional: true)]
        public libvirt.Domain.IDomainMemoryBackingMemoryAllocation? MemoryAllocation
        {
            get;
            set;
        }

        private object? _memoryDiscard;

        /// <summary>Enables backing memory discard behavior when present;</summary>
        /// <remarks>
        /// as a presence-only flag, setting this to true emits the element, while false or null omits it.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_discard Domain#memory_discard}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryDiscard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MemoryDiscard
        {
            get => _memoryDiscard;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _memoryDiscard = value;
            }
        }

        /// <summary>Enables and configures the use of huge pages for guest memory, allowing one or more huge page size definitions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_huge_pages Domain#memory_huge_pages}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryHugePages", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryHugePages\"}", isOptional: true)]
        public libvirt.Domain.IDomainMemoryBackingMemoryHugePages? MemoryHugePages
        {
            get;
            set;
        }

        private object? _memoryLocked;

        /// <summary>Requests that the guest’s memory be locked in host RAM (mlock) when present;</summary>
        /// <remarks>
        /// as a presence-only flag, true emits the element and false/null omits it.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_locked Domain#memory_locked}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MemoryLocked
        {
            get => _memoryLocked;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _memoryLocked = value;
            }
        }

        private object? _memoryNosharepages;

        /// <summary>Disables page sharing for the guest’s memory when present, preventing features like KSM from deduplicating pages;</summary>
        /// <remarks>
        /// as a presence-only flag, true emits the element and false/null omits it.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_nosharepages Domain#memory_nosharepages}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryNosharepages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MemoryNosharepages
        {
            get => _memoryNosharepages;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _memoryNosharepages = value;
            }
        }

        /// <summary>Selects the backing source type for guest memory (for example, anonymous, file-backed, or other hypervisor-supported sources).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_source Domain#memory_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memorySource", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemorySource\"}", isOptional: true)]
        public libvirt.Domain.IDomainMemoryBackingMemorySource? MemorySource
        {
            get;
            set;
        }
    }
}
