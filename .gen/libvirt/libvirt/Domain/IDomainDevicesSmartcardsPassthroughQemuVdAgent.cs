using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesSmartcardsPassthroughQemuVdAgent), fullyQualifiedName: "libvirt.domain.DomainDevicesSmartcardsPassthroughQemuVdAgent")]
    public interface IDomainDevicesSmartcardsPassthroughQemuVdAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsPassthroughQemuVdAgentClipBoard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSmartcardsPassthroughQemuVdAgentClipBoard? ClipBoard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsPassthroughQemuVdAgentMouse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSmartcardsPassthroughQemuVdAgentMouse? Mouse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesSmartcardsPassthroughQemuVdAgent), fullyQualifiedName: "libvirt.domain.DomainDevicesSmartcardsPassthroughQemuVdAgent")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesSmartcardsPassthroughQemuVdAgent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsPassthroughQemuVdAgentClipBoard\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSmartcardsPassthroughQemuVdAgentClipBoard? ClipBoard
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSmartcardsPassthroughQemuVdAgentClipBoard?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsPassthroughQemuVdAgentMouse\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSmartcardsPassthroughQemuVdAgentMouse? Mouse
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSmartcardsPassthroughQemuVdAgentMouse?>();
            }
        }
    }
}
