using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolSourceInitiator), fullyQualifiedName: "libvirt.pool.PoolSourceInitiator")]
    public interface IPoolSourceInitiator
    {
        /// <summary>Sets the iSCSI Qualified Name (IQN) of the initiator, such as "iqn.1993-08.org.debian:01:123456789"; the value must be a valid IQN string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#iqn Pool#iqn}
        /// </remarks>
        [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceInitiatorIqn\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolSourceInitiatorIqn? Iqn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolSourceInitiator), fullyQualifiedName: "libvirt.pool.PoolSourceInitiator")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolSourceInitiator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the iSCSI Qualified Name (IQN) of the initiator, such as "iqn.1993-08.org.debian:01:123456789"; the value must be a valid IQN string.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#iqn Pool#iqn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceInitiatorIqn\"}", isOptional: true)]
            public libvirt.Pool.IPoolSourceInitiatorIqn? Iqn
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolSourceInitiatorIqn?>();
            }
        }
    }
}
