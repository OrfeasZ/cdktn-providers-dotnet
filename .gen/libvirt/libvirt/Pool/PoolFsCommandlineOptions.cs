using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.pool.PoolFsCommandlineOptions")]
    public class PoolFsCommandlineOptions : libvirt.Pool.IPoolFsCommandlineOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#name Pool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
