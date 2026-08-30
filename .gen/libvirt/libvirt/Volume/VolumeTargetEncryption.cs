using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.volume.VolumeTargetEncryption")]
    public class VolumeTargetEncryption : libvirt.Volume.IVolumeTargetEncryption
    {
        /// <summary>Sets the encryption format used for the volume; for LUKS volumes this is typically set to "luks".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#format Volume#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public string Format
        {
            get;
            set;
        }

        /// <summary>Defines the encryption cipher parameters used for the volume, such as algorithm name, mode, and hash.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#cipher Volume#cipher}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cipher", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionCipher\"}", isOptional: true)]
        public libvirt.Volume.IVolumeTargetEncryptionCipher? Cipher
        {
            get;
            set;
        }

        /// <summary>Configures the initialization vector (IV) generation method for the encrypted volume;</summary>
        /// <remarks>
        /// when present, both name and hash must be specified.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#ivgen Volume#ivgen}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ivgen", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionIvgen\"}", isOptional: true)]
        public libvirt.Volume.IVolumeTargetEncryptionIvgen? Ivgen
        {
            get;
            set;
        }

        /// <summary>Configures the libvirt secret used to supply the encryption key material for the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#secret Volume#secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionSecret\"}", isOptional: true)]
        public libvirt.Volume.IVolumeTargetEncryptionSecret? Secret
        {
            get;
            set;
        }
    }
}
