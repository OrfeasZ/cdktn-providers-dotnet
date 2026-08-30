using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesRedirDevsSourceQemuVdAgent), fullyQualifiedName: "libvirt.domain.DomainDevicesRedirDevsSourceQemuVdAgent")]
    public interface IDomainDevicesRedirDevsSourceQemuVdAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceQemuVdAgentClipBoard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesRedirDevsSourceQemuVdAgentClipBoard? ClipBoard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceQemuVdAgentMouse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesRedirDevsSourceQemuVdAgentMouse? Mouse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesRedirDevsSourceQemuVdAgent), fullyQualifiedName: "libvirt.domain.DomainDevicesRedirDevsSourceQemuVdAgent")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesRedirDevsSourceQemuVdAgent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceQemuVdAgentClipBoard\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesRedirDevsSourceQemuVdAgentClipBoard? ClipBoard
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesRedirDevsSourceQemuVdAgentClipBoard?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceQemuVdAgentMouse\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesRedirDevsSourceQemuVdAgentMouse? Mouse
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesRedirDevsSourceQemuVdAgentMouse?>();
            }
        }
    }
}
