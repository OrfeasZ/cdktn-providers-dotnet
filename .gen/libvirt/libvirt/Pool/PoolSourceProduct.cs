using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.pool.PoolSourceProduct")]
    public class PoolSourceProduct : libvirt.Pool.IPoolSourceProduct
    {
        /// <summary>Sets the required product name string for the storage pool source (for example, a storage array or disk product identifier);</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
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
