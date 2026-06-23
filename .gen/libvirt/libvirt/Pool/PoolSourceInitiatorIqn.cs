using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiByValue(fqn: "libvirt.pool.PoolSourceInitiatorIqn")]
    public class PoolSourceInitiatorIqn : libvirt.Pool.IPoolSourceInitiatorIqn
    {
        /// <summary>Sets the iSCSI initiator IQN name used by the storage pool when authenticating to an iSCSI target;</summary>
        /// <remarks>
        /// the value is user-provided and should be a valid IQN string (for example, "iqn.1994-05.com.redhat:client1").
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#name Pool#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
