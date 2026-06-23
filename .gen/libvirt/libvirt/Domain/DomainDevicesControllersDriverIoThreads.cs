using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesControllersDriverIoThreads")]
    public class DomainDevicesControllersDriverIoThreads : libvirt.Domain.IDomainDevicesControllersDriverIoThreads
    {
        private object? _ioThread;

        /// <summary>Describes a single IOThread used by the controller, optionally including an explicit id and associated queues.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_thread Domain#io_thread}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioThread", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriverIoThreadsIoThread\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesControllersDriverIoThreadsIoThread[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesControllersDriverIoThreadsIoThread).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ioThread = value;
            }
        }
    }
}
