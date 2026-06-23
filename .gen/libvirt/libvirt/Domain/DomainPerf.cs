using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainPerf")]
    public class DomainPerf : libvirt.Domain.IDomainPerf
    {
        private object? _events;

        /// <summary>Defines one or more performance monitoring events to track for the guest, each identified by a name and an enabled flag.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#performance-monitoring-events">https://libvirt.org/formatdomain.html#performance-monitoring-events</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#events Domain#events}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "events", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainPerfEvents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Events
        {
            get => _events;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainPerfEvents[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainPerfEvents).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _events = value;
            }
        }
    }
}
