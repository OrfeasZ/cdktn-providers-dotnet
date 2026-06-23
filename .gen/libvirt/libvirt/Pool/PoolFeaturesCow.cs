using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.pool.PoolFeaturesCow")]
    public class PoolFeaturesCow : libvirt.Pool.IPoolFeaturesCow
    {
        /// <summary>Sets whether filesystem-level copy-on-write is enabled for images in the pool; valid values are "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#features">https://libvirt.org/formatstorage.html#features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#state Pool#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public string State
        {
            get;
            set;
        }
    }
}
