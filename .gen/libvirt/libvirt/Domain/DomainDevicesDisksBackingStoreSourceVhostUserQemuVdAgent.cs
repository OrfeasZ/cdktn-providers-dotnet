using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksBackingStoreSourceVhostUserQemuVdAgent")]
    public class DomainDevicesDisksBackingStoreSourceVhostUserQemuVdAgent : libvirt.Domain.IDomainDevicesDisksBackingStoreSourceVhostUserQemuVdAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceVhostUserQemuVdAgentClipBoard\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksBackingStoreSourceVhostUserQemuVdAgentClipBoard? ClipBoard
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceVhostUserQemuVdAgentMouse\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksBackingStoreSourceVhostUserQemuVdAgentMouse? Mouse
        {
            get;
            set;
        }
    }
}
