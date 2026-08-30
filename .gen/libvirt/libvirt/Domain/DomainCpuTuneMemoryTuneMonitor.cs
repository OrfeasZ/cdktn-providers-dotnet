using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainCpuTuneMemoryTuneMonitor")]
    public class DomainCpuTuneMemoryTuneMonitor : libvirt.Domain.IDomainCpuTuneMemoryTuneMonitor
    {
        /// <summary>Sets the monitoring level for memory bandwidth (for example, a cache or memory hierarchy level), as a user-provided string understood by the hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#level Domain#level}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Level
        {
            get;
            set;
        }

        /// <summary>Specifies the set of vCPUs to monitor for memory bandwidth, using the libvirt CPU set syntax (e.g. `0-3`, `0,2,4`).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpus Domain#vcpus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Vcpus
        {
            get;
            set;
        }
    }
}
