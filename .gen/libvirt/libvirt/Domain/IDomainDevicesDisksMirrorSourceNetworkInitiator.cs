using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorSourceNetworkInitiator), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceNetworkInitiator")]
    public interface IDomainDevicesDisksMirrorSourceNetworkInitiator
    {
        /// <summary>Configures the iSCSI initiator IQN block for the mirrored network backing store, defining the initiator name presented to the target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iqn Domain#iqn}
        /// </remarks>
        [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkInitiatorIqn\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkInitiatorIqn? Iqn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorSourceNetworkInitiator), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceNetworkInitiator")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkInitiator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the iSCSI initiator IQN block for the mirrored network backing store, defining the initiator name presented to the target.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iqn Domain#iqn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkInitiatorIqn\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkInitiatorIqn? Iqn
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkInitiatorIqn?>();
            }
        }
    }
}
