using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgent")]
    public class DomainDevicesDisksMirrorSourceVhostUserQemuVdAgent : libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#clip_board Domain#clip_board}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentClipBoard\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgentClipBoard? ClipBoard
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mouse Domain#mouse}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentMouse\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgentMouse? Mouse
        {
            get;
            set;
        }
    }
}
