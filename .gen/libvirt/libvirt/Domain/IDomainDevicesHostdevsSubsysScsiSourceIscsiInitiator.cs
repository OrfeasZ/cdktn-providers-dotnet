using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiator), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiator")]
    public interface IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiator
    {
        /// <summary>Declares the initiator IQN block for the iSCSI connection; this must be present when specifying an explicit initiator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iqn Domain#iqn}
        /// </remarks>
        [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn? Iqn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiator), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiator")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Declares the initiator IQN block for the iSCSI connection; this must be present when specifying an explicit initiator.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iqn Domain#iqn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn? Iqn
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn?>();
            }
        }
    }
}
