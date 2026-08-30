using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksSourceNetworkInitiator")]
    public class DomainDevicesDisksSourceNetworkInitiator : libvirt.Domain.IDomainDevicesDisksSourceNetworkInitiator
    {
        /// <summary>Configures the iSCSI initiator IQN block for the mirrored network backing store, defining the initiator name presented to the target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iqn Domain#iqn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkInitiatorIqn\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceNetworkInitiatorIqn? Iqn
        {
            get;
            set;
        }
    }
}
