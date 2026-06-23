using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksMirrorSourceNetworkReconnect")]
    public class DomainDevicesDisksMirrorSourceNetworkReconnect : libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkReconnect
    {
        /// <summary>Sets the reconnection delay (in seconds) before retrying a failed connection to the mirrored network backing store;</summary>
        /// <remarks>
        /// value is a required user-provided non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#delay Domain#delay}
        /// </remarks>
        [JsiiProperty(name: "delay", typeJson: "{\"primitive\":\"string\"}")]
        public string Delay
        {
            get;
            set;
        }
    }
}
