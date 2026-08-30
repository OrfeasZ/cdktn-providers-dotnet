using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainCpuTuneVcpuSched")]
    public class DomainCpuTuneVcpuSched : libvirt.Domain.IDomainCpuTuneVcpuSched
    {
        /// <summary>Specifies which vCPUs this scheduler configuration applies to, using libvirt CPU set syntax (e.g. `0`, `0-1`, `1,3`); this attribute is required.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpus Domain#vcpus}
        /// </remarks>
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}")]
        public string Vcpus
        {
            get;
            set;
        }

        /// <summary>Sets the scheduler priority for the selected vCPUs, as an integer whose valid range depends on the chosen scheduler policy and host kernel.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#priority Domain#priority}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>Sets the scheduler policy for the selected vCPUs, using one of the supported policies such as `batch`, `fifo`, or `rr`;</summary>
        /// <remarks>
        /// if omitted, the default policy applies.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#scheduler Domain#scheduler}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scheduler", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scheduler
        {
            get;
            set;
        }
    }
}
