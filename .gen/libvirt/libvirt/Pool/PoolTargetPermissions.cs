using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiByValue(fqn: "libvirt.pool.PoolTargetPermissions")]
    public class PoolTargetPermissions : libvirt.Pool.IPoolTargetPermissions
    {
        /// <summary>Sets the numeric group ID or group name that owns the pool target path (for example, "107" or "libvirt-qemu").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-target-elements">https://libvirt.org/formatstorage.html#storage-pool-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#group Pool#group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Group
        {
            get;
            set;
        }

        /// <summary>Sets an optional security label (such as an SELinux context) to apply to the pool target path;</summary>
        /// <remarks>
        /// the value is user-provided and backend-specific.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-target-elements">https://libvirt.org/formatstorage.html#storage-pool-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#label Pool#label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }

        /// <summary>Sets the Unix permission bits for the pool target path, as an octal string such as "0755" or "0700".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-target-elements">https://libvirt.org/formatstorage.html#storage-pool-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#mode Pool#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Sets the numeric user ID or username that owns the pool target path (for example, "107" or "qemu").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-target-elements">https://libvirt.org/formatstorage.html#storage-pool-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#owner Pool#owner}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Owner
        {
            get;
            set;
        }
    }
}
