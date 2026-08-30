using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesConsolesSourceQemuVdAgent), fullyQualifiedName: "libvirt.domain.DomainDevicesConsolesSourceQemuVdAgent")]
    public interface IDomainDevicesConsolesSourceQemuVdAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceQemuVdAgentClipBoard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesConsolesSourceQemuVdAgentClipBoard? ClipBoard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceQemuVdAgentMouse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesConsolesSourceQemuVdAgentMouse? Mouse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesConsolesSourceQemuVdAgent), fullyQualifiedName: "libvirt.domain.DomainDevicesConsolesSourceQemuVdAgent")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesConsolesSourceQemuVdAgent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceQemuVdAgentClipBoard\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesConsolesSourceQemuVdAgentClipBoard? ClipBoard
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesConsolesSourceQemuVdAgentClipBoard?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSourceQemuVdAgentMouse\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesConsolesSourceQemuVdAgentMouse? Mouse
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesConsolesSourceQemuVdAgentMouse?>();
            }
        }
    }
}
