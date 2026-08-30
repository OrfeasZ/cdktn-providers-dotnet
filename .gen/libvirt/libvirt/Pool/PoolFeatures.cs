using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiByValue(fqn: "libvirt.pool.PoolFeatures")]
    public class PoolFeatures : libvirt.Pool.IPoolFeatures
    {
        /// <summary>Enables configuration of the copy-on-write (COW) feature for filesystems that support it in this storage pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#cow Pool#cow}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cow", typeJson: "{\"fqn\":\"libvirt.pool.PoolFeaturesCow\"}", isOptional: true)]
        public libvirt.Pool.IPoolFeaturesCow? Cow
        {
            get;
            set;
        }
    }
}
