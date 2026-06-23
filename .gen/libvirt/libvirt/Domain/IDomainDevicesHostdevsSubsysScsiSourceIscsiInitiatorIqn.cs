using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn")]
    public interface IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn
    {
        /// <summary>Sets the iSCSI initiator name (IQN string) used when logging into the target, such as "iqn.1994-05.com.redhat:client1".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorIqn
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the iSCSI initiator name (IQN string) used when logging into the target, such as "iqn.1994-05.com.redhat:client1".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
