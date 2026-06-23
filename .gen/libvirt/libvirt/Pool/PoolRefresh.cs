using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiByValue(fqn: "libvirt.pool.PoolRefresh")]
    public class PoolRefresh : libvirt.Pool.IPoolRefresh
    {
        /// <summary>Configures per-volume refresh behavior for the pool, including how each volume’s allocation is calculated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#volume Pool#volume}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.pool.PoolRefreshVolume\"}", isOptional: true)]
        public libvirt.Pool.IPoolRefreshVolume? Volume
        {
            get;
            set;
        }
    }
}
