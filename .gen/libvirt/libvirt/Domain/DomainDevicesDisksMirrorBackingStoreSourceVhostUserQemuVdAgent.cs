using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostUserQemuVdAgent")]
    public class DomainDevicesDisksMirrorBackingStoreSourceVhostUserQemuVdAgent : libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostUserQemuVdAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#clip_board Domain#clip_board}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostUserQemuVdAgentClipBoard\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostUserQemuVdAgentClipBoard? ClipBoard
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mouse Domain#mouse}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostUserQemuVdAgentMouse\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostUserQemuVdAgentMouse? Mouse
        {
            get;
            set;
        }
    }
}
