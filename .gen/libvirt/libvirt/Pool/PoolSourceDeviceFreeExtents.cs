using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.pool.PoolSourceDeviceFreeExtents")]
    public class PoolSourceDeviceFreeExtents : libvirt.Pool.IPoolSourceDeviceFreeExtents
    {
        /// <summary>Sets the end offset of a free extent on the device, expressed in bytes as an integer greater than the start offset.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#device-extents">https://libvirt.org/formatstorage.html#device-extents</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#end Pool#end}
        /// </remarks>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}")]
        public double End
        {
            get;
            set;
        }

        /// <summary>Sets the start offset of a free extent on the device, expressed in bytes as a non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#device-extents">https://libvirt.org/formatstorage.html#device-extents</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#start Pool#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        public double Start
        {
            get;
            set;
        }
    }
}
