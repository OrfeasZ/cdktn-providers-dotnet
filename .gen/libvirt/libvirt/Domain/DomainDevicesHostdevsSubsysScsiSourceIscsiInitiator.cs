using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiator")]
    public class DomainDevicesHostdevsSubsysScsiSourceIscsiInitiator : libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiator
    {
        /// <summary>Declares the initiator IQN block for the iSCSI connection; this must be present when specifying an explicit initiator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#iqn Domain#iqn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn? Iqn
        {
            get;
            set;
        }
    }
}
