using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksDriverIoThreads")]
    public class DomainDevicesDisksDriverIoThreads : libvirt.Domain.IDomainDevicesDisksDriverIoThreads
    {
        private object? _ioThread;

        /// <summary>Describes a single IOThread mapping entry for this disk, potentially distributing disk queues across IOThreads.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread Domain#io_thread}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksDriverIoThreadsIoThread" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioThread", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverIoThreadsIoThread\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IoThread
        {
            get => _ioThread;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesDisksDriverIoThreadsIoThread[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksDriverIoThreadsIoThread).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ioThread = value;
            }
        }
    }
}
