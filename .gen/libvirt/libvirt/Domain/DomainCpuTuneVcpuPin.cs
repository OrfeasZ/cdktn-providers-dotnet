using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainCpuTuneVcpuPin")]
    public class DomainCpuTuneVcpuPin : libvirt.Domain.IDomainCpuTuneVcpuPin
    {
        /// <summary>Specifies the host CPU set to which this vCPU is pinned, using libvirt CPU set syntax (e.g. `0-3`, `2,4`); this is required for each pin entry.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cpu_set Domain#cpu_set}
        /// </remarks>
        [JsiiProperty(name: "cpuSet", typeJson: "{\"primitive\":\"string\"}")]
        public string CpuSet
        {
            get;
            set;
        }

        /// <summary>Identifies the virtual CPU index (starting at 0) that this pinning rule applies to;</summary>
        /// <remarks>
        /// this is required for each pin entry.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpu Domain#vcpu}
        /// </remarks>
        [JsiiProperty(name: "vcpu", typeJson: "{\"primitive\":\"number\"}")]
        public double Vcpu
        {
            get;
            set;
        }
    }
}
