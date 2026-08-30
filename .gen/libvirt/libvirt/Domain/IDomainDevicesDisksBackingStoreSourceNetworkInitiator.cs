using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceNetworkInitiator), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkInitiator")]
    public interface IDomainDevicesDisksBackingStoreSourceNetworkInitiator
    {
        /// <summary>Configures the iSCSI initiator IQN block for the mirrored network backing store, defining the initiator name presented to the target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iqn Domain#iqn}
        /// </remarks>
        [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkInitiatorIqn\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkInitiatorIqn? Iqn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceNetworkInitiator), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkInitiator")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkInitiator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the iSCSI initiator IQN block for the mirrored network backing store, defining the initiator name presented to the target.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iqn Domain#iqn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkInitiatorIqn\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkInitiatorIqn? Iqn
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkInitiatorIqn?>();
            }
        }
    }
}
