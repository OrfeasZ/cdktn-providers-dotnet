using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainCpuNumaCellDistances")]
    public class DomainCpuNumaCellDistances : libvirt.Domain.IDomainCpuNumaCellDistances
    {
        private object? _siblings;

        /// <summary>Lists individual NUMA distance entries from this cell to sibling NUMA cells.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#siblings Domain#siblings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "siblings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuNumaCellDistancesSiblings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Siblings
        {
            get => _siblings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainCpuNumaCellDistancesSiblings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuNumaCellDistancesSiblings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _siblings = value;
            }
        }
    }
}
