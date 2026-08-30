using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainCpuTuneEnergyTuneMonitor")]
    public class DomainCpuTuneEnergyTuneMonitor : libvirt.Domain.IDomainCpuTuneEnergyTuneMonitor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpus Domain#vcpus}.</summary>
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}")]
        public string Vcpus
        {
            get;
            set;
        }
    }
}
