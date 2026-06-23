using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiByValue(fqn: "libvirt.pool.PoolTarget")]
    public class PoolTarget : libvirt.Pool.IPoolTarget
    {
        /// <summary>Enables and configures encryption for the volume’s data, defining the cipher parameters for an encrypted image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#encryption Pool#encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetEncryption\"}", isOptional: true)]
        public libvirt.Pool.IPoolTargetEncryption? Encryption
        {
            get;
            set;
        }

        /// <summary>Sets the host path where the pool target is mapped, such as a directory for a dir/fs/netfs pool or a block device for a disk/logical pool (for example, "/var/lib/libvirt/images" or "/dev/sdb").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-target-elements">https://libvirt.org/formatstorage.html#storage-pool-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#path Pool#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Sets ownership and permission metadata applied to the pool target path, controlling which user/group and mode bits are used on the backing directory or device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#permissions Pool#permissions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetPermissions\"}", isOptional: true)]
        public libvirt.Pool.IPoolTargetPermissions? Permissions
        {
            get;
            set;
        }

        /// <summary>Sets explicit access, change, and modification timestamps on the pool target path when supported by the backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#timestamps Pool#timestamps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timestamps", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetTimestamps\"}", isOptional: true)]
        public libvirt.Pool.IPoolTargetTimestamps? Timestamps
        {
            get;
            set;
        }
    }
}
