using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.pool.PoolTargetTimestamps")]
    public class PoolTargetTimestamps : libvirt.Pool.IPoolTargetTimestamps
    {
        /// <summary>Sets the last access time for the pool target path;</summary>
        /// <remarks>
        /// the value is user-provided (for example, a seconds or seconds.nanoseconds timestamp as supported by libvirt).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#atime Pool#atime}
        /// </remarks>
        [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}")]
        public string Atime
        {
            get;
            set;
        }

        /// <summary>Sets the last metadata change time for the pool target path;</summary>
        /// <remarks>
        /// the value is user-provided in the timestamp format expected by libvirt.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#ctime Pool#ctime}
        /// </remarks>
        [JsiiProperty(name: "ctime", typeJson: "{\"primitive\":\"string\"}")]
        public string Ctime
        {
            get;
            set;
        }

        /// <summary>Sets the last data modification time for the pool target path;</summary>
        /// <remarks>
        /// the value is user-provided in the timestamp format expected by libvirt.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#mtime Pool#mtime}
        /// </remarks>
        [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}")]
        public string Mtime
        {
            get;
            set;
        }
    }
}
