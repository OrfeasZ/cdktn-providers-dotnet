using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsNvRamSourceReservationsSourceQemuVdAgent), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceReservationsSourceQemuVdAgent")]
    public interface IDomainOsNvRamSourceReservationsSourceQemuVdAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceQemuVdAgentClipBoard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgentClipBoard? ClipBoard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceQemuVdAgentMouse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgentMouse? Mouse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsNvRamSourceReservationsSourceQemuVdAgent), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceReservationsSourceQemuVdAgent")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceQemuVdAgentClipBoard\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgentClipBoard? ClipBoard
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgentClipBoard?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSourceQemuVdAgentMouse\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgentMouse? Mouse
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceReservationsSourceQemuVdAgentMouse?>();
            }
        }
    }
}
