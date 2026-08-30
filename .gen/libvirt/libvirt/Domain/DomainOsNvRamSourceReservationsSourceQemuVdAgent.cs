using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainOsNvRamSourceReservationsSourceQemuVdAgent")]
    public class DomainOsNvRamSourceReservationsSourceQemuVdAgent : libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceQemuVdAgentClipBoard\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgentClipBoard? ClipBoard
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceQemuVdAgentMouse\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgentMouse? Mouse
        {
            get;
            set;
        }
    }
}
