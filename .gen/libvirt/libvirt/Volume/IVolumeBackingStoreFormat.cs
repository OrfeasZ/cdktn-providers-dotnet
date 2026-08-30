using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiInterface(nativeType: typeof(IVolumeBackingStoreFormat), fullyQualifiedName: "libvirt.volume.VolumeBackingStoreFormat")]
    public interface IVolumeBackingStoreFormat
    {
        /// <summary>Specifies the backing store format type string (for example, "raw" or "qcow2"), which must be a format supported by the hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#backing-store-elements">https://libvirt.org/formatstorage.html#backing-store-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#type Volume#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVolumeBackingStoreFormat), fullyQualifiedName: "libvirt.volume.VolumeBackingStoreFormat")]
        internal sealed class _Proxy : DeputyBase, libvirt.Volume.IVolumeBackingStoreFormat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the backing store format type string (for example, "raw" or "qcow2"), which must be a format supported by the hypervisor.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#backing-store-elements">https://libvirt.org/formatstorage.html#backing-store-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#type Volume#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
