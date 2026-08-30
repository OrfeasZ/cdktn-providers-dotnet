using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksSourceNetworkInitiatorIqn), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceNetworkInitiatorIqn")]
    public interface IDomainDevicesDisksSourceNetworkInitiatorIqn
    {
        /// <summary>Sets the initiator IQN string used when logging into an iSCSI target backing the mirrored disk;</summary>
        /// <remarks>
        /// value must be a valid IQN (for example, iqn.2020-01.com.example:host1).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksSourceNetworkInitiatorIqn), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceNetworkInitiatorIqn")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksSourceNetworkInitiatorIqn
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the initiator IQN string used when logging into an iSCSI target backing the mirrored disk;</summary>
            /// <remarks>
            /// value must be a valid IQN (for example, iqn.2020-01.com.example:host1).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
