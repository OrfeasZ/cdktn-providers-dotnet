using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysMDevSourceAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysMDevSourceAddress")]
    public interface IDomainDevicesHostdevsSubsysMDevSourceAddress
    {
        /// <summary>Exposes the UUID of the mediated device on the host, computed from the existing host mdev;</summary>
        /// <remarks>
        /// this is read-only and not settable from Terraform.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#uuid Domain#uuid}
        /// </remarks>
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        string Uuid
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysMDevSourceAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysMDevSourceAddress")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysMDevSourceAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Exposes the UUID of the mediated device on the host, computed from the existing host mdev;</summary>
            /// <remarks>
            /// this is read-only and not settable from Terraform.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#uuid Domain#uuid}
            /// </remarks>
            [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
            public string Uuid
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
