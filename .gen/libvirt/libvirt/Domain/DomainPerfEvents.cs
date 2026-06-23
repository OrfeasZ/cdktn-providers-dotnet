using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainPerfEvents")]
    public class DomainPerfEvents : libvirt.Domain.IDomainPerfEvents
    {
        /// <summary>Controls whether the given perf event is active;</summary>
        /// <remarks>
        /// valid values are yes or no, enabling or disabling collection of that event.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#performance-monitoring-events">https://libvirt.org/formatdomain.html#performance-monitoring-events</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}")]
        public string Enabled
        {
            get;
            set;
        }

        /// <summary>Sets the name of the performance event to monitor, which must be one of the libvirt-supported perf event identifiers (for example, perf.cpu_cycles, perf.instructions).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#performance-monitoring-events">https://libvirt.org/formatdomain.html#performance-monitoring-events</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
