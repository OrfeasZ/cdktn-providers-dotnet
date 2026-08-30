using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesConsolesSourceQemuVdAgent")]
    public class DomainDevicesConsolesSourceQemuVdAgent : libvirt.Domain.IDomainDevicesConsolesSourceQemuVdAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceQemuVdAgentClipBoard\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourceQemuVdAgentClipBoard? ClipBoard
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceQemuVdAgentMouse\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesConsolesSourceQemuVdAgentMouse? Mouse
        {
            get;
            set;
        }
    }
}
