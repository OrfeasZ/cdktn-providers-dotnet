using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.pool.PoolRefreshVolume")]
    public class PoolRefreshVolume : libvirt.Pool.IPoolRefreshVolume
    {
        /// <summary>Sets the method used to compute volume allocation during refresh;</summary>
        /// <remarks>
        /// valid values are those supported by libvirt for the pool type (user-provided, e.g. "physical" vs "logical" where applicable).
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#refresh-overrides">https://libvirt.org/formatstorage.html#refresh-overrides</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#allocation Pool#allocation}
        /// </remarks>
        [JsiiProperty(name: "allocation", typeJson: "{\"primitive\":\"string\"}")]
        public string Allocation
        {
            get;
            set;
        }
    }
}
