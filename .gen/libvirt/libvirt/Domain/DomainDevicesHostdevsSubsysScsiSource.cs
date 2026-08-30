using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSource")]
    public class DomainDevicesHostdevsSubsysScsiSource : libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSource
    {
        /// <summary>Describes a host-side SCSI target used as the source for the SCSI hostdev, including adapter and SCSI address information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#host Domain#host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceHost\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceHost? Host
        {
            get;
            set;
        }

        /// <summary>Defines an iSCSI-backed SCSI source for the hostdev, specifying that the passed-through SCSI device is provided by an iSCSI target;</summary>
        /// <remarks>
        /// additional connection details are given in child elements or attributes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iscsi Domain#iscsi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iscsi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsi? Iscsi
        {
            get;
            set;
        }
    }
}
