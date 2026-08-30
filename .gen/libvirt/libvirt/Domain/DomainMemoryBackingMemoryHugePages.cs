using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainMemoryBackingMemoryHugePages")]
    public class DomainMemoryBackingMemoryHugePages : libvirt.Domain.IDomainMemoryBackingMemoryHugePages
    {
        private object? _hugepages;

        /// <summary>Defines a single huge page configuration, including page size, optional unit, and optional NUMA node set.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hugepages Domain#hugepages}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainMemoryBackingMemoryHugePagesHugepages" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hugepages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainMemoryBackingMemoryHugePagesHugepages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Hugepages
        {
            get => _hugepages;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainMemoryBackingMemoryHugePagesHugepages[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainMemoryBackingMemoryHugePagesHugepages).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hugepages = value;
            }
        }
    }
}
