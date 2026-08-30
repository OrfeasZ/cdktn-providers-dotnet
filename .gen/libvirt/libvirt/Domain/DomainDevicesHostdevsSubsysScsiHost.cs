using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysScsiHost")]
    public class DomainDevicesHostdevsSubsysScsiHost : libvirt.Domain.IDomainDevicesHostdevsSubsysScsiHost
    {
        /// <summary>Sets the model of SCSI host adapter to present to the guest for this hostdev;</summary>
        /// <remarks>
        /// the value is user-provided and must match a model supported by the hypervisor backend.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Model
        {
            get;
            set;
        }

        /// <summary>Defines the source characteristics of the SCSI host adapter passthrough, such as protocol and WWPN.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiHostSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysScsiHostSource? Source
        {
            get;
            set;
        }
    }
}
