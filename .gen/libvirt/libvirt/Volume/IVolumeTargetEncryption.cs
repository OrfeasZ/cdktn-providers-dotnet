using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiInterface(nativeType: typeof(IVolumeTargetEncryption), fullyQualifiedName: "libvirt.volume.VolumeTargetEncryption")]
    public interface IVolumeTargetEncryption
    {
        /// <summary>Sets the encryption format used for the volume; for LUKS volumes this is typically set to "luks".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#format Volume#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        /// <summary>Defines the encryption cipher parameters used for the volume, such as algorithm name, mode, and hash.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#cipher Volume#cipher}
        /// </remarks>
        [JsiiProperty(name: "cipher", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionCipher\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeTargetEncryptionCipher? Cipher
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the initialization vector (IV) generation method for the encrypted volume;</summary>
        /// <remarks>
        /// when present, both name and hash must be specified.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#ivgen Volume#ivgen}
        /// </remarks>
        [JsiiProperty(name: "ivgen", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionIvgen\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeTargetEncryptionIvgen? Ivgen
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the libvirt secret used to supply the encryption key material for the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#secret Volume#secret}
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionSecret\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeTargetEncryptionSecret? Secret
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVolumeTargetEncryption), fullyQualifiedName: "libvirt.volume.VolumeTargetEncryption")]
        internal sealed class _Proxy : DeputyBase, libvirt.Volume.IVolumeTargetEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the encryption format used for the volume; for LUKS volumes this is typically set to "luks".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#format Volume#format}
            /// </remarks>
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Defines the encryption cipher parameters used for the volume, such as algorithm name, mode, and hash.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#cipher Volume#cipher}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cipher", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionCipher\"}", isOptional: true)]
            public libvirt.Volume.IVolumeTargetEncryptionCipher? Cipher
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeTargetEncryptionCipher?>();
            }

            /// <summary>Configures the initialization vector (IV) generation method for the encrypted volume;</summary>
            /// <remarks>
            /// when present, both name and hash must be specified.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#ivgen Volume#ivgen}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ivgen", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionIvgen\"}", isOptional: true)]
            public libvirt.Volume.IVolumeTargetEncryptionIvgen? Ivgen
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeTargetEncryptionIvgen?>();
            }

            /// <summary>Configures the libvirt secret used to supply the encryption key material for the volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#secret Volume#secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionSecret\"}", isOptional: true)]
            public libvirt.Volume.IVolumeTargetEncryptionSecret? Secret
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeTargetEncryptionSecret?>();
            }
        }
    }
}
