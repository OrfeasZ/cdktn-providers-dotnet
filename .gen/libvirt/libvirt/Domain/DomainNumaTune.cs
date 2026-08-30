using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainNumaTune")]
    public class DomainNumaTune : libvirt.Domain.IDomainNumaTune
    {
        private object? _memNodes;

        /// <summary>Defines per-guest-NUMA-node memory policies, each entry specifying how a given guest cell maps to host NUMA nodes.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mem_nodes Domain#mem_nodes}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainNumaTuneMemNodes" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memNodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainNumaTuneMemNodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MemNodes
        {
            get => _memNodes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainNumaTuneMemNodes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainNumaTuneMemNodes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _memNodes = value;
            }
        }

        /// <summary>Configures a global NUMA memory policy for the domain process, independent of per-cell mem_nodes settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory Domain#memory}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"fqn\":\"libvirt.domain.DomainNumaTuneMemory\"}", isOptional: true)]
        public libvirt.Domain.IDomainNumaTuneMemory? Memory
        {
            get;
            set;
        }
    }
}
