using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn")]
    public class DomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn : libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn
    {
        /// <summary>Sets the iSCSI initiator name (IQN string) used when logging into the target, such as "iqn.1994-05.com.redhat:client1".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
