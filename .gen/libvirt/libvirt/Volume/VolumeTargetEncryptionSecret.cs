using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.volume.VolumeTargetEncryptionSecret")]
    public class VolumeTargetEncryptionSecret : libvirt.Volume.IVolumeTargetEncryptionSecret
    {
        /// <summary>Sets how the secret is referenced, typically "uuid" to reference a libvirt secret by its UUID.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#type Volume#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Exposes the UUID of the libvirt secret object providing the encryption key;</summary>
        /// <remarks>
        /// this is filled from the referenced secret and is read-only.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#uuid Volume#uuid}
        /// </remarks>
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public string Uuid
        {
            get;
            set;
        }
    }
}
