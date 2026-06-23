using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiSourceHost), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceHost")]
    public interface IDomainDevicesHostdevsSubsysScsiSourceHost
    {
        /// <summary>Selects the host SCSI adapter that provides the target/LUN to be passed through to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#adapter Domain#adapter}
        /// </remarks>
        [JsiiProperty(name: "adapter", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceHostAdapter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceHostAdapter? Adapter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the SCSI address (bus, controller, target, unit) of the host-side device that is being passed through.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceHostAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceHostAddress? Address
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiSourceHost), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceHost")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceHost
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Selects the host SCSI adapter that provides the target/LUN to be passed through to the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#adapter Domain#adapter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adapter", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceHostAdapter\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceHostAdapter? Adapter
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceHostAdapter?>();
            }

            /// <summary>Defines the SCSI address (bus, controller, target, unit) of the host-side device that is being passed through.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceHostAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceHostAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceHostAddress?>();
            }
        }
    }
}
