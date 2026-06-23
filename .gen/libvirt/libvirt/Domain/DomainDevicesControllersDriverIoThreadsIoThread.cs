using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesControllersDriverIoThreadsIoThread")]
    public class DomainDevicesControllersDriverIoThreadsIoThread : libvirt.Domain.IDomainDevicesControllersDriverIoThreadsIoThread
    {
        /// <summary>Identifies the IOThread instance used by this controller entry;</summary>
        /// <remarks>
        /// when omitted libvirt computes/assigns it, and when set it must match a valid IOThread id for the domain.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public double Id
        {
            get;
            set;
        }

        private object? _queues;

        /// <summary>Defines one or more queues handled by this IOThread for the controller, allowing fine-grained mapping of queue ids to threads.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#queues Domain#queues}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queues", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriverIoThreadsIoThreadQueues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Queues
        {
            get => _queues;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesControllersDriverIoThreadsIoThreadQueues[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesControllersDriverIoThreadsIoThreadQueues).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queues = value;
            }
        }
    }
}
