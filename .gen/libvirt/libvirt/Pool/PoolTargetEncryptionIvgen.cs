using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.pool.PoolTargetEncryptionIvgen")]
    public class PoolTargetEncryptionIvgen : libvirt.Pool.IPoolTargetEncryptionIvgen
    {
        /// <summary>Sets the hash algorithm used by the IV generator (for example "sha1" or "sha256"); value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#hash Pool#hash}
        /// </remarks>
        [JsiiProperty(name: "hash", typeJson: "{\"primitive\":\"string\"}")]
        public string Hash
        {
            get;
            set;
        }

        /// <summary>Sets the IV generation scheme name used by the encryption layer (for example "plain", "essiv", etc.); value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#name Pool#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
