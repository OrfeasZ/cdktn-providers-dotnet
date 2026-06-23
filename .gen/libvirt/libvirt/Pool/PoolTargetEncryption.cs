using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.pool.PoolTargetEncryption")]
    public class PoolTargetEncryption : libvirt.Pool.IPoolTargetEncryption
    {
        /// <summary>Sets the encryption format used for the volume; for LUKS volumes this is typically set to "luks".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#format Pool#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public string Format
        {
            get;
            set;
        }

        /// <summary>Defines the encryption cipher parameters used for the volume, such as algorithm name, mode, and hash.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#cipher Pool#cipher}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cipher", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetEncryptionCipher\"}", isOptional: true)]
        public libvirt.Pool.IPoolTargetEncryptionCipher? Cipher
        {
            get;
            set;
        }

        /// <summary>Configures the initialization vector (IV) generation method for the encrypted volume;</summary>
        /// <remarks>
        /// when present, both name and hash must be specified.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#ivgen Pool#ivgen}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ivgen", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetEncryptionIvgen\"}", isOptional: true)]
        public libvirt.Pool.IPoolTargetEncryptionIvgen? Ivgen
        {
            get;
            set;
        }

        /// <summary>Configures the libvirt secret used to supply the encryption key material for the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#secret Pool#secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetEncryptionSecret\"}", isOptional: true)]
        public libvirt.Pool.IPoolTargetEncryptionSecret? Secret
        {
            get;
            set;
        }
    }
}
