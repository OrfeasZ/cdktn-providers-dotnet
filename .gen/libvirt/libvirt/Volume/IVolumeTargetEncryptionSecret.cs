using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiInterface(nativeType: typeof(IVolumeTargetEncryptionSecret), fullyQualifiedName: "libvirt.volume.VolumeTargetEncryptionSecret")]
    public interface IVolumeTargetEncryptionSecret
    {
        /// <summary>Sets how the secret is referenced, typically "uuid" to reference a libvirt secret by its UUID.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#type Volume#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Exposes the UUID of the libvirt secret object providing the encryption key;</summary>
        /// <remarks>
        /// this is filled from the referenced secret and is read-only.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#uuid Volume#uuid}
        /// </remarks>
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        string Uuid
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVolumeTargetEncryptionSecret), fullyQualifiedName: "libvirt.volume.VolumeTargetEncryptionSecret")]
        internal sealed class _Proxy : DeputyBase, libvirt.Volume.IVolumeTargetEncryptionSecret
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets how the secret is referenced, typically "uuid" to reference a libvirt secret by its UUID.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#type Volume#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Exposes the UUID of the libvirt secret object providing the encryption key;</summary>
            /// <remarks>
            /// this is filled from the referenced secret and is read-only.
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#uuid Volume#uuid}
            /// </remarks>
            [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
            public string Uuid
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
