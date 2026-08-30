using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgent")]
    public class DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgent : libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentClipBoard\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentClipBoard? ClipBoard
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentMouse\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentMouse? Mouse
        {
            get;
            set;
        }
    }
}
