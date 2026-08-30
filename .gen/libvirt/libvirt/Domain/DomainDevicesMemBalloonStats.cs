using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesMemBalloonStats")]
    public class DomainDevicesMemBalloonStats : libvirt.Domain.IDomainDevicesMemBalloonStats
    {
        /// <summary>Sets the polling period in seconds for collecting memory balloon statistics;</summary>
        /// <remarks>
        /// use 0 to disable statistics, or a positive integer interval.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-balloon-device">https://libvirt.org/formatdomain.html#memory-balloon-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#period Domain#period}
        /// </remarks>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        public double Period
        {
            get;
            set;
        }
    }
}
