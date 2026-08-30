using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesSmartcardsPassthroughQemuVdAgent")]
    public class DomainDevicesSmartcardsPassthroughQemuVdAgent : libvirt.Domain.IDomainDevicesSmartcardsPassthroughQemuVdAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsPassthroughQemuVdAgentClipBoard\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesSmartcardsPassthroughQemuVdAgentClipBoard? ClipBoard
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsPassthroughQemuVdAgentMouse\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesSmartcardsPassthroughQemuVdAgentMouse? Mouse
        {
            get;
            set;
        }
    }
}
