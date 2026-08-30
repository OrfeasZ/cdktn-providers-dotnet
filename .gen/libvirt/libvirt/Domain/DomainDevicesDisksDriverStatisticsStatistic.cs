using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksDriverStatisticsStatistic")]
    public class DomainDevicesDisksDriverStatisticsStatistic : libvirt.Domain.IDomainDevicesDisksDriverStatisticsStatistic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#interval Domain#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        public double Interval
        {
            get;
            set;
        }
    }
}
