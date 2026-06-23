using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceVhostVdpa), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostVdpa")]
    public interface IDomainDevicesDisksMirrorBackingStoreSourceVhostVdpa
    {
        /// <summary>Sets the host vDPA character device path used as the backingStore source for the mirrored disk when using a vhost-vdpa backend;</summary>
        /// <remarks>
        /// the value is user-provided and must reference an existing device node (for example, /dev/vhost-vdpa0).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
        string Dev
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceVhostVdpa), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostVdpa")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostVdpa
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the host vDPA character device path used as the backingStore source for the mirrored disk when using a vhost-vdpa backend;</summary>
            /// <remarks>
            /// the value is user-provided and must reference an existing device node (for example, /dev/vhost-vdpa0).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
            /// </remarks>
            [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
            public string Dev
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
