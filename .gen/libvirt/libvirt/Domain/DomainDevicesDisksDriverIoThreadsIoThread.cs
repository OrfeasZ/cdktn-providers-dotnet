using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksDriverIoThreadsIoThread")]
    public class DomainDevicesDisksDriverIoThreadsIoThread : libvirt.Domain.IDomainDevicesDisksDriverIoThreadsIoThread
    {
        /// <summary>Reports the IOThread id associated with this mapping entry;</summary>
        /// <remarks>
        /// it is computed from the existing IOThread configuration and not set by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
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

        /// <summary>Lists one or more queue elements to bind specific disk queues to this IOThread;</summary>
        /// <remarks>
        /// the values are user-provided queue identifiers.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#queues Domain#queues}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksDriverIoThreadsIoThreadQueues" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queues", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverIoThreadsIoThreadQueues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksDriverIoThreadsIoThreadQueues[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksDriverIoThreadsIoThreadQueues).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queues = value;
            }
        }
    }
}
