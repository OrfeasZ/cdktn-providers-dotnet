using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiByValue(fqn: "libvirt.pool.PoolSourceInitiator")]
    public class PoolSourceInitiator : libvirt.Pool.IPoolSourceInitiator
    {
        /// <summary>Sets the iSCSI Qualified Name (IQN) of the initiator, such as "iqn.1993-08.org.debian:01:123456789"; the value must be a valid IQN string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#iqn Pool#iqn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceInitiatorIqn\"}", isOptional: true)]
        public libvirt.Pool.IPoolSourceInitiatorIqn? Iqn
        {
            get;
            set;
        }
    }
}
