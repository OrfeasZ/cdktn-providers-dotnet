using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainVcpus")]
    public class DomainVcpus : libvirt.Domain.IDomainVcpus
    {
        private object? _vcpu;

        /// <summary>Defines a single vCPU entry in the vcpus list, typically identified by an id attribute and optionally configured for pinning or hotplug behavior;</summary>
        /// <remarks>
        /// the id and other attributes are user‑provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpu Domain#vcpu}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainVcpusVcpu" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpu", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainVcpusVcpu\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Vcpu
        {
            get => _vcpu;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainVcpusVcpu[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainVcpusVcpu).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vcpu = value;
            }
        }
    }
}
