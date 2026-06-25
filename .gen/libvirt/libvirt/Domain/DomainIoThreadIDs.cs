using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainIoThreadIDs")]
    public class DomainIoThreadIDs : libvirt.Domain.IDomainIoThreadIDs
    {
        private object? _ioThreads;

        /// <summary>Defines an individual IOThread entry within the IOThread ID set, optionally with per-thread tuning such as polling.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_threads Domain#io_threads}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainIoThreadIDsIoThreads" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioThreads", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainIoThreadIDsIoThreads\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IoThreads
        {
            get => _ioThreads;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainIoThreadIDsIoThreads[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainIoThreadIDsIoThreads).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ioThreads = value;
            }
        }
    }
}
