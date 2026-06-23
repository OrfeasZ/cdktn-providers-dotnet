using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysScsiHostSource")]
    public class DomainDevicesHostdevsSubsysScsiHostSource : libvirt.Domain.IDomainDevicesHostdevsSubsysScsiHostSource
    {
        /// <summary>Sets the transport protocol used by the SCSI host adapter source (for example, "fc" for Fibre Channel);</summary>
        /// <remarks>
        /// the value is user-provided and must be supported by the host.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#protocol Domain#protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Sets the World Wide Port Name (WWPN) of the SCSI/Fibre Channel host adapter source as a user-provided string, typically a 16‑hex‑digit identifier like "5005076801401b3f".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#wwpn Domain#wwpn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wwpn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Wwpn
        {
            get;
            set;
        }
    }
}
