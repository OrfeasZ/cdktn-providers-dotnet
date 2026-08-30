using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolSourceInitiatorIqn), fullyQualifiedName: "libvirt.pool.PoolSourceInitiatorIqn")]
    public interface IPoolSourceInitiatorIqn
    {
        /// <summary>Sets the iSCSI initiator IQN name used by the storage pool when authenticating to an iSCSI target;</summary>
        /// <remarks>
        /// the value is user-provided and should be a valid IQN string (for example, "iqn.1994-05.com.redhat:client1").
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#name Pool#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolSourceInitiatorIqn), fullyQualifiedName: "libvirt.pool.PoolSourceInitiatorIqn")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolSourceInitiatorIqn
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the iSCSI initiator IQN name used by the storage pool when authenticating to an iSCSI target;</summary>
            /// <remarks>
            /// the value is user-provided and should be a valid IQN string (for example, "iqn.1994-05.com.redhat:client1").
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#name Pool#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
